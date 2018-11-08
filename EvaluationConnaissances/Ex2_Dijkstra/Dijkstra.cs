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
        private int step = 1;
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
            Graph graph = new Graph(1);

            graph_pb.Image = Image.FromFile(graph.PictureFileLocation);

            ouverts_tb.Text = ((MyNode)graph.getOuvertsHistoric()[0][0]).ToString();
            componentList = new List<Dictionary<string, Component>>();
            componentList.Add(new Dictionary<string, Component>());
            FillDictionnaryForThisStep(step_lb,fermes_lb, fermes_tb, ouverts_lb, ouverts_tb);
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
                GoToNextStep();
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
            return true;
        }

        private void GoToNextStep()
        {
            step++;

            

            FillDictionnaryForThisStep(step_lb,fermes_lb, fermes_tb, ouverts_lb, ouverts_tb);

        }

        private void CreateNewControls()
        {
            int yLocation = this.step_lb.Location.Y + (step - 1) * 30;
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
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            char valeur = 'C';
            test_lb.Text = ((int)valeur - (int)'A').ToString();
        }

        private void graph_pb_Click(object sender, EventArgs e)
        {

        }
    }
}
