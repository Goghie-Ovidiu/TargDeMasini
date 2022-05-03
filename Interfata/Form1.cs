using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using Masini;
using Fisier;

namespace Interfata
{
    public partial class Form1 : Form
    {
        AdministrareFisier adminMasini = new AdministrareFisier("Masini.txt");
        private Label lblNume_Vanzator;
        private Label lblNume_Cumparator;
        private Label lblFirma;

        private TextBox txtNume_Vanzator;
        private TextBox txtNume_Cumparator;
        private TextBox txtFirma;

        private Label[] lblsNume_Vanzator;
        private Label[] lblsNume_Cumparator;
        private Label[] lblsFirma;

        private Button btnAdauga;
        private Button btnAfisare;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;

        private int ID;
        private const int LATIME_BOX = 80;


        public Form1()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminMasini = new AdministrareFisier(caleCompletaFisier);
            InitializeComponent();

            //setare proprietati
            this.Size = new Size(1000, 200);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.LimeGreen;
            this.Text = "Informatii Masini";

            //adaugare control de tip Label pentru 'vanzator';
            lblNume_Vanzator = new Label();
            lblNume_Vanzator.Width = LATIME_CONTROL;
            lblNume_Vanzator.Text = "Nume Vanzator";
            lblNume_Vanzator.Left = DIMENSIUNE_PAS_X;
            lblNume_Vanzator.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblNume_Vanzator);

            //adaugare control de tip Label pentru 'cumpa';
            lblNume_Cumparator = new Label();
            lblNume_Cumparator.Width = LATIME_CONTROL;
            lblNume_Cumparator.Text = "Cumparator";
            lblNume_Cumparator.Left = 2 * DIMENSIUNE_PAS_X;
            lblNume_Cumparator.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblNume_Cumparator);

            //adaugare control de tip Label pentru 'firma';
            lblFirma = new Label();
            lblFirma.Width = LATIME_CONTROL;
            lblFirma.Text = "Firma";
            lblFirma.Left = 3 * DIMENSIUNE_PAS_X;
            lblFirma.ForeColor = Color.DarkGreen;
            this.Controls.Add(lblFirma);


            // TEXT vanz
            txtNume_Vanzator = new TextBox();
            txtNume_Vanzator.Width = LATIME_BOX;
            txtNume_Vanzator.Top = DIMENSIUNE_PAS_Y;
            txtNume_Vanzator.Left = DIMENSIUNE_PAS_X;
            this.Controls.Add(txtNume_Vanzator);

            // TEXT cump
            txtNume_Cumparator = new TextBox();
            txtNume_Cumparator.Width = LATIME_BOX;
            txtNume_Cumparator.Top = DIMENSIUNE_PAS_Y;
            txtNume_Cumparator.Left = 2 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtNume_Cumparator);

            // TEXT firma
            txtFirma = new TextBox();
            txtFirma.Width = LATIME_BOX;
            txtFirma.Top = DIMENSIUNE_PAS_Y;
            txtFirma.Left = 3 * DIMENSIUNE_PAS_X;
            this.Controls.Add(txtFirma);



            //buton adauga
            btnAdauga = new Button();
            btnAdauga.Width = LATIME_CONTROL;
            btnAdauga.Top = DIMENSIUNE_PAS_Y;
            btnAdauga.Text = "Adauga datele";
            btnAdauga.Click += OnButtonClicked;
            this.Controls.Add(btnAdauga);

            //buton afisare
            btnAfisare = new Button();
            btnAfisare.Width = LATIME_CONTROL;
            btnAfisare.Top = 2 * DIMENSIUNE_PAS_Y;
            btnAfisare.Text = "Afisare";
            btnAfisare.Click += Form1_Load;
            this.Controls.Add(btnAfisare);

        }
        private void OnButtonClicked(object sender, EventArgs e)
        {


            TargMasini masina = new TargMasini(ID, txtNume_Vanzator.Text, txtNume_Cumparator.Text, txtFirma.Text, txtFirma.Text, txtNume_Vanzator.Text, txtNume_Vanzator.Text, txtNume_Vanzator.Text, txtNume_Vanzator.Text, txtNume_Vanzator.Text);
            
            adminMasini.AddMasina(masina);
            ID = ID + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaMasini();
        }

        private void AfiseazaMasini()
        {
            TargMasini[] masina = adminMasini.GetMasini(out int nrMasini);

            lblsNume_Vanzator = new Label[nrMasini];
            lblsNume_Cumparator = new Label[nrMasini];
            lblsFirma = new Label[nrMasini];

            int i = 0;
            foreach (TargMasini masinaa in masina)
            {
                //adaugare control de tip Label pentru vanzator
                lblsNume_Vanzator[i] = new Label();
                lblsNume_Vanzator[i].Width = LATIME_CONTROL;
                lblsNume_Vanzator[i].Text = masinaa.nume_vanzator;
                lblsNume_Vanzator[i].Left = DIMENSIUNE_PAS_X;
                lblsNume_Vanzator[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume_Vanzator[i]);

                //adaugare control de tip Label pentru cumpar
                lblsNume_Cumparator[i] = new Label();
                lblsNume_Cumparator[i].Width = LATIME_CONTROL;
                lblsNume_Cumparator[i].Text = masinaa.nume_cumparator;
                lblsNume_Cumparator[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsNume_Cumparator[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume_Cumparator[i]);

                //adaugare control de tip Label pentru firma
                lblsFirma[i] = new Label();
                lblsFirma[i].Width = LATIME_CONTROL;
                lblsFirma[i].Text = masinaa.firma;
                lblsFirma[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsFirma[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsFirma[i]);


                i++;
            }
        }
    }
}
