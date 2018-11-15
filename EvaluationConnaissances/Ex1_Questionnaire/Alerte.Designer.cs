namespace Ex1_Questionnaire
{
    partial class Alerte
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
            this.alert1_lb = new System.Windows.Forms.Label();
            this.alert2_lb = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alert1_lb
            // 
            this.alert1_lb.AutoSize = true;
            this.alert1_lb.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert1_lb.Location = new System.Drawing.Point(33, 26);
            this.alert1_lb.Name = "alert1_lb";
            this.alert1_lb.Size = new System.Drawing.Size(286, 23);
            this.alert1_lb.TabIndex = 0;
            this.alert1_lb.Text = "Vous devez choisir une réponse. ";
            this.alert1_lb.Click += new System.EventHandler(this.label1_Click);
            // 
            // alert2_lb
            // 
            this.alert2_lb.AutoSize = true;
            this.alert2_lb.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alert2_lb.Location = new System.Drawing.Point(154, 62);
            this.alert2_lb.Name = "alert2_lb";
            this.alert2_lb.Size = new System.Drawing.Size(35, 10);
            this.alert2_lb.TabIndex = 1;
            this.alert2_lb.Text = "Courage.";
            this.alert2_lb.Click += new System.EventHandler(this.alert2_lb_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(131, 91);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 2;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // Alerte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 129);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.alert2_lb);
            this.Controls.Add(this.alert1_lb);
            this.Name = "Alerte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alerte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alert1_lb;
        private System.Windows.Forms.Label alert2_lb;
        private System.Windows.Forms.Button ok_btn;
    }
}