namespace Interfata
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeVanzator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenumeVanzator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnFab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Culoare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Optiuni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NumeCumparator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenumeCumparator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inapoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NumeVanzator,
            this.PrenumeVanzator,
            this.Firma,
            this.Model,
            this.AnFab,
            this.Culoare,
            this.Optiuni,
            this.Pret,
            this.NrTelefon});
            this.dataGridView1.Location = new System.Drawing.Point(167, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(953, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // NumeVanzator
            // 
            this.NumeVanzator.HeaderText = "Nume Vanzator";
            this.NumeVanzator.Name = "NumeVanzator";
            // 
            // PrenumeVanzator
            // 
            this.PrenumeVanzator.HeaderText = "Prenume Vanzator";
            this.PrenumeVanzator.Name = "PrenumeVanzator";
            // 
            // Firma
            // 
            this.Firma.HeaderText = "Firma";
            this.Firma.Name = "Firma";
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // AnFab
            // 
            this.AnFab.HeaderText = "An Fabricatie";
            this.AnFab.Name = "AnFab";
            // 
            // Culoare
            // 
            this.Culoare.HeaderText = "Culoare";
            this.Culoare.Name = "Culoare";
            // 
            // Optiuni
            // 
            this.Optiuni.HeaderText = "Optiuni";
            this.Optiuni.Name = "Optiuni";
            // 
            // Pret
            // 
            this.Pret.HeaderText = "Pret";
            this.Pret.Name = "Pret";
            // 
            // NrTelefon
            // 
            this.NrTelefon.HeaderText = "Numar de telefon";
            this.NrTelefon.Name = "NrTelefon";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeCumparator,
            this.PrenumeCumparator});
            this.dataGridView2.Location = new System.Drawing.Point(-37, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(245, 184);
            this.dataGridView2.TabIndex = 1;
            // 
            // NumeCumparator
            // 
            this.NumeCumparator.HeaderText = "Nume Cumparator";
            this.NumeCumparator.Name = "NumeCumparator";
            // 
            // PrenumeCumparator
            // 
            this.PrenumeCumparator.HeaderText = "Prenume Cumparator";
            this.PrenumeCumparator.Name = "PrenumeCumparator";
            // 
            // Inapoi
            // 
            this.Inapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inapoi.Location = new System.Drawing.Point(12, 270);
            this.Inapoi.Name = "Inapoi";
            this.Inapoi.Size = new System.Drawing.Size(80, 37);
            this.Inapoi.TabIndex = 2;
            this.Inapoi.Text = "Inapoi";
            this.Inapoi.UseVisualStyleBackColor = true;
            this.Inapoi.Click += new System.EventHandler(this.Inapoi_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1097, 314);
            this.Controls.Add(this.Inapoi);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administrator";
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeVanzator;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenumeVanzator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnFab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Culoare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Optiuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pret;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrTelefon;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeCumparator;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenumeCumparator;
        private System.Windows.Forms.Button Inapoi;
    }
}