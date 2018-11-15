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
        private int ex = 1;
        private int step = 0;
        private Graph graph;
        //Liste de tous les components propres à une étape
        //Chaque indice de la 1ere liste correspond à l'étape en cours
        //Ensuite, on retrouve les components dans le dictionnaire :
        //(fermes_lb, fermés_tb,ouverts_lb, ouverts_tb)
        //Ex : componentList[0][fermés_tb] renverra à la textbox des fermés de l'étape 1
        private List<Dictionary<string,Component>> ex1ComponentsList;
        private List<TextBox> ex2TbList;

        public Dijkstra()
        {
            InitializeComponent();

            //Récupération du graph, de son image et recherche de solution
            graph = new Graph(1);
            graph_pb.Image = Image.FromFile(graph.PictureFileLocation);
            graph.computeSolution();

            //Remplissage de l'interface
            ex1ComponentsList = new List<Dictionary<string, Component>>();
            ex1ComponentsList.Add(new Dictionary<string, Component>());
            FillDictionnaryForThisStep(step_lb, fermes_lb, fermes_tb, ouverts_lb, ouverts_tb);

            //Remplissage de la textbox initiale des ouverts 
            ouverts_tb.Text = graph.SolutionTree.GetOuvertNodeFromHistoric(0, 0);
            GoToNextStep();

            test_lb.Text = graph.SolutionTree.GetFermeNodeFromHistoric(6,6);
        }


        private void ResetControls()
        {
            answersPanel.Controls.Clear();
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
                        MessageBox.Show("Juste ! ", "OK !", MessageBoxButtons.YesNo);
                        ResetControls();
                        ShowTree();
                        DisplayEx2Controls();
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
                    MessageBox.Show("Vous vous êtes trompé(e) !", "ZUT !", MessageBoxButtons.YesNo);
                }
            }
            //EX2
            else
            {
                if (IsEx2Correct())
                {
                    MessageBox.Show("Juste ! ", "OK !", MessageBoxButtons.YesNo);
                    this.Close();
                }
                else MessageBox.Show("FAUX ! ", "OK !", MessageBoxButtons.YesNo);

            }
           
            
           
        }


        private void FillDictionnaryForThisStep(Label step_lb, Label fermes_lb, TextBox fermes_tb, Label ouverts_lb, TextBox ouverts_tb)
        {
            ex1ComponentsList.Add(new Dictionary<string, Component>());
            ex1ComponentsList[step]["step_lb"] = step_lb;
            ex1ComponentsList[step]["fermes_lb"] = fermes_lb;
            ex1ComponentsList[step]["fermes_tb"] = fermes_tb;
            ex1ComponentsList[step]["ouverts_lb"] = ouverts_lb;
            ex1ComponentsList[step]["ouverts_tb"] = ouverts_tb;
        }

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
            if (step == L_Fermes_Historic.Count - 1 &&  nbFermes != L_Fermes_Historic[step].Count)
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
            if (step == L_Ouverts_Historic.Count - 1 && nbOuverts != L_Ouverts_Historic[step].Count)
                return false;

            return true;
        }

        private void GoToNextStep()
        {
            this.step++;
            CreateNewControls();
        }

        private void CreateNewControls()
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

        private void test_btn_Click(object sender, EventArgs e)
        {
            ResetControls();
            DisplayEx2Controls();
            ShowTree();

            //int n = 1;
            foreach (MyNode node in graph.SearchList)
            {
                test_lb.Text += " " + node.ToString();
            }

            for (int i = 0; i < ex2TbList.Count; i++)
            {
                ex2TbList[i].Text = graph.SearchList[i+1].GetGCost().ToString();
            }



            //TreeNode currentNode;
            //foreach (TreeNode node in graph.TreeView.Nodes)
            //{
            //    currentNode = node;
            //    while (currentNode.GetNodeCount() != 0)

            //    test_lb.Text += " " + node.ToString();

            //}

        }

        private bool IsNodeInHistoricList(List<List<GenericNode>> HistoricList, int nodeNb, int step)
        {
            //Ne dépasse t on pas la taille de la liste ?
            if (HistoricList.Count >= step)
            {
                foreach (MyNode node in HistoricList[step])
                {
                    if (nodeNb == node.Number)
                        return true;
                }
            }
            else test_lb.Text = "SI";
            
            return false;
        }

        private int CharToInt(char value)
        {
            return (int)value - (int)'A';
        }

        private char IntToChar(int value)
        {
            return Convert.ToChar(value + (int)'A');
        }

        private void ChangeStepLbColor(Color color)
        {
            ((Label)ex1ComponentsList[step]["step_lb"]).BackColor = color;
        }

        private bool IsEx1Finished()
        {
            if (graph.SolutionTree.GetOuvertNodeFromHistoric(step, 0) == null)
                return true;
            else return false;
        }

        private void DisableTextBoxesForThisStep()
        {
            ((TextBox)ex1ComponentsList[step]["ouverts_tb"]).Enabled = false;
            ((TextBox)ex1ComponentsList[step]["fermes_tb"]).Enabled = false;
        }

        private void ShowTree()
        {
            //ResetControls();
            TreeView TV = graph.TreeView;
            TV.Size = new Size(150,400);
            this.answersPanel.Controls.Add(TV);
        }


        private void DisplayEx2Controls()
        {
            ex=2;
            validate_btn.Text = "Valider";
            int x = 300;
            int y = 0;
            ex2TbList = new List<TextBox>();

            foreach (MyNode node in graph.SearchList)
            {
                //Ici, on préfère parcourir SearchList au lieu de la liste retournée par GetEnfants
                //pour conserver l'odre des noeuds présents dans SearchList. Cela facilite ainsi la vérification.
                foreach(MyNode child in graph.SearchList)
                {
                    if (node.GetEnfants().Contains(child))
                    {
                        Label parentNode = new Label();
                        parentNode.Size = new Size(20, 15);
                        parentNode.Location = new Point(x, y);
                        parentNode.Text = node.ToString();
                        this.answersPanel.Controls.Add(parentNode);

                        Label arrow = new Label();
                        arrow.Size = new Size(20, 15);
                        arrow.Location = new Point(x + 15, y);
                        arrow.Text = "-->";
                        this.answersPanel.Controls.Add(arrow);

                        Label childNode = new Label();
                        childNode.Size = new Size(20, 15);
                        childNode.Location = new Point(x + 35, y);
                        childNode.Text = child.ToString() + " : ";
                        this.answersPanel.Controls.Add(childNode);

                        TextBox nodeInfo = new TextBox();
                        nodeInfo.Size = new Size(20, 15);
                        nodeInfo.Location = new Point(x + 55, y);
                        this.answersPanel.Controls.Add(nodeInfo);
                        ex2TbList.Add(nodeInfo);

                        y += 35;
                    }
                }
            }
        }

        private bool IsEx2Correct()
        {
            //On parcourt toutes les textboxes
            for (int n = 0; n < ex2TbList.Count; n++)
            {
                string userAnswer = ex2TbList[n].Text;
                string realAnswer = graph.SearchList[n + 1].GetGCost().ToString();

                if (userAnswer != realAnswer)
                    return false;
            }

            return true;
        }

    }
}
