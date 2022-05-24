using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Masini;
using Fisier;
using static Masini.Enumerari.Culori;
using static Masini.Enumerari;
using System.Configuration;

namespace Interfata
{
    public partial class Form2 : Form
    {
        AdministrareFisier adminMasini = new AdministrareFisier("Masini.txt");

        public int ID;
        private Label[] lblsNume_Vanzator;
        private Label[] lblsPrenume_Vanzator;
        private Label[] lblsFirma;
        private Label[] lblsModel;
        private Label[] lblsCuloare;
        private Label[] lblsOptiuni;
        private Label[] lblsPret;
        private Label[] lblsAnFab;

        private ComboBox model;
        string culoare ="";
        string optiuni = "";

        private ComboBox vol;
        private ComboBox bmw;
        private ComboBox audi;
        private ComboBox mercedes;
        
        public Form2()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminMasini = new AdministrareFisier(caleCompletaFisier);
            InitializeComponent();
            this.Text = "Vanzator";

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == comboBox1.Items.IndexOf("Volkswagen"))
            {
                vol=new ComboBox();
                vol.Width = 121;
                vol.Items.Add("Arteon"); vol.Items.Add("Arteon Shooting"); vol.Items.Add("Beetle"); vol.Items.Add("Fox"); vol.Items.Add("Sharan");
                vol.Items.Add("Golf"); vol.Items.Add("Jetta"); vol.Items.Add("Passat"); vol.Items.Add("Phaeton"); vol.Items.Add("Polo"); vol.Items.Add("Tiguan");
                vol.Items.Add("Touareg"); vol.Items.Add("Passat CC");
                vol.Left = 300;
                vol.Top = 68;
                this.Controls.Add(vol);
                this.Controls.Add(comboBox1);
                model = vol;
            }
            else
            {
                if(vol!=null)
                { vol.Left = 5500; vol.Top=5120; }
            }

            if (comboBox1.SelectedIndex == comboBox1.Items.IndexOf("BMW"))
            {
                bmw = new ComboBox();
                bmw.Width = 121;
                bmw.Items.Add("3 Series Sedan"); bmw.Items.Add("5 Series Sedan"); bmw.Items.Add("7 Series Sedan");bmw.Items.Add("M3 Sedan"); bmw.Items.Add("M5 Sedan");
                bmw.Items.Add("i4"); bmw.Items.Add("4 Series Coupe"); bmw.Items.Add("8 Series Coupe"); bmw.Items.Add("M4 Coupe"); bmw.Items.Add("X1");
                bmw.Items.Add("X2");bmw.Items.Add("X3"); bmw.Items.Add("X3 M"); bmw.Items.Add("X4"); bmw.Items.Add("X4 M"); bmw.Items.Add("X5 M"); bmw.Items.Add("X5");
                bmw.Items.Add("X6"); bmw.Items.Add("X6 M"); bmw.Items.Add("X7"); bmw.Items.Add("iX");
                bmw.Left = 300;
                bmw.Top = 68;
                this.Controls.Add(bmw);
                this.Controls.Add(comboBox1);
                model = bmw;
            }
            else
            {   if (bmw != null)
                {
                    bmw.Left = 5553;
                    bmw.Top = 5120;
                }
                
            }

            if(comboBox1.SelectedIndex==comboBox1.Items.IndexOf("Mercedes-Benz"))
            {
                mercedes=new ComboBox();
                mercedes.Width = 121;
                mercedes.Items.Add("GLA SUV"); mercedes.Items.Add("GLB SUV"); mercedes.Items.Add("GLC SUV"); mercedes.Items.Add("GLE SUV");
                mercedes.Items.Add("GLE Coupe"); mercedes.Items.Add("GLS SUV"); mercedes.Items.Add("Maybach GLS SUV"); mercedes.Items.Add("G-Class SUV");
                mercedes.Items.Add("A-Class Sedan"); mercedes.Items.Add("C-Class Sedan"); mercedes.Items.Add("E-Class Sedan"); mercedes.Items.Add("S-Class Sedan");
                mercedes.Items.Add("Maybach S-Class");mercedes.Items.Add("C-Class Cabriolet"); mercedes.Items.Add("E-Class Cabriolet");mercedes.Items.Add("AMG GT");
                mercedes.Left = 300;
                mercedes.Top = 68;
                this.Controls.Add(mercedes);
                this.Controls.Add(comboBox1);
                model = mercedes;
            }
            else
                if(mercedes != null)
            { mercedes.Left = 5555; }

