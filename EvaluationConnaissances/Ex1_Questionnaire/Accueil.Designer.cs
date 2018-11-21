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
            this.begin2_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_lb
            // 
            this.title_lb.AutoSize = true;
            this.title_lb.BackColor = System.Drawing.Color.Transparent;
            this.title_lb.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lb.ForeColor = System.Drawing.Color.White;
            this.title_lb.Location = new System.Drawing.Point(163, 230);
            this.title_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_lb.Name = "title_lb";
            this.title_lb.Size = new System.Drawing.Size(608, 57);
            this.title_lb.TabIndex = 0;
            this.title_lb.Text = "Examen Terminal d\'IA";
            this.title_lb.Click += new System.EventHandler(this.title_lb_Click);
            // 
            // begin_btn
            // 
            this.begin_btn.BackColor = System.Drawing.Color.Lavender;
            this.begin_btn.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.begin_btn.Location = new System.Drawing.Point(233, 422);
            this.begin_btn.Margin = new System.Windows.Forms.Padding(4);
            this.begin_btn.Name = "begin_btn";
            this.begin_btn.Size = new System.Drawing.Size(403, 97);
            this.begin_btn.TabIndex = 1;
            this.begin_btn.Text = "Partie 1 : Questionnaire";
            this.begin_btn.UseVisualStyleBackColor = false;
            this.begin_btn.Click += new System.EventHandler(this.begin_btn_Click);
            // 
            // begin2_btn
            // 
            this.begin2_btn.BackColor = System.Drawing.Color.Lavender;
            this.begin2_btn.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.begin2_btn.Location = new System.Drawing.Point(233, 573);
            this.begin2_btn.Margin = new System.Windows.Forms.Padding(4);
            this.begin2_btn.Name = "begin2_btn";
            this.begin2_btn.Size = new System.Drawing.Size(403, 97);
            this.begin2_btn.TabIndex = 2;
            this.begin2_btn.Text = "Partie 2 : Dijkstra";
            this.begin2_btn.UseVisualStyleBackColor = false;
            this.begin2_btn.Click += new System.EventHandler(this.begin2_btn_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1471, 821);
            this.Controls.Add(this.begin2_btn);
            this.Controls.Add(this.begin_btn);
            this.Controls.Add(this.title_lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_lb;
        private System.Windows.Forms.Button begin_btn;
        private System.Windows.Forms.Button begin2_btn;
    }
}