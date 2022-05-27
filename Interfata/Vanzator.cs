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
using Microsoft.VisualBasic;

namespace Interfata
{
    public partial class Vanzator : Form
    {
        AdministrareFisier adminMasini = new AdministrareFisier("Masini.txt");

        public int ID;

        private ComboBox model;
        string culoare ="";
        string optiuni = "";

        private ComboBox vol;
        private ComboBox bmw;
        private ComboBox audi;
        private ComboBox mercedes;
        
        public Vanzator()
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

            if (firma.SelectedIndex == firma.Items.IndexOf("Volkswagen"))
            {
                VWLogo.Visible = true;

                vol=new ComboBox();
                vol.Width = 121;
                vol.Items.Add("Arteon"); vol.Items.Add("Arteon Shooting"); vol.Items.Add("Beetle"); vol.Items.Add("Fox"); vol.Items.Add("Sharan");
                vol.Items.Add("Golf"); vol.Items.Add("Jetta"); vol.Items.Add("Passat"); vol.Items.Add("Phaeton"); vol.Items.Add("Polo"); vol.Items.Add("Tiguan");
                vol.Items.Add("Touareg"); vol.Items.Add("Passat CC");
                vol.Left = 343;
                vol.Top = 68;
                this.Controls.Add(vol);
                this.Controls.Add(firma);
                model = vol;
            }
            else
            {
                if(vol!=null)
                { vol.Left = 5500; vol.Top=5120; VWLogo.Visible = false;}
            }

            if (firma.SelectedIndex == firma.Items.IndexOf("BMW"))
            {
                BMWLogo.Visible = true;
                bmw = new ComboBox();
                bmw.Width = 121;
                bmw.Items.Add("3 Series Sedan"); bmw.Items.Add("5 Series Sedan"); bmw.Items.Add("7 Series Sedan");bmw.Items.Add("M3 Sedan"); bmw.Items.Add("M5 Sedan");
                bmw.Items.Add("i4"); bmw.Items.Add("4 Series Coupe"); bmw.Items.Add("8 Series Coupe"); bmw.Items.Add("M4 Coupe"); bmw.Items.Add("X1");
                bmw.Items.Add("X2");bmw.Items.Add("X3"); bmw.Items.Add("X3 M"); bmw.Items.Add("X4"); bmw.Items.Add("X4 M"); bmw.Items.Add("X5 M"); bmw.Items.Add("X5");
                bmw.Items.Add("X6"); bmw.Items.Add("X6 M"); bmw.Items.Add("X7"); bmw.Items.Add("iX");
                bmw.Left = 343;
                bmw.Top = 68;
                this.Controls.Add(bmw);
                this.Controls.Add(firma);
                model = bmw;
            }
            else
            {   if (bmw != null)
                {
                    bmw.Left = 5553;
                    bmw.Top = 5120;
                    BMWLogo.Visible = false;
                }
                
            }

            if(firma.SelectedIndex==firma.Items.IndexOf("Mercedes-Benz"))
            {
                MBLogo.Visible = true;
                mercedes=new ComboBox();
                mercedes.Width = 121;
                mercedes.Items.Add("GLA SUV"); mercedes.Items.Add("GLB SUV"); mercedes.Items.Add("GLC SUV"); mercedes.Items.Add("GLE SUV");
                mercedes.Items.Add("GLE Coupe"); mercedes.Items.Add("GLS SUV"); mercedes.Items.Add("Maybach GLS SUV"); mercedes.Items.Add("G-Class SUV");
                mercedes.Items.Add("A-Class Sedan"); mercedes.Items.Add("C-Class Sedan"); mercedes.Items.Add("E-Class Sedan"); mercedes.Items.Add("S-Class Sedan");
                mercedes.Items.Add("Maybach S-Class");mercedes.Items.Add("C-Class Cabriolet"); mercedes.Items.Add("E-Class Cabriolet");mercedes.Items.Add("AMG GT");
                mercedes.Left = 343;
                mercedes.Top = 68;
                this.Controls.Add(mercedes);
                this.Controls.Add(firma);
                model = mercedes;
            }
            else
                if(mercedes != null)
            { mercedes.Left = 5555; MBLogo.Visible = false; }

            if (firma.SelectedIndex == firma.Items.IndexOf("Audi"))
            {
               AudiLogo.Visible = true;
                audi = new ComboBox();
                audi.Width = 121;
                audi.Items.Add("A1");audi.Items.Add("A3");audi.Items.Add("S3 Limousine");audi.Items.Add("RS 3 Sportback"); audi.Items.Add("A4");
                audi.Items.Add("S4 Limousine");audi.Items.Add("RS 4 Avant"); audi.Items.Add("A5"); audi.Items.Add("S5 Coupé");audi.Items.Add("S5 Sportback"); 
                audi.Items.Add("RS 5Sportback"); audi.Items.Add("A6"); audi.Items.Add("A6 allroad quattro");audi.Items.Add("S6 Limousine");
                audi.Items.Add("RS 6 Avant");audi.Items.Add("A7 Sportback");audi.Items.Add("S7 Sportback");audi.Items.Add("RS 7 Sportback");
                audi.Items.Add("A8");audi.Items.Add("S8");audi.Items.Add("Q2");audi.Items.Add("Q3");audi.Items.Add("RS Q3");audi.Items.Add("TT RS");
                audi.Items.Add("R8	Spyder");
                audi.Left = 343;
                audi.Top = 68;
                this.Controls.Add(audi);
                this.Controls.Add(firma);
                model = audi;

            }
            else
            {
                if (audi!=null)
                {
                    audi.Left = 5453;
                    audi.Top = 5120;
                    AudiLogo.Visible = false;
                }
            }          
        }

