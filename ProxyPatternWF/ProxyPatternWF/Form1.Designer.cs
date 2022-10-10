namespace ProxyPatternWF
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbSub = new System.Windows.Forms.ComboBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yêu cầu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSub
            // 
            this.cbSub.FormattingEnabled = true;
            this.cbSub.Items.AddRange(new object[] {
            "Toán",
            "Văn"});
            this.cbSub.Location = new System.Drawing.Point(129, 122);
            this.cbSub.Name = "cbSub";
            this.cbSub.Size = new System.Drawing.Size(202, 24);
            this.cbSub.TabIndex = 1;
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(129, 216);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(460, 137);
            this.rtbContent.TabIndex = 2;
            this.rtbContent.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.cbSub);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Proxy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbSub;
        private System.Windows.Forms.RichTextBox rtbContent;
    }
}

