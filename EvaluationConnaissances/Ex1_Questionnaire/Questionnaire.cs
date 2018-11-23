using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Questionnaire
{
    public partial class Questionnaire : Form
    {
        List<int> numQuestions = new List<int>();
        Question actualQuestion;
        Random r = new Random();
        int numberQuest;
        int count = 0; //compte les clics effectués
        int score = 0;

        public Questionnaire()
        {
            InitializeComponent();
            answer1_rbtn.Checked = false;
            answer2_rbtn.Checked = false;
            answer3_rbtn.Checked = false;
            answer4_rbtn.Checked = false;
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
            //Lorsque l'on valide la réponse
            if (count % 2 == 0)
            {
                validate_btn.Text = "Suivant";

                //Récupération réponse donnée
                string answer = "";
                if (answer1_rbtn.Checked == true)
                    answer = "A";
                if (answer2_rbtn.Checked == true)
                    answer = "B";
                if (answer3_rbtn.Checked == true)
                    answer = "C";
                if (answer4_rbtn.Checked == true)
                    answer = "D";
                if (answer1_rbtn.Checked != true && answer2_rbtn.Checked != true && answer3_rbtn.Checked != true && answer4_rbtn.Checked != true)
                {
                    Alerte alerte = new Alerte();
                    alerte.Show();
                }

                //Analyse réponse donnée VS réponse attendue
                verdict_tb.Visible = true;
                question_pic.Visible = false;
                question_tb.Location = new Point(179, 73);
                if (answer == Convert.ToString(actualQuestion.GoodAnswer))
                {
                    verdict_tb.Text = "BRAVO !";
                    verdict_tb.TextAlign = HorizontalAlignment.Center;
                    verdict_tb.ForeColor = Color.Green;
                    score+=actualQuestion.Points;
                    if (actualQuestion.GoodAnswer == "A")
                        answer1_rbtn.BackColor = Color.Green;
                    if (actualQuestion.GoodAnswer == "B")
                        answer2_rbtn.BackColor = Color.Green;
                    if (actualQuestion.GoodAnswer == "C")
                        answer3_rbtn.BackColor = Color.Green;
                    if (actualQuestion.GoodAnswer == "D")
                        answer4_rbtn.BackColor = Color.Green;
                    score += Convert.ToInt32(actualQuestion.Points);
                }

                if (answer != Convert.ToString(actualQuestion.GoodAnswer))
                {
                    verdict_tb.Text = "RATÉ !";
                    //verdict_tb.Location = new Location(240, 72);
                    verdict_tb.TextAlign = HorizontalAlignment.Center;
                    verdict_tb.ForeColor = Color.Red;
                    if (actualQuestion.GoodAnswer == "A")
                        answer1_rbtn.BackColor = Color.Green;
                    if (actualQuestion.GoodAnswer == "B")
                        answer2_rbtn.BackColor = Color.Green;
                    if (actualQuestion.GoodAnswer == "C")
                        answer3_rbtn.BackColor = Color.Green;
                    if (actualQuestion.GoodAnswer == "D")
                        answer4_rbtn.BackColor = Color.Green;
                    if (answer == "A")
                        answer1_rbtn.BackColor = Color.Red;
                    if (answer == "B")
                        answer2_rbtn.BackColor = Color.Red;
                    if (answer == "C")
                        answer3_rbtn.BackColor = Color.Red;
                    if (answer == "D")
                        answer4_rbtn.BackColor = Color.Red;
                }

                verdict_tb.Visible = true;

                if (actualQuestion.Explanation != "")
                {
                    explain_picture.Visible = true;
                    explain_tb.Visible = true;
                    explain_tb.Text = actualQuestion.Explanation;
                }
            }

            //Lorsque l'on passe à la question suivante
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
                    question_tb.Text = question.QuestionText;
                    if (question.HasImage)
                    {
                        question_pic.Visible = true;
                        question_pic.BackgroundImage = question.Image;
                        question_tb.Location = new Point(173, 61);
                    }

                    else
                    {
                        question_pic.Visible = false;
                        question_tb.Location = new Point(173, 198);
                    }
                    answer1_rbtn.Text = question.Answers[0];
                    answer1_rbtn.Checked = false;
                    answer1_rbtn.BackColor = Color.FromArgb(224, 224, 224); ;
                    answer2_rbtn.Text = question.Answers[1];
                    answer2_rbtn.Checked = false;
                    answer2_rbtn.BackColor = Color.FromArgb(224, 224, 224); ;
                    answer3_rbtn.Text = question.Answers[2];
                    answer3_rbtn.Checked = false;
                    answer3_rbtn.BackColor = Color.FromArgb(224, 224, 224); ;
                    answer4_rbtn.Text = question.Answers[3];
                    answer4_rbtn.Checked = false;
                    answer4_rbtn.BackColor = Color.FromArgb(224, 224, 224); ;
                    verdict_tb.Visible = false;
                    question_tb.Visible = true;
                    explain_tb.Visible = false;
                    actualQuestion = question;
                    progressBar.Value += 1;
                    next = true;
                }
            }

            if (count == 42)
            {
                Resultat resultat = new Resultat();
                this.Hide();
                resultat.Show();
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



        private void progressBar_Click(object sender, EventArgs e)
        {
            progressBar.ForeColor = Color.DodgerBlue;
        }

        private void verdict_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
