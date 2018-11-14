namespace Ex1_Questionnaire
{
    partial class Accueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.title_lb = new System.Windows.Forms.Label();
            this.begin_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_lb
            // 
            this.title_lb.AutoSize = true;
            this.title_lb.BackColor = System.Drawing.Color.Transparent;
            this.title_lb.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lb.ForeColor = System.Drawing.Color.White;
            this.title_lb.Location = new System.Drawing.Point(122, 187);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(482, 45);
            this.title_lb.TabIndex = 0;
            this.title_lb.Text = "Examen Terminal d\'IA";
            this.title_lb.Click += new System.EventHandler(this.title_lb_Click);
            // 
            // begin_btn
            // 
            this.begin_btn.BackColor = System.Drawing.Color.Lavender;
            this.begin_btn.Font = new System.Drawing.Font("Gadugi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.begin_btn.Location = new System.Drawing.Point(175, 343);
            this.begin_btn.Name = "begin_btn";
            this.begin_btn.Size = new System.Drawing.Size(302, 79);
            this.begin_btn.TabIndex = 1;
            this.begin_btn.Text = "Commencer";
            this.begin_btn.UseVisualStyleBackColor = false;
            this.begin_btn.Click += new System.EventHandler(this.begin_btn_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 667);
            this.Controls.Add(this.begin_btn);
            this.Controls.Add(this.title_lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.Button begin_btn;
    }
}