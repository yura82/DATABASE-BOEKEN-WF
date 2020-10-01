namespace DATABASE_BOEKEN_WF
{
    partial class NewAutGenUIt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtUitgeverijn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btNewGenre = new System.Windows.Forms.Button();
            this.btNewUItgev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voornaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Achternaam";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(173, 48);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(100, 22);
            this.txtVoornaam.TabIndex = 2;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(173, 91);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(100, 22);
            this.txtAchternaam.TabIndex = 3;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(173, 137);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 22);
            this.txtGenre.TabIndex = 4;
            // 
            // txtUitgeverijn
            // 
            this.txtUitgeverijn.Location = new System.Drawing.Point(173, 188);
            this.txtUitgeverijn.Name = "txtUitgeverijn";
            this.txtUitgeverijn.Size = new System.Drawing.Size(100, 22);
            this.txtUitgeverijn.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Uitgeverijn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add New Auteur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btNewGenre
            // 
            this.btNewGenre.Location = new System.Drawing.Point(386, 141);
            this.btNewGenre.Name = "btNewGenre";
            this.btNewGenre.Size = new System.Drawing.Size(98, 23);
            this.btNewGenre.TabIndex = 9;
            this.btNewGenre.Text = "New Genre";
            this.btNewGenre.UseVisualStyleBackColor = true;
            this.btNewGenre.Click += new System.EventHandler(this.btNewGenre_Click);
            // 
            // btNewUItgev
            // 
            this.btNewUItgev.Location = new System.Drawing.Point(359, 187);
            this.btNewUItgev.Name = "btNewUItgev";
            this.btNewUItgev.Size = new System.Drawing.Size(206, 23);
            this.btNewUItgev.TabIndex = 10;
            this.btNewUItgev.Text = "New UItgeverijn";
            this.btNewUItgev.UseVisualStyleBackColor = true;
            this.btNewUItgev.Click += new System.EventHandler(this.btNewUItgev_Click);
            // 
            // NewAutGenUIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btNewUItgev);
            this.Controls.Add(this.btNewGenre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUitgeverijn);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewAutGenUIt";
            this.Text = "NewAutGenUIt";
            this.Load += new System.EventHandler(this.NewAutGenUIt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtUitgeverijn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btNewGenre;
        private System.Windows.Forms.Button btNewUItgev;
    }
}