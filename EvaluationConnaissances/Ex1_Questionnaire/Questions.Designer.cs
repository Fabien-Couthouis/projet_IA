namespace Ex1_Questionnaire
{
    partial class questionNumber_lb
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.question_tb = new System.Windows.Forms.TextBox();
            this.answer1_rbtn = new System.Windows.Forms.RadioButton();
            this.answer2_rbtn = new System.Windows.Forms.RadioButton();
            this.answer3_rbtn = new System.Windows.Forms.RadioButton();
            this.answer4_rbtn = new System.Windows.Forms.RadioButton();
            this.validate_btn = new System.Windows.Forms.Button();
            this.questionNb_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // question_tb
            // 
            this.question_tb.Location = new System.Drawing.Point(193, 86);
            this.question_tb.Multiline = true;
            this.question_tb.Name = "question_tb";
            this.question_tb.Size = new System.Drawing.Size(465, 197);
            this.question_tb.TabIndex = 0;
            this.question_tb.Text = "LA QUESTION";
            this.question_tb.TextChanged += new System.EventHandler(this.answer_tb_TextChanged);
            // 
            // answer1_rbtn
            // 
            this.answer1_rbtn.AutoSize = true;
            this.answer1_rbtn.Location = new System.Drawing.Point(135, 361);
            this.answer1_rbtn.Name = "answer1_rbtn";
            this.answer1_rbtn.Size = new System.Drawing.Size(69, 17);
            this.answer1_rbtn.TabIndex = 1;
            this.answer1_rbtn.TabStop = true;
            this.answer1_rbtn.Text = "reponse1";
            this.answer1_rbtn.UseVisualStyleBackColor = true;
            this.answer1_rbtn.CheckedChanged += new System.EventHandler(this.answer1_rbtn_CheckedChanged);
            // 
            // answer2_rbtn
            // 
            this.answer2_rbtn.AutoSize = true;
            this.answer2_rbtn.Location = new System.Drawing.Point(135, 416);
            this.answer2_rbtn.Name = "answer2_rbtn";
            this.answer2_rbtn.Size = new System.Drawing.Size(69, 17);
            this.answer2_rbtn.TabIndex = 2;
            this.answer2_rbtn.TabStop = true;
            this.answer2_rbtn.Text = "reponse2";
            this.answer2_rbtn.UseVisualStyleBackColor = true;
            // 
            // answer3_rbtn
            // 
            this.answer3_rbtn.AutoSize = true;
            this.answer3_rbtn.Location = new System.Drawing.Point(135, 467);
            this.answer3_rbtn.Name = "answer3_rbtn";
            this.answer3_rbtn.Size = new System.Drawing.Size(69, 17);
            this.answer3_rbtn.TabIndex = 3;
            this.answer3_rbtn.TabStop = true;
            this.answer3_rbtn.Text = "reponse3";
            this.answer3_rbtn.UseVisualStyleBackColor = true;
            // 
            // answer4_rbtn
            // 
            this.answer4_rbtn.AutoSize = true;
            this.answer4_rbtn.Location = new System.Drawing.Point(135, 523);
            this.answer4_rbtn.Name = "answer4_rbtn";
            this.answer4_rbtn.Size = new System.Drawing.Size(69, 17);
            this.answer4_rbtn.TabIndex = 4;
            this.answer4_rbtn.TabStop = true;
            this.answer4_rbtn.Text = "reponse4";
            this.answer4_rbtn.UseVisualStyleBackColor = true;
            // 
            // validate_btn
            // 
            this.validate_btn.Location = new System.Drawing.Point(712, 575);
            this.validate_btn.Name = "validate_btn";
            this.validate_btn.Size = new System.Drawing.Size(75, 23);
            this.validate_btn.TabIndex = 5;
            this.validate_btn.Text = "Valider";
            this.validate_btn.UseVisualStyleBackColor = true;
            this.validate_btn.Click += new System.EventHandler(this.validate_btn_Click);
            // 
            // questionNb_lb
            // 
            this.questionNb_lb.AutoSize = true;
            this.questionNb_lb.Location = new System.Drawing.Point(23, 13);
            this.questionNb_lb.Name = "questionNb_lb";
            this.questionNb_lb.Size = new System.Drawing.Size(29, 13);
            this.questionNb_lb.TabIndex = 6;
            this.questionNb_lb.Text = "x/20";
            // 
            // questionNumber_lb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 639);
            this.Controls.Add(this.questionNb_lb);
            this.Controls.Add(this.validate_btn);
            this.Controls.Add(this.answer4_rbtn);
            this.Controls.Add(this.answer3_rbtn);
            this.Controls.Add(this.answer2_rbtn);
            this.Controls.Add(this.answer1_rbtn);
            this.Controls.Add(this.question_tb);
            this.Name = "questionNumber_lb";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox question_tb;
        private System.Windows.Forms.RadioButton answer1_rbtn;
        private System.Windows.Forms.RadioButton answer2_rbtn;
        private System.Windows.Forms.RadioButton answer3_rbtn;
        private System.Windows.Forms.RadioButton answer4_rbtn;
        private System.Windows.Forms.Button validate_btn;
        private System.Windows.Forms.Label questionNb_lb;
    }
}

