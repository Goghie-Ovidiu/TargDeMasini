namespace Interfata
{
    partial class Vanzator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vanzator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firma = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.culoareRosu = new System.Windows.Forms.RadioButton();
            this.culoareAlbastru = new System.Windows.Forms.RadioButton();
            this.culoareVerde = new System.Windows.Forms.RadioButton();
            this.culoareNegru = new System.Windows.Forms.RadioButton();
            this.culoareAlb = new System.Windows.Forms.RadioButton();
            this.culoareGri = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.OptiuniList = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.TextBox();
            this.prenume = new System.Windows.Forms.TextBox();
            this.Suma = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AnFab = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPrefix = new System.Windows.Forms.Label();
            this.Prefix = new System.Windows.Forms.TextBox();
            this.culoareGalben = new System.Windows.Forms.RadioButton();
            this.culoarePortocaliu = new System.Windows.Forms.RadioButton();
            this.AltaCuloare = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AudiLogo = new System.Windows.Forms.PictureBox();
            this.MBLogo = new System.Windows.Forms.PictureBox();
            this.BMWLogo = new System.Windows.Forms.PictureBox();
            this.VWLogo = new System.Windows.Forms.PictureBox();
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AudiLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MBLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMWLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VWLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firma";
            // 
            // firma
            // 
            this.firma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firma.FormattingEnabled = true;
            this.firma.Items.AddRange(new object[] {
            "Volkswagen",
            "BMW",
            "Mercedes-Benz",
            "Audi"});
            this.firma.Location = new System.Drawing.Point(70, 68);
            this.firma.Name = "firma";
            this.firma.Size = new System.Drawing.Size(121, 21);
            this.firma.TabIndex = 3;
            this.firma.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Culoare";
            // 
            // culoareRosu
            // 
            this.culoareRosu.AutoSize = true;
            this.culoareRosu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.culoareRosu.Location = new System.Drawing.Point(107, 7);
            this.culoareRosu.Name = "culoareRosu";
            this.culoareRosu.Size = new System.Drawing.Size(72, 28);
            this.culoareRosu.TabIndex = 6;
            this.culoareRosu.TabStop = true;
            this.culoareRosu.Text = "Rosu";
            this.culoareRosu.UseVisualStyleBackColor = true;
            // 
            // culoareAlbastru
            // 
            this.culoareAlbastru.AutoSize = true;
            this.culoareAlbastru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.culoareAlbastru.Location = new System.Drawing.Point(10, 7);
            this.culoareAlbastru.Name = "culoareAlbastru";
            this.culoareAlbastru.Size = new System.Drawing.Size(96, 28);
            this.culoareAlbastru.TabIndex = 7;
            this.culoareAlbastru.TabStop = true;
            this.culoareAlbastru.Text = "Albastru";
            this.culoareAlbastru.UseVisualStyleBackColor = true;
            // 
            // culoareVerde
            // 
            this.culoareVerde.AutoSize = true;
            this.culoareVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.culoareVerde.Location = new System.Drawing.Point(10, 41);
            this.culoareVerde.Name = "culoareVerde";
            this.culoareVerde.Size = new System.Drawing.Size(80, 28);
            this.culoareVerde.TabIndex = 8;
            this.culoareVerde.TabStop = true;
            this.culoareVerde.Text = "Verde";
            this.culoareVerde.UseVisualStyleBackColor = true;
            // 
            // culoareNegru
            // 
            this.culoareNegru.AutoSize = true;
            this.culoareNegru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.culoareNegru.Location = new System.Drawing.Point(10, 75);
            this.culoareNegru.Name = "culoareNegru";
            this.culoareNegru.Size = new System.Drawing.Size(81, 28);
            this.culoareNegru.TabIndex = 9;
            this.culoareNegru.TabStop = true;
            this.culoareNegru.Text = "Negru";
            this.culoareNegru.UseVisualStyleBackColor = true;
            // 
            // culoareAlb
            // 
            this.culoareAlb.AutoSize = true;
            this.culoareAlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.culoareAlb.Location = new System.Drawing.Point(107, 41);
            this.culoareAlb.Name = "culoareAlb";
            this.culoareAlb.Size = new System.Drawing.Size(56, 28);
            this.culoareAlb.TabIndex = 10;
            this.culoareAlb.TabStop = true;
            this.culoareAlb.Text = "Alb";
            this.culoareAlb.UseVisualStyleBackColor = true;
            // 
            // culoareGri
            // 
            this.culoareGri.AutoSize = true;
            this.culoareGri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.culoareGri.Location = new System.Drawing.Point(107, 75);
            this.culoareGri.Name = "culoareGri";
            this.culoareGri.Size = new System.Drawing.Size(52, 28);
            this.culoareGri.TabIndex = 11;
            this.culoareGri.TabStop = true;
            this.culoareGri.Text = "Gri";
            this.culoareGri.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Optiuni";
            // 
            // OptiuniList
            // 
            this.OptiuniList.FormattingEnabled = true;
            this.OptiuniList.Items.AddRange(new object[] {
            "Aer Conditionat ",
            "Navigatie ",
            "Cutie Automata ",
            "Incalzire in scaune ",
            "Bluetooth ",
            "Senzori de parcare ",
            "ABS ",
            "Servodirectie "});
            this.OptiuniList.Location = new System.Drawing.Point(79, 111);
            this.OptiuniList.Name = "OptiuniList";
            this.OptiuniList.Size = new System.Drawing.Size(117, 124);
            this.OptiuniList.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(291, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pret";
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(70, 17);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(100, 20);
            this.nume.TabIndex = 15;
            this.nume.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // prenume
            // 
            this.prenume.Location = new System.Drawing.Point(343, 16);
            this.prenume.Name = "prenume";
            this.prenume.Size = new System.Drawing.Size(100, 20);
            this.prenume.TabIndex = 16;
            this.prenume.TextChanged += new System.EventHandler(this.prenume_TextChanged);
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(343, 311);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(58, 20);
            this.Suma.TabIndex = 17;
            this.Suma.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 18;
            this.button1.Text = "Vinde";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 37);
            this.button2.TabIndex = 20;
            this.button2.Text = "inapoi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnFab
            // 
            this.AnFab.CustomFormat = "dd-MM-yyyy";
            this.AnFab.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AnFab.Location = new System.Drawing.Point(130, 256);
            this.AnFab.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.AnFab.Name = "AnFab";
            this.AnFab.Size = new System.Drawing.Size(100, 20);
            this.AnFab.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "An Fabricatie";
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(197, 312);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(73, 20);
            this.telefon.TabIndex = 23;
            this.telefon.TextChanged += new System.EventHandler(this.telefon_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 24);
            this.label9.TabIndex = 24;
            this.label9.Text = "Numar de telefon";
            // 
            // labelPrefix
            // 
            this.labelPrefix.AutoSize = true;
            this.labelPrefix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrefix.Location = new System.Drawing.Point(156, 293);
            this.labelPrefix.Name = "labelPrefix";
            this.labelPrefix.Size = new System.Drawing.Size(40, 16);
            this.labelPrefix.TabIndex = 25;
            this.labelPrefix.Text = "Prefix";
            // 
            // Prefix
            // 
            this.Prefix.Location = new System.Drawing.Point(159, 312);
            this.Prefix.Name = "Prefix";
            this.Prefix.Size = new System.Drawing.Size(32, 20);
            this.Prefix.TabIndex = 26;
            this.Prefix.TextChanged += new System.EventHandler(this.Prefix_TextChanged);
            // 
            // culoareGalben
            // 
            this.culoareGalben.AutoSize = true;
            this.culoareGalben.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.culoareGalben.Location = new System.Drawing.Point(10, 109);
            this.culoareGalben.Name = "culoareGalben";
            this.culoareGalben.Size = new System.Drawing.Size(89, 28);
            this.culoareGalben.TabIndex = 31;
            this.culoareGalben.TabStop = true;
            this.culoareGalben.Text = "Galben";
            this.culoareGalben.UseVisualStyleBackColor = true;
            // 
            // culoarePortocaliu
            // 
            this.culoarePortocaliu.AutoSize = true;
            this.culoarePortocaliu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.culoarePortocaliu.Location = new System.Drawing.Point(107, 109);
            this.culoarePortocaliu.Name = "culoarePortocaliu";
            this.culoarePortocaliu.Size = new System.Drawing.Size(111, 28);
            this.culoarePortocaliu.TabIndex = 32;
            this.culoarePortocaliu.TabStop = true;
            this.culoarePortocaliu.Text = "Portocaliu";
            this.culoarePortocaliu.UseVisualStyleBackColor = true;
            // 
            // AltaCuloare
            // 
            this.AltaCuloare.AutoSize = true;
            this.AltaCuloare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltaCuloare.Location = new System.Drawing.Point(10, 143);
            this.AltaCuloare.Name = "AltaCuloare";
            this.AltaCuloare.Size = new System.Drawing.Size(130, 28);
            this.AltaCuloare.TabIndex = 33;
            this.AltaCuloare.TabStop = true;
            this.AltaCuloare.Text = "Alta Culoare";
            this.AltaCuloare.UseVisualStyleBackColor = true;
            this.AltaCuloare.CheckedChanged += new System.EventHandler(this.AltaCuloare_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AltaCuloare);
            this.groupBox1.Controls.Add(this.culoarePortocaliu);
            this.groupBox1.Controls.Add(this.culoareGalben);
            this.groupBox1.Controls.Add(this.culoareGri);
            this.groupBox1.Controls.Add(this.culoareAlb);
            this.groupBox1.Controls.Add(this.culoareNegru);
            this.groupBox1.Controls.Add(this.culoareVerde);
            this.groupBox1.Controls.Add(this.culoareAlbastru);
            this.groupBox1.Controls.Add(this.culoareRosu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(321, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 180);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // AudiLogo
            // 
            this.AudiLogo.Image = global::Interfata.Properties.Resources.Audi;
            this.AudiLogo.Location = new System.Drawing.Point(197, 42);
            this.AudiLogo.Name = "AudiLogo";
            this.AudiLogo.Size = new System.Drawing.Size(73, 63);
            this.AudiLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AudiLogo.TabIndex = 30;
            this.AudiLogo.TabStop = false;
            this.AudiLogo.Visible = false;
            // 
            // MBLogo
            // 
            this.MBLogo.Image = global::Interfata.Properties.Resources.MB;
            this.MBLogo.Location = new System.Drawing.Point(197, 42);
            this.MBLogo.Name = "MBLogo";
            this.MBLogo.Size = new System.Drawing.Size(73, 63);
            this.MBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MBLogo.TabIndex = 29;
            this.MBLogo.TabStop = false;
            this.MBLogo.Visible = false;
            // 
            // BMWLogo
            // 
            this.BMWLogo.Image = global::Interfata.Properties.Resources.bmw;
            this.BMWLogo.Location = new System.Drawing.Point(197, 42);
            this.BMWLogo.Name = "BMWLogo";
            this.BMWLogo.Size = new System.Drawing.Size(73, 63);
            this.BMWLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BMWLogo.TabIndex = 28;
            this.BMWLogo.TabStop = false;
            this.BMWLogo.Visible = false;
            // 
            // VWLogo
            // 
            this.VWLogo.Image = global::Interfata.Properties.Resources.vw;
            this.VWLogo.Location = new System.Drawing.Point(197, 42);
            this.VWLogo.Name = "VWLogo";
            this.VWLogo.Size = new System.Drawing.Size(73, 63);
            this.VWLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VWLogo.TabIndex = 27;
            this.VWLogo.TabStop = false;
            this.VWLogo.Visible = false;
            this.VWLogo.Click += new System.EventHandler(this.VWLogo_Click);
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataSource = typeof(Interfata.Vanzator);
            // 
            // Vanzator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AudiLogo);
            this.Controls.Add(this.MBLogo);
            this.Controls.Add(this.BMWLogo);
            this.Controls.Add(this.VWLogo);
            this.Controls.Add(this.Prefix);
            this.Controls.Add(this.labelPrefix);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AnFab);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.prenume);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OptiuniList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vanzator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AudiLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MBLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMWLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VWLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox firma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource form2BindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton culoareRosu;
        private System.Windows.Forms.RadioButton culoareAlbastru;
        private System.Windows.Forms.RadioButton culoareVerde;
        private System.Windows.Forms.RadioButton culoareNegru;
        private System.Windows.Forms.RadioButton culoareAlb;
        private System.Windows.Forms.RadioButton culoareGri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox OptiuniList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.TextBox prenume;
        private System.Windows.Forms.TextBox Suma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker AnFab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelPrefix;
        private System.Windows.Forms.TextBox Prefix;
        private System.Windows.Forms.PictureBox VWLogo;
        private System.Windows.Forms.PictureBox BMWLogo;
        private System.Windows.Forms.PictureBox MBLogo;
        private System.Windows.Forms.PictureBox AudiLogo;
        private System.Windows.Forms.RadioButton culoareGalben;
        private System.Windows.Forms.RadioButton culoarePortocaliu;
        private System.Windows.Forms.RadioButton AltaCuloare;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}