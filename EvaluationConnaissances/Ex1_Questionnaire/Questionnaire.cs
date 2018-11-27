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
        public int score = 0;
        public int scoreMaxPossible = 0;
        string answer;

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

        private void next_btn_Click(object sender, EventArgs e)
        {

            int nextQuest;
            Console.WriteLine("Pts Questions = "+actualQuestion.Points+"\nScore total : "+ score);

            //Lorsque l'on valide la réponse
            if (count % 2 == 0)
            {
                next_btn.Visible = true;
                //Analyse réponse donnée VS réponse attendue
                verdict_tb.Visible = true;
                question_pic.Visible = false;
                scoreMaxPossible += actualQuestion.Points;
                question_tb.Location = new Point(179, 73);
                if (answer == Convert.ToString(actualQuestion.GoodAnswer))
                {
                    verdict_tb.Text = "BRAVO !";
                    verdict_tb.TextAlign = HorizontalAlignment.Center;
                    verdict_tb.ForeColor = Color.Green;
                    score+=actualQuestion.Points;
                    if (actualQuestion.GoodAnswer == "A")
                        answer1_btn.BackColor = Color.Green;
                    if (actualQuestion.GoodAnswer == "B")
                        answer2_btn.BackColor = Color.Green;
                    if (actualQuestion.GoodAnswer == "C")
                        answer3_btn.BackColor = Color.Green;
                    if (actualQuestion.GoodAnswer == "D")
                        answer4_btn.BackColor = Color.Green;
                }

                if (answer != Convert.ToString(actualQuestion.GoodAnswer))
                {
                    verdict_tb.Text = "RATÉ !";
                    question_tb.Location = new Point(179, 73);
                    verdict_tb.TextAlign = HorizontalAlignment.Center;
                    verdict_tb.ForeColor = Color.Red;
                    if (actualQuestion.GoodAnswer == "A")
                        answer1_btn.BackColor = Color.Green;
                    if (actualQuestion.GoodAnswer == "B")
                        answer2_btn.BackColor = Color.Green;
                    if (actualQuestion.GoodAnswer == "C")
                        answer3_btn.BackColor = Color.Green;
                    if (actualQuestion.GoodAnswer == "D")
                        answer4_btn.BackColor = Color.Green;
                    if (answer == "A")
                        answer1_btn.BackColor = Color.Red;
                    if (answer == "B")
                        answer2_btn.BackColor = Color.Red;
                    if (answer == "C")
                        answer3_btn.BackColor = Color.Red;
                    if (answer == "D")
                        answer4_btn.BackColor = Color.Red;
                }
                verdict_tb.Visible = true;
            }

            //Lorsque l'on passe à la question suivante
            else
            {
                next_btn.Visible = false;
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
            while (next == false)
            {
                if (count == 39)
                {
                    Resultat resultat = new Resultat(this);
                    this.Hide();
                    resultat.Show();
                    next = true;
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

                        verdict_tb.Visible = false;
                        question_tb.Visible = true;
                        actualQuestion = question;
                        progressBar.Value += 1;
                        next = true;

                    if (Convert.ToInt32(actualQuestion.Id) != 2)
                    {
                        answer1_btn.Text = question.Answers[0];
                        answer1_btn.BackColor = Color.FromArgb(224, 224, 224);
                        answer2_btn.Text = question.Answers[1];
                        answer2_btn.BackColor = Color.FromArgb(224, 224, 224);
                        answer3_btn.Text = question.Answers[2];
                        answer3_btn.BackColor = Color.FromArgb(224, 224, 224);
                        answer4_btn.Text = question.Answers[3];
                        answer4_btn.BackColor = Color.FromArgb(224, 224, 224);
                        answer1_picture.Visible = false;
                        answer2_picture.Visible = false;
                        answer3_picture.Visible = false;
                        answer4_picture.Visible = false;
                        next_btn.Location = new Point(763, 515);
                        this.Size = new Size(838, 656);
                    }
                    else
                    {
                        answer1_btn.Visible = false;
                        answer2_btn.Visible = false;
                        answer3_btn.Visible = false;
                        answer4_btn.Visible = false;

                        this.Size = new Size(838, 825);

                        answer1_picture.Visible = true;
                        answer2_picture.Visible = true;
                        answer3_picture.Visible = true;
                        answer4_picture.Visible = true;

                        next_btn.Location = new Point(763, 726);
                    }

                }
            }

        }

        //Générer liste contenant toutes les questions
        public void initializeQuestions()
        {
            for (int i=1; i<21; i+=1)
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

        private void answer1_btn_Click(object sender, EventArgs e)
        {
            answer = "A";
            next_btn_Click(sender, e);
        }

        private void answer2_btn_Click(object sender, EventArgs e)
        {
            answer = "B";
            next_btn_Click(sender, e);
        }

        private void answer3_btn_Click(object sender, EventArgs e)
        {
            answer = "C";
            next_btn_Click(sender, e);
        }

        private void answer4_btn_Click(object sender, EventArgs e)
        {
            answer = "D";
            next_btn_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void answer1_picture_Click(object sender, EventArgs e)
        {
            answer = "A";
            next_btn_Click(sender, e);
        }
        private void answer2_picture_Click(object sender, EventArgs e)
        {
            answer = "B";
            next_btn_Click(sender, e);
        }
        private void answer3_picture_Click(object sender, EventArgs e)
        {
            answer = "C";
            next_btn_Click(sender, e);
        }
        private void answer4_picture_Click(object sender, EventArgs e)
        {
            answer = "D";
            next_btn_Click(sender, e);
        }
    }
}
