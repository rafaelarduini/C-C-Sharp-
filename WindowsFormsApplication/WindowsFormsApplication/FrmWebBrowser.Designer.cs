namespace WindowsFormsApplication
{
    partial class FrmWebBrowser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnYouTube = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 41);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(766, 409);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.google.com.br", System.UriKind.Absolute);
            // 
            // btnYouTube
            // 
            this.btnYouTube.Location = new System.Drawing.Point(93, 12);
            this.btnYouTube.Name = "btnYouTube";
            this.btnYouTube.Size = new System.Drawing.Size(75, 23);
            this.btnYouTube.TabIndex = 1;
            this.btnYouTube.Text = "YouTube";
            this.btnYouTube.UseVisualStyleBackColor = true;
            this.btnYouTube.Click += new System.EventHandler(this.btnYouTube_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(174, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnFacebook
            // 
            this.btnFacebook.Location = new System.Drawing.Point(12, 12);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(75, 23);
            this.btnFacebook.TabIndex = 3;
            this.btnFacebook.Text = "Facebook";
            this.btnFacebook.UseVisualStyleBackColor = true;
            this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
            // 
            // FrmWebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFacebook);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnYouTube);
            this.Controls.Add(this.webBrowser1);
            this.Name = "FrmWebBrowser";
            this.Text = "FrmWebBrowser";
            this.Load += new System.EventHandler(this.FrmWebBrowser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnYouTube;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnFacebook;
    }
}