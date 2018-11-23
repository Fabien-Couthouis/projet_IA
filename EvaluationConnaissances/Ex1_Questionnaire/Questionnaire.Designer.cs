namespace Ex1_Questionnaire
{
    partial class Questionnaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questionnaire));
            this.answer1_rbtn = new System.Windows.Forms.RadioButton();
            this.answer2_rbtn = new System.Windows.Forms.RadioButton();
            this.answer3_rbtn = new System.Windows.Forms.RadioButton();
            this.answer4_rbtn = new System.Windows.Forms.RadioButton();
            this.validate_btn = new System.Windows.Forms.Button();
            this.question_pic = new System.Windows.Forms.PictureBox();
            this.question_tb = new System.Windows.Forms.TextBox();
            this.answerA_lb = new System.Windows.Forms.Label();
            this.answerB_lb = new System.Windows.Forms.Label();
            this.answerC_lb = new System.Windows.Forms.Label();
            this.answerD_kb = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.explain_tb = new System.Windows.Forms.TextBox();
            this.explain_picture = new System.Windows.Forms.PictureBox();
            this.verdict_tb = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.question_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explain_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // answer1_rbtn
            // 
            this.answer1_rbtn.AutoSize = true;
            this.answer1_rbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.answer1_rbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1_rbtn.Location = new System.Drawing.Point(205, 326);
            this.answer1_rbtn.Name = "answer1_rbtn";
            this.answer1_rbtn.Size = new System.Drawing.Size(79, 20);
            this.answer1_rbtn.TabIndex = 1;
            this.answer1_rbtn.TabStop = true;
            this.answer1_rbtn.Text = "reponse1";
            this.answer1_rbtn.UseVisualStyleBackColor = false;
            this.answer1_rbtn.CheckedChanged += new System.EventHandler(this.answer1_rbtn_CheckedChanged);
            // 
            // answer2_rbtn
            // 
            this.answer2_rbtn.AutoSize = true;
            this.answer2_rbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer2_rbtn.Location = new System.Drawing.Point(205, 381);
            this.answer2_rbtn.Name = "answer2_rbtn";
            this.answer2_rbtn.Size = new System.Drawing.Size(79, 20);
            this.answer2_rbtn.TabIndex = 2;
            this.answer2_rbtn.TabStop = true;
            this.answer2_rbtn.Text = "reponse2";
            this.answer2_rbtn.UseVisualStyleBackColor = true;
            // 
            // answer3_rbtn
            // 
            this.answer3_rbtn.AutoSize = true;
            this.answer3_rbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer3_rbtn.Location = new System.Drawing.Point(205, 432);
            this.answer3_rbtn.Name = "answer3_rbtn";
            this.answer3_rbtn.Size = new System.Drawing.Size(79, 20);
            this.answer3_rbtn.TabIndex = 3;
            this.answer3_rbtn.TabStop = true;
            this.answer3_rbtn.Text = "reponse3";
            this.answer3_rbtn.UseVisualStyleBackColor = true;
            // 
            // answer4_rbtn
            // 
            this.answer4_rbtn.AutoSize = true;
            this.answer4_rbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer4_rbtn.Location = new System.Drawing.Point(205, 488);
            this.answer4_rbtn.Name = "answer4_rbtn";
            this.answer4_rbtn.Size = new System.Drawing.Size(79, 20);
            this.answer4_rbtn.TabIndex = 4;
            this.answer4_rbtn.TabStop = true;
            this.answer4_rbtn.Text = "reponse4";
            this.answer4_rbtn.UseVisualStyleBackColor = true;
            // 
            // validate_btn
            // 
            this.validate_btn.Location = new System.Drawing.Point(681, 549);
            this.validate_btn.Name = "validate_btn";
            this.validate_btn.Size = new System.Drawing.Size(75, 23);
            this.validate_btn.TabIndex = 5;
            this.validate_btn.Text = "Valider";
            this.validate_btn.UseVisualStyleBackColor = true;
            this.validate_btn.Click += new System.EventHandler(this.validate_btn_Click);
            // 
            // question_pic
            // 
            this.question_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.question_pic.Location = new System.Drawing.Point(259, 147);
            this.question_pic.Margin = new System.Windows.Forms.Padding(2);
            this.question_pic.Name = "question_pic";
            this.question_pic.Size = new System.Drawing.Size(328, 147);
            this.question_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.question_pic.TabIndex = 9;
            this.question_pic.TabStop = false;
            this.question_pic.Visible = false;
            // 
            // question_tb
            // 
            this.question_tb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.question_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.question_tb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.question_tb.Location = new System.Drawing.Point(173, 79);
            this.question_tb.Multiline = true;
            this.question_tb.Name = "question_tb";
            this.question_tb.ReadOnly = true;
            this.question_tb.Size = new System.Drawing.Size(511, 63);
            this.question_tb.TabIndex = 10;
            this.question_tb.Text = "Question";
            // 
            // answerA_lb
            // 
            this.answerA_lb.AutoSize = true;
            this.answerA_lb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerA_lb.Location = new System.Drawing.Point(185, 328);
            this.answerA_lb.Name = "answerA_lb";
            this.answerA_lb.Size = new System.Drawing.Size(16, 16);
            this.answerA_lb.TabIndex = 12;
            this.answerA_lb.Text = "A";
            // 
            // answerB_lb
            // 
            this.answerB_lb.AutoSize = true;
            this.answerB_lb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerB_lb.Location = new System.Drawing.Point(185, 381);
            this.answerB_lb.Name = "answerB_lb";
            this.answerB_lb.Size = new System.Drawing.Size(15, 16);
            this.answerB_lb.TabIndex = 13;
            this.answerB_lb.Text = "B";
            // 
            // answerC_lb
            // 
            this.answerC_lb.AutoSize = true;
            this.answerC_lb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerC_lb.Location = new System.Drawing.Point(185, 432);
            this.answerC_lb.Name = "answerC_lb";
            this.answerC_lb.Size = new System.Drawing.Size(16, 16);
            this.answerC_lb.TabIndex = 14;
            this.answerC_lb.Text = "C";
            // 
            // answerD_kb
            // 
            this.answerD_kb.AutoSize = true;
            this.answerD_kb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerD_kb.Location = new System.Drawing.Point(185, 490);
            this.answerD_kb.Name = "answerD_kb";
            this.answerD_kb.Size = new System.Drawing.Size(16, 16);
            this.answerD_kb.TabIndex = 15;
            this.answerD_kb.Text = "D";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressBar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.progressBar.Location = new System.Drawing.Point(122, 27);
            this.progressBar.Maximum = 21;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(619, 13);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 16;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // explain_tb
            // 
            this.explain_tb.BackColor = System.Drawing.Color.White;
            this.explain_tb.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explain_tb.Location = new System.Drawing.Point(157, 225);
            this.explain_tb.Multiline = true;
            this.explain_tb.Name = "explain_tb";
            this.explain_tb.ReadOnly = true;
            this.explain_tb.Size = new System.Drawing.Size(541, 85);
            this.explain_tb.TabIndex = 17;
            this.explain_tb.Text = "Explications";
            this.explain_tb.Visible = false;
            // 
            // explain_picture
            // 
            this.explain_picture.Image = ((System.Drawing.Image)(resources.GetObject("explain_picture.Image")));
            this.explain_picture.Location = new System.Drawing.Point(98, 246);
            this.explain_picture.Name = "explain_picture";
            this.explain_picture.Size = new System.Drawing.Size(53, 48);
            this.explain_picture.TabIndex = 18;
            this.explain_picture.TabStop = false;
            this.explain_picture.Visible = false;
            // 
            // verdict_tb
            // 
            this.verdict_tb.BackColor = System.Drawing.SystemColors.ControlLight;
            this.verdict_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.verdict_tb.Font = new System.Drawing.Font("Britannic Bold", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verdict_tb.Location = new System.Drawing.Point(188, 161);
            this.verdict_tb.Multiline = true;
            this.verdict_tb.Name = "verdict_tb";
            this.verdict_tb.ReadOnly = true;
            this.verdict_tb.Size = new System.Drawing.Size(479, 110);
            this.verdict_tb.TabIndex = 19;
            this.verdict_tb.Text = "VERDICT";
            this.verdict_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verdict_tb.TextChanged += new System.EventHandler(this.verdict_tb_TextChanged);
            // 
            // Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 593);
            this.Controls.Add(this.verdict_tb);
            this.Controls.Add(this.explain_picture);
            this.Controls.Add(this.explain_tb);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.answerD_kb);
            this.Controls.Add(this.answerC_lb);
            this.Controls.Add(this.answerB_lb);
            this.Controls.Add(this.answerA_lb);
            this.Controls.Add(this.question_tb);
            this.Controls.Add(this.question_pic);
            this.Controls.Add(this.validate_btn);
            this.Controls.Add(this.answer4_rbtn);
            this.Controls.Add(this.answer3_rbtn);
            this.Controls.Add(this.answer2_rbtn);
            this.Controls.Add(this.answer1_rbtn);
            this.Name = "Questionnaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questionnaire";
            ((System.ComponentModel.ISupportInitialize)(this.question_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explain_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton answer1_rbtn;
        private System.Windows.Forms.RadioButton answer2_rbtn;
        private System.Windows.Forms.RadioButton answer3_rbtn;
        private System.Windows.Forms.RadioButton answer4_rbtn;
        private System.Windows.Forms.Button validate_btn;
        private System.Windows.Forms.PictureBox question_pic;
        private System.Windows.Forms.Label answerA_lb;
        private System.Windows.Forms.Label answerB_lb;
        private System.Windows.Forms.Label answerC_lb;
        private System.Windows.Forms.Label answerD_kb;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox explain_tb;
        private System.Windows.Forms.PictureBox explain_picture;
        private System.Windows.Forms.TextBox verdict_tb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox question_tb;
    }
}

