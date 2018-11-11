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
        private int step = 0;
        private Graph graph;
        //Liste de tous les components propres à une étape
        //Chaque indice de la 1ere liste correspond à l'étape en cours
        //Ensuite, on retrouve les components dans le dictionnaire :
        //(fermes_lb, fermés_tb,ouverts_lb, ouverts_tb)
        //Ex : componentList[0][fermés_tb] renverra à la textbox des fermés de l'étape 1
        private List<Dictionary<string,Component>> componentList;
        public Dijkstra()
        {
            InitializeComponent();

            //Récupération du graph, de son image et recherche de solution
            graph = new Graph(1);
            graph_pb.Image = Image.FromFile(graph.PictureFileLocation);
            graph.getSolution();

            //Remplissage de l'interface
            componentList = new List<Dictionary<string, Component>>();
            componentList.Add(new Dictionary<string, Component>());
            FillDictionnaryForThisStep(step_lb,fermes_lb, fermes_tb, ouverts_lb, ouverts_tb);

            //Remplissage de la textbox initiale des ouverts 
            ouverts_tb.Text = graph.SolutionTree.GetOuvertNodeFromHistoric(0, 0);
            GoToNextStep();

            test_lb.Text = graph.SolutionTree.GetFermeNodeFromHistoric(6,6);



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void validate_btn_Click(object sender, EventArgs e)
        {

            if (IsStepCorrect())
            {
                ChangeStepLbColor(Color.LightGreen);
                if (IsFinished())
                {
                    MessageBox.Show("Juste ! ", "OK !", MessageBoxButtons.YesNo);
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
                MessageBox.Show("Vous vous êtes trompé(e) :( (-2 points :/)", "ZUT !", MessageBoxButtons.YesNo);
            }
            
           
        }

        private void FillDictionnaryForThisStep(Label step_lb, Label fermes_lb, TextBox fermes_tb, Label ouverts_lb, TextBox ouverts_tb)
        {
            componentList.Add(new Dictionary<string, Component>());
            componentList[step]["step_lb"] = step_lb;
            componentList[step]["fermes_lb"] = fermes_lb;
            componentList[step]["fermes_tb"] = fermes_tb;
            componentList[step]["ouverts_lb"] = ouverts_lb;
            componentList[step]["ouverts_tb"] = ouverts_tb;
        }

        private bool IsStepCorrect()
        {
            //Vérification de la textbox des fermés pour l'étape en cours
            List <List<GenericNode>> L_Fermes_Historic = graph.SolutionTree.L_Fermes_Historic;
            int nbFermes = 0;
            foreach (char content in ((TextBox)componentList[step]["fermes_tb"]).Text)
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
            foreach (char content in ((TextBox)componentList[step]["ouverts_tb"]).Text)
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
            Controls.Add(step_lb);

            //fermes_lb
            Label fermes_lb = new Label();
            fermes_lb.Location = new Point(this.fermes_lb.Location.X, yLocation);
            fermes_lb.Visible = true;
            fermes_lb.Text = "F = ";
            fermes_lb.Size = lbSize;
            Controls.Add(fermes_lb);

            //fermes_tb
            TextBox fermes_tb = new TextBox();
            fermes_tb.Location = new Point(this.fermes_tb.Location.X, yLocation);
            fermes_tb.Visible = true;
            fermes_tb.Size = tbSize;
            Controls.Add(fermes_tb);

            //ouverts_lb
            Label ouverts_lb = new Label();
            ouverts_lb.Location = new Point(this.ouverts_lb.Location.X, yLocation);
            ouverts_lb.Visible = true;
            ouverts_lb.Text = "O = ";
            ouverts_lb.Size = lbSize;
            Controls.Add(ouverts_lb);

            //ouverts_tb
            TextBox ouverts_tb = new TextBox();
            ouverts_tb.Location = new Point(this.ouverts_tb.Location.X, yLocation);
            ouverts_tb.Visible = true;
            ouverts_tb.Size = tbSize;
            Controls.Add(ouverts_tb);

            //remplissage du dictionnaire de composants avec les composants crées
            FillDictionnaryForThisStep(step_lb, fermes_lb, fermes_tb, ouverts_lb, ouverts_tb);
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            test_lb.Text = "step : " + step;
        }

        private void graph_pb_Click(object sender, EventArgs e)
        {

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

        private int CharToInt(char valeur)
        {
            return (int)valeur - (int)'A';
        }

        private void ChangeStepLbColor(Color color)
        {
            ((Label)componentList[step]["step_lb"]).BackColor = color;
        }

        private bool IsFinished()
        {
            if (graph.SolutionTree.GetOuvertNodeFromHistoric(step, 0) == null)
                return true;
            else return false;
        }

        private void DisableTextBoxesForThisStep()
        {
            ((TextBox)componentList[step]["ouverts_tb"]).Enabled = false;
            ((TextBox)componentList[step]["fermes_tb"]).Enabled = false;
        }
    }
}
