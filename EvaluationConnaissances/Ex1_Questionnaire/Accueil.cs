﻿using System;
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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void title_lb_Click(object sender, EventArgs e)
        {

        }

        private void begin_btn_Click(object sender, EventArgs e)
        {
            Questionnaire question = new Questionnaire();
            this.Hide();
            question.Show();
        }
    }
}
