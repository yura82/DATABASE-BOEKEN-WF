namespace DATABASE_BOEKEN_WF
{
    partial class addBook
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
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAuteur = new System.Windows.Forms.ComboBox();
            this.cbGanre = new System.Windows.Forms.ComboBox();
            this.cbUitgeverij = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTittel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numScores = new System.Windows.Forms.NumericUpDown();
            this.numPages = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.datePublish = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPages)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(157, 31);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(203, 22);
            this.txtVoornaam.TabIndex = 0;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(157, 71);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(203, 22);
            this.txtAchternaam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voornaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Achternaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ganre";
            // 
            // cbAuteur
            // 
            this.cbAuteur.FormattingEnabled = true;
            this.cbAuteur.Location = new System.Drawing.Point(177, 135);
            this.cbAuteur.Name = "cbAuteur";
            this.cbAuteur.Size = new System.Drawing.Size(121, 24);
            this.cbAuteur.TabIndex = 5;
            // 
            // cbGanre
            // 
            this.cbGanre.FormattingEnabled = true;
            this.cbGanre.Location = new System.Drawing.Point(177, 179);
            this.cbGanre.Name = "cbGanre";
            this.cbGanre.Size = new System.Drawing.Size(121, 24);
            this.cbGanre.TabIndex = 6;
            // 
            // cbUitgeverij
            // 
            this.cbUitgeverij.FormattingEnabled = true;
            this.cbUitgeverij.Location = new System.Drawing.Point(177, 228);
            this.cbUitgeverij.Name = "cbUitgeverij";
            this.cbUitgeverij.Size = new System.Drawing.Size(121, 24);
            this.cbUitgeverij.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Auteur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Uitgeverij";
            // 
            // txtTittel
            // 
            this.txtTittel.Location = new System.Drawing.Point(542, 34);
            this.txtTittel.Name = "txtTittel";
            this.txtTittel.Size = new System.Drawing.Size(205, 22);
            this.txtTittel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tittel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "ADD to Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "score";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Aantal Paginas";
            // 
            // numScores
            // 
            this.numScores.Location = new System.Drawing.Point(207, 303);
            this.numScores.Name = "numScores";
            this.numScores.Size = new System.Drawing.Size(120, 22);
            this.numScores.TabIndex = 15;
            // 
            // numPages
            // 
            this.numPages.Location = new System.Drawing.Point(207, 362);
            this.numPages.Name = "numPages";
            this.numPages.Size = new System.Drawing.Size(120, 22);
            this.numPages.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Publish";
            // 
            // datePublish
            // 
            this.datePublish.Location = new System.Drawing.Point(542, 103);
            this.datePublish.Name = "datePublish";
            this.datePublish.Size = new System.Drawing.Size(200, 22);
            this.datePublish.TabIndex = 18;
            // 
            // addBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datePublish);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numPages);
            this.Controls.Add(this.numScores);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTittel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbUitgeverij);
            this.Controls.Add(this.cbGanre);
            this.Controls.Add(this.cbAuteur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Name = "addBook";
            this.Text = "addBook";
            this.Load += new System.EventHandler(this.addBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAuteur;
        private System.Windows.Forms.ComboBox cbGanre;
        private System.Windows.Forms.ComboBox cbUitgeverij;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTittel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numScores;
        private System.Windows.Forms.NumericUpDown numPages;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datePublish;
    }
}