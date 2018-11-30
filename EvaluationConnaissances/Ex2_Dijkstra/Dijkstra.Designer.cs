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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nœud0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nœud6");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nœud7");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nœud1", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nœud3");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nœud4");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nœud2", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nœud5");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nœud9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Nœud11");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Nœud10", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Nœud8", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode11});
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.graph_pb = new System.Windows.Forms.PictureBox();
            this.question_lb = new System.Windows.Forms.Label();
            this.fermes_tb = new System.Windows.Forms.TextBox();
            this.ouverts_tb = new System.Windows.Forms.TextBox();
            this.ouverts_lb = new System.Windows.Forms.Label();
            this.validate_btn = new System.Windows.Forms.Button();
            this.step_lb = new System.Windows.Forms.Label();
            this.fermes_lb = new System.Windows.Forms.Label();
            this.answersPanel = new System.Windows.Forms.Panel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.graph_pb.Location = new System.Drawing.Point(307, 69);
            this.graph_pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graph_pb.Name = "graph_pb";
            this.graph_pb.Size = new System.Drawing.Size(437, 215);
            this.graph_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.graph_pb.TabIndex = 0;
            this.graph_pb.TabStop = false;
            // 
            // question_lb
            // 
            this.question_lb.Location = new System.Drawing.Point(304, 14);
            this.question_lb.Name = "question_lb";
            this.question_lb.Size = new System.Drawing.Size(440, 52);
            this.question_lb.TabIndex = 1;
            this.question_lb.Text = "Appliquez Dijkstra pour trouver le plus court chemin entre ";
            // 
            // fermes_tb
            // 
            this.fermes_tb.Enabled = false;
            this.fermes_tb.Location = new System.Drawing.Point(193, 21);
            this.fermes_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fermes_tb.Name = "fermes_tb";
            this.fermes_tb.Size = new System.Drawing.Size(100, 22);
            this.fermes_tb.TabIndex = 2;
            // 
            // ouverts_tb
            // 
            this.ouverts_tb.Enabled = false;
            this.ouverts_tb.Location = new System.Drawing.Point(481, 25);
            this.ouverts_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ouverts_tb.Name = "ouverts_tb";
            this.ouverts_tb.Size = new System.Drawing.Size(100, 22);
            this.ouverts_tb.TabIndex = 3;
            // 
            // ouverts_lb
            // 
            this.ouverts_lb.AutoSize = true;
            this.ouverts_lb.Location = new System.Drawing.Point(444, 25);
            this.ouverts_lb.Name = "ouverts_lb";
            this.ouverts_lb.Size = new System.Drawing.Size(31, 17);
            this.ouverts_lb.TabIndex = 5;
            this.ouverts_lb.Text = "O =";
            // 
            // validate_btn
            // 
            this.validate_btn.Location = new System.Drawing.Point(937, 296);
            this.validate_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.validate_btn.Name = "validate_btn";
            this.validate_btn.Size = new System.Drawing.Size(75, 42);
            this.validate_btn.TabIndex = 6;
            this.validate_btn.Text = "Valider l\'étape";
            this.validate_btn.UseVisualStyleBackColor = true;
            this.validate_btn.Click += new System.EventHandler(this.validate_btn_Click);
            // 
            // step_lb
            // 
            this.step_lb.AutoSize = true;
            this.step_lb.Location = new System.Drawing.Point(59, 25);
            this.step_lb.Name = "step_lb";
            this.step_lb.Size = new System.Drawing.Size(57, 17);
            this.step_lb.TabIndex = 7;
            this.step_lb.Text = "Étape 0";
            // 
            // fermes_lb
            // 
            this.fermes_lb.AutoSize = true;
            this.fermes_lb.Location = new System.Drawing.Point(159, 25);
            this.fermes_lb.Name = "fermes_lb";
            this.fermes_lb.Size = new System.Drawing.Size(28, 17);
            this.fermes_lb.TabIndex = 8;
            this.fermes_lb.Text = "F =";
            // 
            // answersPanel
            // 
            this.answersPanel.AutoScroll = true;
            this.answersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answersPanel.Controls.Add(this.step_lb);
            this.answersPanel.Controls.Add(this.fermes_lb);
            this.answersPanel.Controls.Add(this.fermes_tb);
            this.answersPanel.Controls.Add(this.ouverts_tb);
            this.answersPanel.Controls.Add(this.ouverts_lb);
            this.answersPanel.Location = new System.Drawing.Point(141, 296);
            this.answersPanel.Margin = new System.Windows.Forms.Padding(4);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(789, 407);
            this.answersPanel.TabIndex = 11;
            // 
            // treeView
            // 
            this.treeView.LabelEdit = true;
            this.treeView.Location = new System.Drawing.Point(207, 296);
            this.treeView.Name = "treeView";
            treeNode1.Name = "Nœud0";
            treeNode1.Text = "Nœud0";
            treeNode2.Name = "Nœud6";
            treeNode2.Text = "Nœud6";
            treeNode3.Name = "Nœud7";
            treeNode3.Text = "Nœud7";
            treeNode4.Name = "Nœud1";
            treeNode4.Text = "Nœud1";
            treeNode5.Name = "Nœud3";
            treeNode5.Text = "Nœud3";
            treeNode6.Name = "Nœud4";
            treeNode6.Text = "Nœud4";
            treeNode7.Name = "Nœud2";
            treeNode7.Text = "Nœud2";
            treeNode8.Name = "Nœud5";
            treeNode8.Text = "Nœud5";
            treeNode9.Name = "Nœud9";
            treeNode9.Text = "Nœud9";
            treeNode10.Name = "Nœud11";
            treeNode10.Text = "Nœud11";
            treeNode11.Name = "Nœud10";
            treeNode11.Text = "Nœud10";
            treeNode12.Name = "Nœud8";
            treeNode12.Text = "Nœud8";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode7,
            treeNode8,
            treeNode12});
            this.treeView.Size = new System.Drawing.Size(724, 364);
            this.treeView.TabIndex = 14;
            this.treeView.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 812);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.validate_btn);
            this.Controls.Add(this.question_lb);
            this.Controls.Add(this.graph_pb);
            this.Controls.Add(this.answersPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dijkstra";
            this.Text = "Exercice 2 : Dijkstra";
            ((System.ComponentModel.ISupportInitialize)(this.graph_pb)).EndInit();
            this.answersPanel.ResumeLayout(false);
            this.answersPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel answersPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TreeView treeView;
    }
}

