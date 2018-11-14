using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Ex1_Questionnaire
{
    public partial class Questionnaire : Form
    {
        List<int> numQuestions = new List<int>();
        Question actualQuestion;
        Random r = new Random();
        int numberQuest;
        int count = 0;

        public Questionnaire()
        {
            InitializeComponent();

            initializeQuestions();
            numberQuest = randomQuestion();
            actualize(numberQuest);

        }

        private void answer_tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void validate_btn_Click(object sender, EventArgs e)
        {
            int nextQuest;
            if (count % 2 == 0)
            {
                question_tb.Text = actualQuestion.GoodAnswer;
                validate_btn.Text = "Suivant";

                //Récupération réponse donnée
                string answer = "";
                if (answer1_rbtn.Checked == true)
                    answer = "A";
                if (answer1_rbtn.Checked == true)
                    answer = "B";
                if (answer1_rbtn.Checked == true)
                    answer = "C";
                if (answer1_rbtn.Checked == true)
                    answer = "D";
                else
                {
                    Form alerte = new Form();
                    alerte.Show();
                }

                //Analyse réponse donnée VS réponse attendue
                if (answer != actualQuestion.GoodAnswer)
                {

                }
                if (actualQuestion.Explanation != "")
                {
                    explain_picture.Visible = false;
                    explain_tb.Text = actualQuestion.Explanation;
                }
            }
            else
            {
                validate_btn.Text = "Valider";
                nextQuest = randomQuestion();
                actualize(nextQuest);
            }
            count += 1;
        }

        private void answer1_rbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void questionNumber_lb_Load(object sender, EventArgs e)
        {

        }

        //Actualisation question
        private void actualize(int numberQuest)
        {
            bool next = false;
            while (count< 42 && next == false)
            {
                if (numberQuest == 0)
                {
                    //Afficher score + message de fin
                }
                else
                {
                    Question question = new Question(numberQuest);
                    questionNb_lb.Text = Convert.ToString(count / 2) + "/20";
                    question_tb.Text = question.QuestionText;
                    if (question.HasImage)
                    {
                        pictureQuestion.Visible = true;
                        pictureQuestion.BackgroundImage = question.Image;
                        question_tb.Location = new Point(173, 61);
                    }

                    else
                    {
                        pictureQuestion.Visible = false;
                        question_tb.Location = new Point(173, 198);
                    }
                    answer1_rbtn.Text = question.Answers[0];
                    answer1_rbtn.Checked = false;
                    answer2_rbtn.Text = question.Answers[1];
                    answer2_rbtn.Checked = false;
                    answer3_rbtn.Text = question.Answers[2];
                    answer3_rbtn.Checked = false;
                    answer4_rbtn.Text = question.Answers[3];
                    answer4_rbtn.Checked = false;

                    actualQuestion = question;
                    progressBar.Value += 1;
                    next = true;
                }
            }
        }

        //Générer liste contenant toutes les questions
        public void initializeQuestions()
        {
            for (int i=1; i<22; i+=1)
            {
                numQuestions.Add(i);
            }
        }

        //Choix de questions aléatoire
        private int randomQuestion()
        {
            if (numQuestions.Count != 0)
            {
                int random = r.Next(0, numQuestions.Count());
                numberQuest = numQuestions[random];
                numQuestions.Remove(item: numberQuest);
            }
            else
                numberQuest = 0;
            return numberQuest;

        }

        private void graph_pb_Click(object sender, EventArgs e)
        {

        }

        private void graph_pb_Click_1(object sender, EventArgs e)
        {

        }

        private void question_lb_Click(object sender, EventArgs e)
        {

        }

        private void answerA_lb_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            progressBar.ForeColor = Color.DodgerBlue;
        }

        private void answer_tb_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