        private string culoareSelectata()
        {
            
            if (culoareRosu.Checked)
               culoare="Rosu";
            if (culoareAlbastru.Checked)
                culoare = "Albastru"; 
            if (culoareVerde.Checked)
                culoare = "Verde"; 
            if (culoareNegru.Checked)
                culoare = "Negru"; 
            if (culoareAlb.Checked)
                culoare = "Alb";
            if (culoareGri.Checked)
                culoare = "Gri";
            if (culoareGalben.Checked)
                culoare = "Galben";
            if (culoarePortocaliu.Checked)
                culoare = "Portocaliu";
           // if (AltaCuloare.Checked)
            //    culoare=Interaction.InputBox("Introduceti culoarea dorita.", " ");
            return culoare;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Controls.Add(nume);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int ok = 0;
            culoare =culoareSelectata();
            optiuni = optiunii();
            if (string.IsNullOrEmpty(nume.Text))
                MessageBox.Show("Introduceti Numele.");
            else if (string.IsNullOrEmpty(prenume.Text))
                MessageBox.Show("Introduceti Prenumele.");
            else if (string.IsNullOrEmpty(firma.Text))
                MessageBox.Show("Alegeti Firma.");
            else if (string.IsNullOrEmpty(model.Text))
                MessageBox.Show("Alegeti Modelul.");
            else if (string.IsNullOrEmpty(culoare))
                MessageBox.Show("Alegeti Culoarea.");
            else if (string.IsNullOrEmpty(Suma.Text))
                MessageBox.Show("Introduceti Pretul.");
            else if (string.IsNullOrEmpty(telefon.Text))
                MessageBox.Show("Introduceti numarul de telefon.");
            else if (telefon.Text.Length < 9)
                MessageBox.Show("Numarul trebuie sa contina 9 sau 10 cifre.");
            else if (telefon.Text.Length > 10)
                MessageBox.Show("Numarul trebuie sa contina 9 sau 10 cifre.");
            else if(string.IsNullOrEmpty(Prefix.Text))
                MessageBox.Show("Introduceti prefixul numarului de telefon.");
            else if(Prefix.Text.Length > 3)
                MessageBox.Show("Prefixul trebuie sa contina 2 sau 3 cifre.");
            else if(Prefix.Text.Length <2)
                MessageBox.Show("Prefixul trebuie sa contina 2 sau 3 cifre.");
            else
            {
                int nrMasini;
                adminMasini.GetMasini(out nrMasini);
                ID = nrMasini + 1;
                
                TargMasini masina = new TargMasini(ID, nume.Text, prenume.Text, firma.Text, model.Text, AnFab.Text, culoare, optiuni, Suma.Text, telefon.Text);
                masina.culoare = culoareSelectata();
                masina.optiuni = optiunii();
                adminMasini.AddMasina(masina);
                telefon.Text =Prefix.Text + telefon.Text;
                telefon.Clear();
                ok = 1;
            }
            if(ok==1)
            {
                nume.Clear();
                prenume.Clear();
                Suma.Clear();
                culoareRosu.Checked = false;
                culoareAlbastru.Checked = false;
                culoareVerde.Checked = false;
                culoareNegru.Checked = false;
                culoareAlb.Checked = false;
                culoareGri.Checked = false;
                for(int i = 0; i < OptiuniList.Items.Count; i++)
                    OptiuniList.SetItemCheckState(i, CheckState.Unchecked);
                model.ResetText();
                telefon.Clear();
                Prefix.Clear();
            }
        }

        private void prenume_TextChanged(object sender, EventArgs e)
        {
            this.Controls.Add(prenume);
        }


        private string optiunii()
        {
            optiuni = "";
            foreach (string s in OptiuniList.CheckedItems)
                optiuni = optiuni + s;
               
            OptiuniList.ClearSelected();
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

        private void telefon_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(telefon.Text, "[^0-9]"))
            {
                MessageBox.Show("Introduceti doar numere.");
                telefon.Text = telefon.Text.Remove(telefon.Text.Length - 1);
            }

        }

        private void Prefix_TextChanged(object sender, EventArgs e)
        {
            this.Controls.Add(Prefix);
        }

        private void VWLogo_Click(object sender, EventArgs e)
        {
            this.Controls.Add(VWLogo);
        }

        private void AltaCuloare_CheckedChanged(object sender, EventArgs e)
        {
            culoare = Interaction.InputBox("Introduceti culoarea dorita.", " ");
        }
    }
}
