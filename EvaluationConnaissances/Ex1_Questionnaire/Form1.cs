using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ex1_Questionnaire
{
    public partial class questionNumber_lb : Form
    {
        public questionNumber_lb()
        {
            InitializeComponent();
        }

        private void answer_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void validate_btn_Click(object sender, EventArgs e)
        {
            Question question = new Question(3);
            question_tb.Text = question.GoodAnswer;


        }
    }
}
