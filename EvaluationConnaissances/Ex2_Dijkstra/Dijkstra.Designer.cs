namespace Ex2_Dijkstra
{
    partial class Dijkstra
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.graph_pb = new System.Windows.Forms.PictureBox();
            this.question_lb = new System.Windows.Forms.Label();
            this.fermes_tb = new System.Windows.Forms.TextBox();
            this.ouverts_tb = new System.Windows.Forms.TextBox();
            this.ouverts_lb = new System.Windows.Forms.Label();
            this.validate_btn = new System.Windows.Forms.Button();
            this.step_lb = new System.Windows.Forms.Label();
            this.fermes_lb = new System.Windows.Forms.Label();
            this.test_btn = new System.Windows.Forms.Button();
            this.test_lb = new System.Windows.Forms.Label();
            this.answersPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.graph_pb)).BeginInit();
            this.answersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // graph_pb
            // 
            this.graph_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph_pb.Location = new System.Drawing.Point(230, 56);
            this.graph_pb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graph_pb.Name = "graph_pb";
            this.graph_pb.Size = new System.Drawing.Size(328, 175);
            this.graph_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.graph_pb.TabIndex = 0;
            this.graph_pb.TabStop = false;
            this.graph_pb.Click += new System.EventHandler(this.graph_pb_Click);
            // 
            // question_lb
            // 
            this.question_lb.AutoSize = true;
            this.question_lb.Location = new System.Drawing.Point(228, 26);
            this.question_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.question_lb.Name = "question_lb";
            this.question_lb.Size = new System.Drawing.Size(310, 13);
            this.question_lb.TabIndex = 1;
            this.question_lb.Text = "Appliquez Dijkstra pour trouver le plus court chemin entre A et E.";
            // 
            // fermes_tb
            // 
            this.fermes_tb.Enabled = false;
            this.fermes_tb.Location = new System.Drawing.Point(136, 17);
            this.fermes_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fermes_tb.Name = "fermes_tb";
            this.fermes_tb.Size = new System.Drawing.Size(76, 20);
            this.fermes_tb.TabIndex = 2;
            // 
            // ouverts_tb
            // 
            this.ouverts_tb.Enabled = false;
            this.ouverts_tb.Location = new System.Drawing.Point(352, 20);
            this.ouverts_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ouverts_tb.Name = "ouverts_tb";
            this.ouverts_tb.Size = new System.Drawing.Size(76, 20);
            this.ouverts_tb.TabIndex = 3;
            this.ouverts_tb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ouverts_lb
            // 
            this.ouverts_lb.AutoSize = true;
            this.ouverts_lb.Location = new System.Drawing.Point(324, 20);
            this.ouverts_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ouverts_lb.Name = "ouverts_lb";
            this.ouverts_lb.Size = new System.Drawing.Size(24, 13);
            this.ouverts_lb.TabIndex = 5;
            this.ouverts_lb.Text = "O =";
            // 
            // validate_btn
            // 
            this.validate_btn.Location = new System.Drawing.Point(475, 12);
            this.validate_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.validate_btn.Name = "validate_btn";
            this.validate_btn.Size = new System.Drawing.Size(56, 34);
            this.validate_btn.TabIndex = 6;
            this.validate_btn.Text = "Valider l\'étape";
            this.validate_btn.UseVisualStyleBackColor = true;
            this.validate_btn.Click += new System.EventHandler(this.validate_btn_Click);
            // 
            // step_lb
            // 
            this.step_lb.AutoSize = true;
            this.step_lb.Location = new System.Drawing.Point(35, 20);
            this.step_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.step_lb.Name = "step_lb";
            this.step_lb.Size = new System.Drawing.Size(44, 13);
            this.step_lb.TabIndex = 7;
            this.step_lb.Text = "Étape 0";
            // 
            // fermes_lb
            // 
            this.fermes_lb.AutoSize = true;
            this.fermes_lb.Location = new System.Drawing.Point(110, 20);
            this.fermes_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fermes_lb.Name = "fermes_lb";
            this.fermes_lb.Size = new System.Drawing.Size(22, 13);
            this.fermes_lb.TabIndex = 8;
            this.fermes_lb.Text = "F =";
            // 
            // test_btn
            // 
            this.test_btn.Location = new System.Drawing.Point(51, 56);
            this.test_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(56, 19);
            this.test_btn.TabIndex = 9;
            this.test_btn.Text = "Test";
            this.test_btn.UseVisualStyleBackColor = true;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // test_lb
            // 
            this.test_lb.AutoSize = true;
            this.test_lb.Location = new System.Drawing.Point(51, 92);
            this.test_lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.test_lb.Name = "test_lb";
            this.test_lb.Size = new System.Drawing.Size(28, 13);
            this.test_lb.TabIndex = 10;
            this.test_lb.Text = "Test";
            this.test_lb.Click += new System.EventHandler(this.test_lb_Click);
            // 
            // answersPanel
            // 
            this.answersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answersPanel.Controls.Add(this.step_lb);
            this.answersPanel.Controls.Add(this.fermes_lb);
            this.answersPanel.Controls.Add(this.validate_btn);
            this.answersPanel.Controls.Add(this.fermes_tb);
            this.answersPanel.Controls.Add(this.ouverts_tb);
            this.answersPanel.Controls.Add(this.ouverts_lb);
            this.answersPanel.Location = new System.Drawing.Point(106, 236);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(592, 331);
            this.answersPanel.TabIndex = 11;
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 660);
            this.Controls.Add(this.test_lb);
            this.Controls.Add(this.test_btn);
            this.Controls.Add(this.question_lb);
            this.Controls.Add(this.graph_pb);
            this.Controls.Add(this.answersPanel);
            this.Name = "Dijkstra";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graph_pb)).EndInit();
            this.answersPanel.ResumeLayout(false);
            this.answersPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox graph_pb;
        private System.Windows.Forms.Label question_lb;
        private System.Windows.Forms.TextBox fermes_tb;
        private System.Windows.Forms.TextBox ouverts_tb;
        private System.Windows.Forms.Label ouverts_lb;
        private System.Windows.Forms.Button validate_btn;
        private System.Windows.Forms.Label step_lb;
        private System.Windows.Forms.Label fermes_lb;
        private System.Windows.Forms.Button test_btn;
        private System.Windows.Forms.Label test_lb;
        private System.Windows.Forms.Panel answersPanel;
    }
}

