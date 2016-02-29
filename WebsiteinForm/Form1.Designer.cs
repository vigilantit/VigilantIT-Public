namespace WebsiteinForm
{
    partial class Form1
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
            this.wbPOC = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbPOC
            // 
            this.wbPOC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbPOC.Location = new System.Drawing.Point(0, 0);
            this.wbPOC.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbPOC.Name = "wbPOC";
            this.wbPOC.Size = new System.Drawing.Size(284, 261);
            this.wbPOC.TabIndex = 0;
            this.wbPOC.Url = new System.Uri("http://www.bing.com.au", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.wbPOC);
            this.Name = "Form1";
            this.Text = "POC WebForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbPOC;
    }
}

