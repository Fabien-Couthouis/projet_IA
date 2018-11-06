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
        Question actualQuestion;
        int count = 0;
        public Questionnaire()
        {
            InitializeComponent();
            actualize(0);
        }

        private void answer_tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void validate_btn_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                question_tb.Text = actualQuestion.GoodAnswer;
                validate_btn.Text = "Suivant";
            }
            else
            {
                validate_btn.Text = "Valider";
                actualize(actualQuestion.Id);
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
        private void actualize(int id_actual)
        {
            Question question = new Question(id_actual + 1);
            questionNb_lb.Text = Convert.ToString(question.Id) + "/20";
            question_tb.Text = question.QuestionText;
            if (question.HasImage)
            {
                pictureQuestion.Visible = true;
                pictureQuestion.BackgroundImage = question.Image;
            }
            answer1_rbtn.Text = question.Answers[0];
            answer2_rbtn.Text = question.Answers[1];
            answer3_rbtn.Text = question.Answers[2];
            answer4_rbtn.Text = question.Answers[3];

            actualQuestion = question;
        }
    }
}
