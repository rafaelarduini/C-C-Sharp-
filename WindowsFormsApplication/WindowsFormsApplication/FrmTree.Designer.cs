namespace WindowsFormsApplication
{
    partial class FrmTree
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
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Nó4");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Nó3", new System.Windows.Forms.TreeNode[] {
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Nó5");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Nó2", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Nó6");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Nó0", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Nó7");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Nó9");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Nó8", new System.Windows.Forms.TreeNode[] {
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Nó1", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode29});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode21.Name = "Nó4";
            treeNode21.Text = "Nó4";
            treeNode22.Name = "Nó3";
            treeNode22.Text = "Nó3";
            treeNode23.Name = "Nó5";
            treeNode23.Text = "Nó5";
            treeNode24.Name = "Nó2";
            treeNode24.Text = "Nó2";
            treeNode25.Name = "Nó6";
            treeNode25.Text = "Nó6";
            treeNode26.Name = "Nó0";
            treeNode26.Text = "Nó0";
            treeNode27.Name = "Nó7";
            treeNode27.Text = "Nó7";
            treeNode28.Name = "Nó9";
            treeNode28.Text = "Nó9";
            treeNode29.Name = "Nó8";
            treeNode29.Text = "Nó8";
            treeNode30.Name = "Nó1";
            treeNode30.Text = "Nó1";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode30});
            this.treeView1.Size = new System.Drawing.Size(559, 387);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "checados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "FrmTree";
            this.Text = "FrmTree";
            this.Load += new System.EventHandler(this.FrmTree_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
    }
}