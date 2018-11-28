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
            this.next_btn = new System.Windows.Forms.Button();
            this.question_pic = new System.Windows.Forms.PictureBox();
            this.question_tb = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.verdict_tb = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.answer1_btn = new System.Windows.Forms.Button();
            this.answer2_btn = new System.Windows.Forms.Button();
            this.answer3_btn = new System.Windows.Forms.Button();
            this.answer4_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.question_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.next_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next_btn.BackgroundImage")));
            this.next_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.next_btn.Location = new System.Drawing.Point(763, 515);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(47, 45);
            this.next_btn.TabIndex = 5;
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Visible = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // question_pic
            // 
            this.question_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.question_pic.Location = new System.Drawing.Point(259, 136);
            this.question_pic.Margin = new System.Windows.Forms.Padding(2);
            this.question_pic.Name = "question_pic";
            this.question_pic.Size = new System.Drawing.Size(328, 158);
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
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.progressBar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.progressBar.Location = new System.Drawing.Point(122, 27);
            this.progressBar.Maximum = 20;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(619, 13);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 16;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
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
            // answer1_btn
            // 
            this.answer1_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer1_btn.Location = new System.Drawing.Point(153, 317);
            this.answer1_btn.Name = "answer1_btn";
            this.answer1_btn.Size = new System.Drawing.Size(527, 47);
            this.answer1_btn.TabIndex = 20;
            this.answer1_btn.Text = "answer1";
            this.answer1_btn.UseVisualStyleBackColor = true;
            this.answer1_btn.Click += new System.EventHandler(this.answer1_btn_Click);
            // 
            // answer2_btn
            // 
            this.answer2_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer2_btn.Location = new System.Drawing.Point(153, 382);
            this.answer2_btn.Name = "answer2_btn";
            this.answer2_btn.Size = new System.Drawing.Size(527, 47);
            this.answer2_btn.TabIndex = 21;
            this.answer2_btn.Text = "answer2";
            this.answer2_btn.UseVisualStyleBackColor = true;
            this.answer2_btn.Click += new System.EventHandler(this.answer2_btn_Click);
            // 
            // answer3_btn
            // 
            this.answer3_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer3_btn.Location = new System.Drawing.Point(153, 450);
            this.answer3_btn.Name = "answer3_btn";
            this.answer3_btn.Size = new System.Drawing.Size(527, 47);
            this.answer3_btn.TabIndex = 22;
            this.answer3_btn.Text = "answer3";
            this.answer3_btn.UseVisualStyleBackColor = true;
            this.answer3_btn.Click += new System.EventHandler(this.answer3_btn_Click);
            // 
            // answer4_btn
            // 
            this.answer4_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer4_btn.Location = new System.Drawing.Point(157, 513);
            this.answer4_btn.Name = "answer4_btn";
            this.answer4_btn.Size = new System.Drawing.Size(527, 47);
            this.answer4_btn.TabIndex = 23;
            this.answer4_btn.Text = "answer4";
            this.answer4_btn.UseVisualStyleBackColor = true;
            this.answer4_btn.Click += new System.EventHandler(this.answer4_btn_Click);
            // 
            // Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 570);
            this.Controls.Add(this.answer4_btn);
            this.Controls.Add(this.answer3_btn);
            this.Controls.Add(this.answer2_btn);
            this.Controls.Add(this.answer1_btn);
            this.Controls.Add(this.verdict_tb);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.question_tb);
            this.Controls.Add(this.question_pic);
            this.Controls.Add(this.next_btn);
            this.Name = "Questionnaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questionnaire";
            ((System.ComponentModel.ISupportInitialize)(this.question_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.PictureBox question_pic;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox verdict_tb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox question_tb;
        private System.Windows.Forms.Button answer1_btn;
        private System.Windows.Forms.Button answer2_btn;
        private System.Windows.Forms.Button answer3_btn;
        private System.Windows.Forms.Button answer4_btn;
    }
}

