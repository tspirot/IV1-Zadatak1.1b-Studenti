namespace Zadatak1._1b
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBrIndeksa = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.listBoxStudenti = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPredmeti = new System.Windows.Forms.ComboBox();
            this.textBoxOcena = new System.Windows.Forms.TextBox();
            this.buttonDodajOcenu = new System.Windows.Forms.Button();
            this.buttonObrisiOcenu = new System.Windows.Forms.Button();
            this.listBoxOcene = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Br indeksa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ime";
            // 
            // textBoxBrIndeksa
            // 
            this.textBoxBrIndeksa.Location = new System.Drawing.Point(93, 30);
            this.textBoxBrIndeksa.Name = "textBoxBrIndeksa";
            this.textBoxBrIndeksa.Size = new System.Drawing.Size(100, 22);
            this.textBoxBrIndeksa.TabIndex = 3;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(93, 59);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(175, 22);
            this.textBoxPrezime.TabIndex = 4;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(93, 86);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(175, 22);
            this.textBoxIme.TabIndex = 5;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(54, 126);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 6;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(193, 127);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonObrisi.TabIndex = 7;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // listBoxStudenti
            // 
            this.listBoxStudenti.FormattingEnabled = true;
            this.listBoxStudenti.ItemHeight = 16;
            this.listBoxStudenti.Location = new System.Drawing.Point(54, 157);
            this.listBoxStudenti.Name = "listBoxStudenti";
            this.listBoxStudenti.Size = new System.Drawing.Size(214, 276);
            this.listBoxStudenti.TabIndex = 8;
            this.listBoxStudenti.SelectedIndexChanged += new System.EventHandler(this.listBoxStudenti_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Predmet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ocena";
            // 
            // comboBoxPredmeti
            // 
            this.comboBoxPredmeti.FormattingEnabled = true;
            this.comboBoxPredmeti.Location = new System.Drawing.Point(424, 24);
            this.comboBoxPredmeti.Name = "comboBoxPredmeti";
            this.comboBoxPredmeti.Size = new System.Drawing.Size(179, 24);
            this.comboBoxPredmeti.TabIndex = 11;
            // 
            // textBoxOcena
            // 
            this.textBoxOcena.Location = new System.Drawing.Point(424, 61);
            this.textBoxOcena.Name = "textBoxOcena";
            this.textBoxOcena.Size = new System.Drawing.Size(100, 22);
            this.textBoxOcena.TabIndex = 12;
            // 
            // buttonDodajOcenu
            // 
            this.buttonDodajOcenu.Location = new System.Drawing.Point(399, 126);
            this.buttonDodajOcenu.Name = "buttonDodajOcenu";
            this.buttonDodajOcenu.Size = new System.Drawing.Size(99, 23);
            this.buttonDodajOcenu.TabIndex = 13;
            this.buttonDodajOcenu.Text = "Dodaj ocenu";
            this.buttonDodajOcenu.UseVisualStyleBackColor = true;
            this.buttonDodajOcenu.Click += new System.EventHandler(this.buttonDodajOcenu_Click);
            // 
            // buttonObrisiOcenu
            // 
            this.buttonObrisiOcenu.Location = new System.Drawing.Point(517, 127);
            this.buttonObrisiOcenu.Name = "buttonObrisiOcenu";
            this.buttonObrisiOcenu.Size = new System.Drawing.Size(99, 23);
            this.buttonObrisiOcenu.TabIndex = 14;
            this.buttonObrisiOcenu.Text = "Obrisi ocenu";
            this.buttonObrisiOcenu.UseVisualStyleBackColor = true;
            this.buttonObrisiOcenu.Click += new System.EventHandler(this.buttonObrisiOcenu_Click);
            // 
            // listBoxOcene
            // 
            this.listBoxOcene.FormattingEnabled = true;
            this.listBoxOcene.ItemHeight = 16;
            this.listBoxOcene.Location = new System.Drawing.Point(399, 172);
            this.listBoxOcene.Name = "listBoxOcene";
            this.listBoxOcene.Size = new System.Drawing.Size(217, 260);
            this.listBoxOcene.TabIndex = 15;
            this.listBoxOcene.SelectedIndexChanged += new System.EventHandler(this.listBoxOcene_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.listBoxOcene);
            this.Controls.Add(this.buttonObrisiOcenu);
            this.Controls.Add(this.buttonDodajOcenu);
            this.Controls.Add(this.textBoxOcena);
            this.Controls.Add(this.comboBoxPredmeti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxStudenti);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxBrIndeksa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBrIndeksa;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.ListBox listBoxStudenti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPredmeti;
        private System.Windows.Forms.TextBox textBoxOcena;
        private System.Windows.Forms.Button buttonDodajOcenu;
        private System.Windows.Forms.Button buttonObrisiOcenu;
        private System.Windows.Forms.ListBox listBoxOcene;
    }
}

