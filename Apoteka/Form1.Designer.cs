namespace Apoteka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lekID = new TextBox();
            naziv = new TextBox();
            vrsta = new TextBox();
            proizvodjac = new TextBox();
            txtFilter = new TextBox();
            cbxFilter = new ComboBox();
            dugmeDodaj = new Button();
            dugmeIzmeni = new Button();
            dugmeObrisi = new Button();
            dugmeFiltriraj = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            bolest = new TextBox();
            kolicina = new TextBox();
            label8 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 42);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 96);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Naziv";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 151);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Vrsta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 208);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 3;
            label4.Text = "Proizvodjac";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(327, 62);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 4;
            label5.Text = "Filtriranje:";
            // 
            // lekID
            // 
            lekID.Location = new Point(47, 60);
            lekID.Name = "lekID";
            lekID.Size = new Size(175, 23);
            lekID.TabIndex = 5;
            // 
            // naziv
            // 
            naziv.Location = new Point(47, 114);
            naziv.Name = "naziv";
            naziv.Size = new Size(175, 23);
            naziv.TabIndex = 6;
            // 
            // vrsta
            // 
            vrsta.Location = new Point(47, 169);
            vrsta.Name = "vrsta";
            vrsta.Size = new Size(175, 23);
            vrsta.TabIndex = 7;
            // 
            // proizvodjac
            // 
            proizvodjac.Location = new Point(47, 226);
            proizvodjac.Name = "proizvodjac";
            proizvodjac.Size = new Size(175, 23);
            proizvodjac.TabIndex = 8;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(418, 95);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(175, 23);
            txtFilter.TabIndex = 9;
            // 
            // cbxFilter
            // 
            cbxFilter.FormattingEnabled = true;
            cbxFilter.Location = new Point(418, 60);
            cbxFilter.Name = "cbxFilter";
            cbxFilter.Size = new Size(175, 23);
            cbxFilter.TabIndex = 10;
            // 
            // dugmeDodaj
            // 
            dugmeDodaj.Location = new Point(23, 415);
            dugmeDodaj.Name = "dugmeDodaj";
            dugmeDodaj.Size = new Size(75, 23);
            dugmeDodaj.TabIndex = 11;
            dugmeDodaj.Text = "Dodaj";
            dugmeDodaj.UseVisualStyleBackColor = true;
            dugmeDodaj.Click += dugmeDodaj_Click;
            // 
            // dugmeIzmeni
            // 
            dugmeIzmeni.Location = new Point(124, 415);
            dugmeIzmeni.Name = "dugmeIzmeni";
            dugmeIzmeni.Size = new Size(75, 23);
            dugmeIzmeni.TabIndex = 12;
            dugmeIzmeni.Text = "Izmeni";
            dugmeIzmeni.UseVisualStyleBackColor = true;
            dugmeIzmeni.Click += dugmeIzmeni_Click;
            // 
            // dugmeObrisi
            // 
            dugmeObrisi.Location = new Point(225, 415);
            dugmeObrisi.Name = "dugmeObrisi";
            dugmeObrisi.Size = new Size(75, 23);
            dugmeObrisi.TabIndex = 13;
            dugmeObrisi.Text = "Obrisi";
            dugmeObrisi.UseVisualStyleBackColor = true;
            dugmeObrisi.Click += dugmeObrisi_Click;
            // 
            // dugmeFiltriraj
            // 
            dugmeFiltriraj.Location = new Point(614, 95);
            dugmeFiltriraj.Name = "dugmeFiltriraj";
            dugmeFiltriraj.Size = new Size(75, 23);
            dugmeFiltriraj.TabIndex = 14;
            dugmeFiltriraj.Text = "Filtriraj";
            dugmeFiltriraj.UseVisualStyleBackColor = true;
            dugmeFiltriraj.Click += dugmeFiltriraj_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(327, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(438, 270);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(47, 9);
            label6.Name = "label6";
            label6.Size = new Size(152, 21);
            label6.TabIndex = 16;
            label6.Text = "Dodavanje lekova:";
            // 
            // bolest
            // 
            bolest.Location = new Point(47, 279);
            bolest.Name = "bolest";
            bolest.Size = new Size(175, 23);
            bolest.TabIndex = 18;
            // 
            // kolicina
            // 
            kolicina.Location = new Point(47, 333);
            kolicina.Name = "kolicina";
            kolicina.Size = new Size(175, 23);
            kolicina.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 315);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 19;
            label8.Text = "Kolicina";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 261);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 21;
            label7.Text = "Bolest";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(kolicina);
            Controls.Add(label8);
            Controls.Add(bolest);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(dugmeFiltriraj);
            Controls.Add(dugmeObrisi);
            Controls.Add(dugmeIzmeni);
            Controls.Add(dugmeDodaj);
            Controls.Add(cbxFilter);
            Controls.Add(txtFilter);
            Controls.Add(proizvodjac);
            Controls.Add(vrsta);
            Controls.Add(naziv);
            Controls.Add(lekID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Apoteka";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox lekID;
        private TextBox naziv;
        private TextBox vrsta;
        private TextBox proizvodjac;
        private TextBox txtFilter;
        private ComboBox cbxFilter;
        private Button dugmeDodaj;
        private Button dugmeIzmeni;
        private Button dugmeObrisi;
        private Button dugmeFiltriraj;
        private DataGridView dataGridView1;
        private Label label6;
        private TextBox bolest;
        private TextBox kolicina;
        private Label label8;
        private Label label7;
    }
}