            if (comboBox1.SelectedIndex == comboBox1.Items.IndexOf("Audi"))
            {
               
                audi = new ComboBox();
                audi.Width = 121;
                audi.Items.Add("A1");audi.Items.Add("A3");audi.Items.Add("S3 Limousine");audi.Items.Add("RS 3 Sportback"); audi.Items.Add("A4");
                audi.Items.Add("S4 Limousine");audi.Items.Add("RS 4 Avant"); audi.Items.Add("A5"); audi.Items.Add("S5 Coupé");audi.Items.Add("S5 Sportback"); 
                audi.Items.Add("RS 5Sportback"); audi.Items.Add("A6"); audi.Items.Add("A6 allroad quattro");audi.Items.Add("S6 Limousine");
                audi.Items.Add("RS 6 Avant");audi.Items.Add("A7 Sportback");audi.Items.Add("S7 Sportback");audi.Items.Add("RS 7 Sportback");
                audi.Items.Add("A8");audi.Items.Add("S8");audi.Items.Add("Q2");audi.Items.Add("Q3");audi.Items.Add("RS Q3");audi.Items.Add("TT RS");
                audi.Items.Add("R8	Spyder");
                audi.Left = 300;
                audi.Top = 68;
                this.Controls.Add(audi);
                this.Controls.Add(comboBox1);
                model = audi;

            }
            else
            {
                if (audi!=null)
                {
                    audi.Left = 5453;
                    audi.Top = 5120;
                    
                }
            }

            

            
        }

        private string culoareSelectata()
        {
            
            if (radioButton1.Checked)
               culoare="Rosu";
            if (radioButton2.Checked)
                culoare = "Albastru"; 
            if (radioButton3.Checked)
                culoare = "Verde"; 
            if (radioButton4.Checked)
                culoare = "Negru"; 
            if (radioButton5.Checked)
                culoare = "Alb";
            if (radioButton6.Checked)
                culoare = "Gri"; 
            return culoare;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            this.Controls.Add(nume);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string data_tranz = "";

            culoare =culoareSelectata();
            optiuni = optiunii();
            if (string.IsNullOrEmpty(nume.Text))
                MessageBox.Show("Introduceti Numele.");
            else if (string.IsNullOrEmpty(prenume.Text))
                MessageBox.Show("Introduceti Prenumele.");
            else if (string.IsNullOrEmpty(comboBox1.Text))
                MessageBox.Show("Alegeti Firma.");
            else if (string.IsNullOrEmpty(model.Text))
                MessageBox.Show("Alegeti Modelul.");
            else if (string.IsNullOrEmpty(culoare))
                MessageBox.Show("Alegeti Culoarea.");
            else if (string.IsNullOrEmpty(Suma.Text))
                MessageBox.Show("Introduceti Pretul");
            else
            {
                TargMasini masina = new TargMasini(ID, nume.Text, prenume.Text, comboBox1.Text, model.Text, dateTimePicker1.Text, culoare, optiuni,data_tranz , Suma.Text);
                masina.culoare = culoareSelectata();
                masina.optiuni = optiunii();
                adminMasini.AddMasina(masina);
                ID = ID + 1;
            }
        }

        private void prenume_TextChanged(object sender, EventArgs e)
        {
            this.Controls.Add(prenume);
        }



        private void AfiseazaMasini()
        {
            TargMasini[] masina = adminMasini.GetMasini(out int nrMasini);

            lblsNume_Vanzator = new Label[nrMasini];
            lblsPrenume_Vanzator = new Label[nrMasini];
            lblsFirma = new Label[nrMasini];
            lblsModel=new Label[nrMasini];
            lblsCuloare = new Label[nrMasini];
            lblsOptiuni = new Label[nrMasini];
            lblsPret=new Label[nrMasini];
            lblsAnFab = new Label[nrMasini];
            int i = 0;
            foreach (TargMasini masinaa in masina)
            {
                //adaugare control de tip Label pentru vanzator
                lblsNume_Vanzator[i] = new Label();
                lblsNume_Vanzator[i].Width = 50;
                lblsNume_Vanzator[i].Text = masinaa.nume_vanzator;
                lblsNume_Vanzator[i].Left = 300;
                lblsNume_Vanzator[i].Top = (i + 1) * 25;
                this.Controls.Add(lblsNume_Vanzator[i]);

                //adaugare control de tip Label pentru cumpar
                lblsPrenume_Vanzator[i] = new Label();
                lblsPrenume_Vanzator[i].Width = 50;
                lblsPrenume_Vanzator[i].Text = masinaa.nume_cumparator;
                lblsPrenume_Vanzator[i].Left = 400;
                lblsPrenume_Vanzator[i].Top = (i + 1) * 25;
                this.Controls.Add(lblsPrenume_Vanzator[i]);

                //adaugare control de tip Label pentru firma
                lblsFirma[i] = new Label();
                lblsFirma[i].Width = 100;
                lblsFirma[i].Text = masinaa.firma;
                lblsFirma[i].Left = 500;
                lblsFirma[i].Top = (i + 1) * 25;
                this.Controls.Add(lblsFirma[i]);

                //model
                lblsModel[i] = new Label();
                lblsModel[i].Width = 100;
                lblsModel[i].Text = masinaa.model;
                lblsModel[i].Left = 600;
                lblsModel[i].Top = (i + 1) * 25;
                this.Controls.Add(lblsModel[i]);

                //culoare
                lblsCuloare[i] = new Label();
                lblsCuloare[i].Width = 100;
                lblsCuloare[i].Text = masinaa.culoare;
                lblsCuloare[i].Left = 700;
                lblsCuloare[i].Top = (i + 1) * 25;
                this.Controls.Add(lblsCuloare[i]);

                //pret
                lblsPret[i] = new Label();
                lblsPret[i].Width = 100;
                lblsPret[i].Text = masinaa.pret;
                lblsPret[i].Left = 800;
                lblsPret[i].Top = (i + 1) * 25;
                this.Controls.Add(lblsPret[i]);

                //optiuni
                lblsOptiuni[i] = new Label();
                lblsOptiuni[i].Width = 450;
                lblsOptiuni[i].Text = masinaa.optiuni;
                lblsOptiuni[i].Left = 900;
                lblsOptiuni[i].Top = (i + 1) * 25;
                this.Controls.Add(lblsOptiuni[i]);

                //an fab
                lblsAnFab[i] = new Label();
                lblsAnFab[i].Width = 450;
                lblsAnFab[i].Text = masinaa.an_fab;
                lblsAnFab[i].Left = 1350;
                lblsAnFab[i].Top = (i + 1) * 25;
                this.Controls.Add(lblsAnFab[i]);

                i++;
            }
        }

       /* private void afisare_Click(object sender, EventArgs e)
        {
            AfiseazaMasini();
        }*/

        private string optiunii()
        {
            optiuni = "";
            foreach (string s in checkedListBox1.CheckedItems)
            
                optiuni = optiuni + s;
               
            checkedListBox1.ClearSelected();
            if (optiuni.Length <= 1)
                optiuni = "Fara optiuni";
            return optiuni;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(Suma.Text, "[^0-9]"))
            {
                MessageBox.Show("Introduceti doar numere.");
                Suma.Text = Suma.Text.Remove(Suma.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
