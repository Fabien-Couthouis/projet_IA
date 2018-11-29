using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2_Dijkstra
{
    public partial class Dijkstra : Form
    {
        public static int totalScore = 0;
        public static bool completed = false;
        private TreeNode selectedNode;

        private Form mainMenu;
        /// <summary>
        /// Exercice en cours (1 ou 2)
        /// </summary>
        private int ex = 1;
        /// <summary>
        /// Étape en cours (ex1)
        /// </summary>
        private int step = 0;
        private Graph graph;

        /// <summary>
        /// Liste de tous les components propres à une étape (ex1).
        /// </summary>
        /// //Chaque indice de la 1ere liste correspond à l'étape en cours
        //Ensuite, on retrouve les components dans le dictionnaire :
        //(fermes_lb, fermés_tb,ouverts_lb, ouverts_tb)
        //Ex : componentList[0][fermés_tb] renverra à la textbox des fermés de l'étape 1
        private List<Dictionary<string,Component>> ex1ComponentsList;

        //Constructeur avec menu principal (permet d'y revenir si il existe à la fin de l'exercice)
        public Dijkstra(Form mainMenu):this()
        {
            this.mainMenu = mainMenu;
        }
        public Dijkstra()
        {
            InitializeComponent();

            //Récupération du graph, de son image et recherche de solution
            graph = new Graph(1);
            graph_pb.Image = Image.FromFile(graph.PictureFileLocation);
            graph.computeSolution();

            GoToEx1();
        }

        /// <summary>
        /// Initialiser l'ex1.
        /// </summary>
        private void GoToEx1()
        {
            //On complete la question avec les noeuds finaux et initiaux
            question_lb.Text += IntToChar(graph.FirstNode) + " et " + IntToChar(graph.LastNode) + ".";

            //Remplissage de l'interface
            ex1ComponentsList = new List<Dictionary<string, Component>>();
            ex1ComponentsList.Add(new Dictionary<string, Component>());
            FillDictionnaryForThisStep(step_lb, fermes_lb, fermes_tb, ouverts_lb, ouverts_tb);

            //Remplissage de la textbox initiale des ouverts 
            ouverts_tb.Text = graph.SolutionTree.GetOuvertNodeFromHistoric(0, 0);
            GoToNextStep();
        }


        /// <summary>
        /// Retire tous les controls présents dans le panel des réponses.
        /// </summary>
        private void ResetControls()
        {
            answersPanel.Dispose();
            validate_btn.Text = "Valider";
            ex1ComponentsList = new List<Dictionary<string, Component>>();
        }

        private void validate_btn_Click(object sender, EventArgs e)
        {
            //EX1
            if (ex == 1)
            {
                if (IsEx1StepCorrect())
                {
                    ChangeStepLbColor(Color.LightGreen);
                    if (IsEx1Finished())
                    {
                        MessageBox.Show("Juste ! ", "OK !");
                        totalScore += 2;
                        GoToEx2();
                    }
                    else
                    {
                        DisableTextBoxesForThisStep();
                        GoToNextStep();
                    }
                }
                else
                {
                    ChangeStepLbColor(Color.Red);
                    MessageBox.Show("Vous vous êtes trompé(e) !", "ZUT !");
                    GoToEx2();
                }
            }
            //EX2
            else
            {
                if (IsEx2Correct())
                {
                    MessageBox.Show("Juste ! ", "OK !");
                    totalScore += 1;
                }
                else
                {
                    MessageBox.Show("FAUX ! ", "ZUT !");
                }

                MessageBox.Show("Votre note sur cette partie 2 est de : " + totalScore + "/3", "Note");
                completed = true;
                if (mainMenu != null)
                {
                    mainMenu.Show();   
                }

                this.Close();
            }
           
        }

        /// <summary>
        /// Afficher l'exercice 2;
        /// </summary>
        private void GoToEx2()
        {
            ResetControls();
            ex = 2;
            question_lb.Text = "Appliquez toujours Dijkstra entre " + IntToChar(graph.FirstNode) + " et " + IntToChar(graph.LastNode) + ".";
            question_lb.Text += " Cette fois-ci, remplissez l'arbre final correctement structuré. Vous renseignerez chaque noeud ainsi que sa distance au noeud initial. (ex B:3).";
            
            ShowTree();
        }

        /// <summary>
        /// Ajoute les controls dans le dictionnaire des controls pour l'étape en cours.
        /// </summary>
        private void FillDictionnaryForThisStep(Label step_lb, Label fermes_lb, TextBox fermes_tb, Label ouverts_lb, TextBox ouverts_tb)
        {
            ex1ComponentsList.Add(new Dictionary<string, Component>());
            ex1ComponentsList[step]["step_lb"] = step_lb;
            ex1ComponentsList[step]["fermes_lb"] = fermes_lb;
            ex1ComponentsList[step]["fermes_tb"] = fermes_tb;
            ex1ComponentsList[step]["ouverts_lb"] = ouverts_lb;
            ex1ComponentsList[step]["ouverts_tb"] = ouverts_tb;
        }

        /// <summary>
        /// Vérifier si la réponse donnée à l'étape en cours est correcte (ex1).
        /// </summary>
        /// <returns></returns>
        private bool IsEx1StepCorrect()
        {
            //Vérification de la textbox des fermés pour l'étape en cours
            List <List<GenericNode>> L_Fermes_Historic = graph.SolutionTree.L_Fermes_Historic;
            int nbFermes = 0;
            foreach (char content in ((TextBox)ex1ComponentsList[step]["fermes_tb"]).Text)
            {
                //On saute les blancs et les séparateurs
                if (content != ' ' && content != ',' && content != ';')
                {
                    if (!IsNodeInHistoricList(L_Fermes_Historic, CharToInt(content), step))
                    {
                        return false;
                    }
                    else nbFermes++;
                }
                    
            }

            //Verifier si l'élève a bien entré tous les fermés
            if (step <= L_Fermes_Historic.Count - 1 &&  nbFermes != L_Fermes_Historic[step].Count)
                return false;


            //Vérification de la textbox des ouverts pour l'étape en cours
            List<List<GenericNode>> L_Ouverts_Historic = graph.SolutionTree.L_Ouverts_Historic;
            int nbOuverts = 0;
            foreach (char content in ((TextBox)ex1ComponentsList[step]["ouverts_tb"]).Text)
            {
                //On saute les blancs et les séparateurs
                if (content != ' ' && content != ',' && content != ';')
                {
                    if (!IsNodeInHistoricList(L_Ouverts_Historic, CharToInt(content), step))
                    {
                        return false;
                    }
                    else nbOuverts++;
                }
            }

            //Verifier si l'élève a bien entré tous les ouverts
            if (step <= L_Ouverts_Historic.Count - 1 && nbOuverts != L_Ouverts_Historic[step].Count)
                return false;

            return true;
        }

        /// <summary>
        /// Passe à l'étape supérieur (ex1).
        /// </summary>
        private void GoToNextStep()
        {
            this.step++;
            DisplayEx1Controls();
        }

        /// <summary>
        /// Affiche tous les controls relatifs à l'exercice 1, pour l'étape en cours.
        /// </summary>
        private void DisplayEx1Controls()
        {
            int yLocation = this.step_lb.Location.Y + step * 30;
            Size lbSize = this.ouverts_lb.Size;
            Size tbSize = this.ouverts_tb.Size;

            //Step_lb
            Label step_lb = new Label();
            step_lb.Location = new Point(this.step_lb.Location.X, yLocation);
            step_lb.Visible = true;
            step_lb.Text = "Étape " + step;
            step_lb.Size = this.step_lb.Size;
            this.answersPanel.Controls.Add(step_lb);

            //fermes_lb
            Label fermes_lb = new Label();
            fermes_lb.Location = new Point(this.fermes_lb.Location.X, yLocation);
            fermes_lb.Visible = true;
            fermes_lb.Text = "F = ";
            fermes_lb.Size = lbSize;
            //Controls.Add(fermes_lb);
            this.answersPanel.Controls.Add(fermes_lb);

            //fermes_tb
            TextBox fermes_tb = new TextBox();
            fermes_tb.Location = new Point(this.fermes_tb.Location.X, yLocation);
            fermes_tb.Visible = true;
            fermes_tb.Size = tbSize;
            //Controls.Add(fermes_tb);
            this.answersPanel.Controls.Add(fermes_tb);

            //ouverts_lb
            Label ouverts_lb = new Label();
            ouverts_lb.Location = new Point(this.ouverts_lb.Location.X, yLocation);
            ouverts_lb.Visible = true;
            ouverts_lb.Text = "O = ";
            ouverts_lb.Size = lbSize;
            this.answersPanel.Controls.Add(ouverts_lb);
            //Controls.Add(ouverts_lb);

            //ouverts_tb
            TextBox ouverts_tb = new TextBox();
            ouverts_tb.Location = new Point(this.ouverts_tb.Location.X, yLocation);
            ouverts_tb.Visible = true;
            ouverts_tb.Size = tbSize;
            //Controls.Add(ouverts_tb);
            this.answersPanel.Controls.Add(ouverts_tb);

            //remplissage du dictionnaire de composants avec les composants crées
            FillDictionnaryForThisStep(step_lb, fermes_lb, fermes_tb, ouverts_lb, ouverts_tb);
        }


        /// <summary>
        /// Regarder si un noeud est présent dans la liste passée en paramètre, à une étape donnée.
        /// </summary>
        /// <param name="HistoricList"></param>
        /// <param name="nodeNb"></param>
        /// <param name="step"></param>
        /// <returns></returns>
        private bool IsNodeInHistoricList(List<List<GenericNode>> HistoricList, int nodeNb, int step)
        {
            //Ne dépasse t on pas la taille de la liste ?
            if (HistoricList.Count >= step)
            {
                //Noeud dans la liste ?
                foreach (MyNode node in HistoricList[step])
                {
                    if (nodeNb == node.Number)
                        return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Convertir un caractère alphanumérique en entier (A=0, etc)
        /// </summary>
        /// <param name="value">Lettre de l'alphabet de A à Z (majuscule).</param>
        /// <returns></returns>
        private int CharToInt(char value)
        {
            return (int)value - (int)'A';
        }

        /// <summary>
        /// Convertir un entier en caractère alphanumérique (0=A, etc).
        /// </summary>
        /// <param name="value">Entier de 0 à 25.</param>
        /// <returns></returns>
        private char IntToChar(int value)
        {
            return Convert.ToChar(value + (int)'A');
        }

        /// <summary>
        /// Changer la couleur du fond du label correspondant à l'étape en cours.
        /// </summary>
        /// <param name="color"></param>
        private void ChangeStepLbColor(Color color)
        {
            ((Label)ex1ComponentsList[step]["step_lb"]).BackColor = color;
        }

        /// <summary>
        /// Vérifier si l'ex1 est terminé.
        /// </summary>
        /// <returns></returns>
        private bool IsEx1Finished()
        {
            if (graph.SolutionTree.GetOuvertNodeFromHistoric(step, 0) == null)
                return true;
            else return false;
        }

        /// <summary>
        /// Désactive les textboxes de l'étape, pour que l'utilisateur ne puisse plus modifier son contenu.
        /// </summary>
        private void DisableTextBoxesForThisStep()
        {
            ((TextBox)ex1ComponentsList[step]["ouverts_tb"]).Enabled = false;
            ((TextBox)ex1ComponentsList[step]["fermes_tb"]).Enabled = false;
        }

        /// <summary>
        /// Affiche l'arbre du graphe étudié.
        /// </summary>
        private void ShowTree()
        {
            graph.SolutionTree.GetSearchTrees(new TreeView(), treeView);      
            treeView.Visible = true;
        }

        /// <summary>
        /// Vérifier si l'ex2 est terminé.
        /// </summary>
        /// <returns></returns>
        private bool IsEx2Correct()
        {
            TreeNode initialTN = treeView.Nodes[0];
            GenericNode initialGN = graph.SearchList[0];
            if (!VerifyChildren(initialTN, initialGN))
                return false;
            return true;
        }

        //Vérification des noeuds par récurence
        private bool VerifyChildren(TreeNode tn, GenericNode gn)
        {
            foreach (TreeNode childTN in tn.Nodes)
            {
                bool isCorrect = false;
                GenericNode childGN = null;
                foreach (GenericNode potentialChildGN in gn.GetEnfants())
                {
                    
                    //Regarde si le nombre de caracteres entrés est bien d'au moins 3 (+10 faisant référence aux caractères précédant le nom du noeud dans le ToString des TreeNode)
                    if (childTN.ToString().Length < 12)
                    {
                        return false;
                    }

                    //Les (nombreux) ToString sont là pour convertir correctement les valeurs ...
                    char givenNode = childTN.ToString()[10];
                    char expectedNode = potentialChildGN.ToString()[0];
                    string givenCost = childTN.ToString().Substring(12).ToString();
                    string expectedCost = potentialChildGN.GetGCost().ToString();

                    if (givenNode == expectedNode && givenCost == expectedCost)
                    {
                        isCorrect = true;
                        childGN = potentialChildGN;
                    }
                }

                if (!isCorrect)
                {
                    return false;
                }

                if (childTN.Nodes.Count > 0)
                {
                    return VerifyChildren(childTN, childGN);
                }

            }
            return true;
        }



        #region
        //Edition du treeview : source = https://docs.microsoft.com/fr-fr/dotnet/api/system.windows.forms.treeview.labeledit?view=netframework-4.7.2 

            /* Get the tree node under the mouse pointer and 
   save it in the mySelectedNode variable. */
        private void treeView_MouseDown(object sender,
          System.Windows.Forms.MouseEventArgs e)
        {
            selectedNode = treeView.GetNodeAt(e.X, e.Y);
        }

        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            if (selectedNode != null && selectedNode.Parent != null)
            {
                treeView.SelectedNode = selectedNode;
                treeView.LabelEdit = true;
                if (!selectedNode.IsEditing)
                {
                    selectedNode.BeginEdit();
                }
            }
            else
            {
                MessageBox.Show("No tree node selected or selected node is a root node.\n" +
                   "Editing of root nodes is not allowed.", "Invalid selection");
            }
        }
        #endregion


    }
}
