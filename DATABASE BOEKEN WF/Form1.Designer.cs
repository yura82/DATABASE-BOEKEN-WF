namespace DATABASE_BOEKEN_WF
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
            this.lbBoeken = new System.Windows.Forms.ListBox();
            this.lbMyBook = new System.Windows.Forms.Label();
            this.btAddBoek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBoeken
            // 
            this.lbBoeken.FormattingEnabled = true;
            this.lbBoeken.ItemHeight = 16;
            this.lbBoeken.Location = new System.Drawing.Point(12, 16);
            this.lbBoeken.Name = "lbBoeken";
            this.lbBoeken.Size = new System.Drawing.Size(183, 212);
            this.lbBoeken.TabIndex = 0;
            this.lbBoeken.SelectedIndexChanged += new System.EventHandler(this.lbBoeken_SelectedIndexChanged);
            // 
            // lbMyBook
            // 
            this.lbMyBook.AutoSize = true;
            this.lbMyBook.Location = new System.Drawing.Point(94, 262);
            this.lbMyBook.Name = "lbMyBook";
            this.lbMyBook.Size = new System.Drawing.Size(46, 17);
            this.lbMyBook.TabIndex = 1;
            this.lbMyBook.Text = "label2";
            // 
            // btAddBoek
            // 
            this.btAddBoek.Location = new System.Drawing.Point(380, 116);
            this.btAddBoek.Name = "btAddBoek";
            this.btAddBoek.Size = new System.Drawing.Size(143, 23);
            this.btAddBoek.TabIndex = 2;
            this.btAddBoek.Text = "ADD Boek";
            this.btAddBoek.UseVisualStyleBackColor = true;
            this.btAddBoek.Click += new System.EventHandler(this.btAddBoek_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(595, 345);
            this.Controls.Add(this.btAddBoek);
            this.Controls.Add(this.lbMyBook);
            this.Controls.Add(this.lbBoeken);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
      
        private System.Windows.Forms.ListBox lbBoeken;
        private System.Windows.Forms.Label lbMyBook;
        private System.Windows.Forms.Button btAddBoek;
    }
}

