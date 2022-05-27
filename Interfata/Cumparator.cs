using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Masini;
using Fisier;
using static Masini.Enumerari.Culori;
using static Masini.Enumerari;
using System.Configuration;
using System.IO;

namespace Interfata
{
    public partial class Cumparator : Form
    {
        AdministrareFisier adminMasini = new AdministrareFisier("Masini.txt");
        string  nam="";
        public Cumparator()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminMasini = new AdministrareFisier(caleCompletaFisier);
            InitializeComponent();

            Size = new Size(250, 80);
            Location = new Point(300, 180);
            string[] lines=File.ReadAllLines(caleCompletaFisier);
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {

                    values = lines[i].Split(';');
                    string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                        row[j] = values[j].Trim();
                    dataGridView1.Rows.Add(row);

            }
          

        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Controls.Add(CautareNume);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Controls.Add(CautarePrenume);
        }

        //cumparare || stergere
        private void button1_Click(object sender, EventArgs e)
        {
            
            // string textfile=File.ReadAllText(checkedListBox1.SelectedItem.ToString());
            // textfile=textfile.Replace("\r\n", "\n");
            //  if(this.dataGridView1.SelectedRows.Count>0)
            //    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);


            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminMasini = new AdministrareFisier(caleCompletaFisier);
            //string[] lines = File.ReadAllLines(caleCompletaFisier);

            // foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            // dataGridView1.Rows.RemoveAt(item.Index);
            if (string.IsNullOrEmpty(NumeCumparator.Text))
                MessageBox.Show("Introduceti numele");
            else if (string.IsNullOrEmpty(PrenumeCumparator.Text))
                MessageBox.Show("Introduceti prenumele");
            else
            {
                //adaugarrre grid 2
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    object[] rowData = new object[row.Cells.Count];
                    for (int i = 0; i < rowData.Length; ++i)
                    {

                        rowData[i] = row.Cells[i].Value;
                    }
                    this.dataGridView2.Rows.Add(rowData);

                }
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowindex);

                List<string> list = new List<string>(File.ReadAllLines(caleCompletaFisier));
                list.RemoveAt(rowindex);
                File.WriteAllLines(caleCompletaFisier, list);

                //this.Controls.Add(NumeCumparator);
                //nam = Convert.ToString(NumeCumparator);
                using (TextWriter tw = new StreamWriter("MasiniVandute.txt", true))
                {
                    for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                    {



                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {


                            tw.Write($"{dataGridView2.Rows[i].Cells[j].Value.ToString()}");

                            if (j != dataGridView2.Columns.Count)
                            {
                                tw.Write(";");

                            }

                        }

                        File.Copy("MasiniVandute.txt", "MasiniCumparate.txt", true);
                        StreamWriter sw = new StreamWriter("NumeCUmparatori.txt", true);
                        sw.WriteLine();
                        sw.Write(NumeCumparator.Text);
                        sw.Write(";");
                        sw.Write(PrenumeCumparator.Text); sw.Write(";");
                        sw.Close();
                        tw.WriteLine();


                    }
                }

                NumeCumparator.Clear();
                PrenumeCumparator.Clear();
            }

        }
        //iesire
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //cautare nume
        private void button3_Click(object sender, EventArgs e)
        {
            Cumpara.Visible = true;
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminMasini = new AdministrareFisier(caleCompletaFisier);
            string[] lines = File.ReadAllLines(caleCompletaFisier);
            string[] values;

            dataGridView1.Rows.Clear();
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].Split(';');
                if (values[1] == CautareNume.Text && values[2] == CautarePrenume.Text)
                {

                    string[] row = new string[values.Length];
                    for (int j = 0; j < values.Length; j++)
                        row[j] = values[j].Trim();
                    dataGridView1.Rows.Add(row);
                }

            }
            lblnumevanzator.Visible = false;
            lblprenumevanzator.Visible = false;
            CautareNume.Visible = false;
            CautarePrenume.Visible = false;
            Cauta.Visible = false;
        }

        private void AfisareMasini_Click(object sender, EventArgs e)
        {
           
            dataGridView1.Visible = true;
            Cumpara.Visible = true;
            dataGridView1.Rows.Clear ();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminMasini = new AdministrareFisier(caleCompletaFisier);
            string[] lines = File.ReadAllLines(caleCompletaFisier);
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {

                values = lines[i].Split(';');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                    row[j] = values[j].Trim();
                dataGridView1.Rows.Add(row);

            }
        }

        private void Cautare_Click(object sender, EventArgs e)
        {
            groupcautare.Visible = true;
            Inapoi.Location = new Point(12, 367);
            
            

        }

        private void cautaredupanume_Click(object sender, EventArgs e)
        {
            lblnumevanzator.Visible = true;
            lblprenumevanzator.Visible=true;
            CautareNume.Visible = true;
            CautarePrenume.Visible = true;
            Cauta.Visible = true;

            lblFirma.Visible = false;
            firmacautare.Visible = false;
            lblPret.Visible = false;
            textPret.Visible = false;
            cautpret.Visible = false;
            cautafirma.Visible = false;
        }

        private void cautarefirma_Click(object sender, EventArgs e)
        {
            lblnumevanzator.Visible = false;
            lblprenumevanzator.Visible = false;
            CautareNume.Visible = false;
            CautarePrenume.Visible = false;
            Cauta.Visible = false;
            lblPret.Visible = false;
            textPret.Visible = false;
            cautpret.Visible = false;

            lblFirma.Visible = true;
            firmacautare.Visible = true;
            cautafirma.Visible = true;

        }

        //cautare firma
        private void cautafirma_Click(object sender, EventArgs e)
        {
            Cumpara.Visible = true;
            dataGridView1.Visible = true;
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminMasini = new AdministrareFisier(caleCompletaFisier);
            string[] lines = File.ReadAllLines(caleCompletaFisier);
            string[] values;

            dataGridView1.Rows.Clear();
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].Split(';');
                if (values[3] == firmacautare.Text)
                {

                    string[] row = new string[values.Length];
                    for (int j = 0; j < values.Length; j++)
                        row[j] = values[j].Trim();
                    dataGridView1.Rows.Add(row);
                }

            }

            lblFirma.Visible = false;
            firmacautare.Visible = false;
            cautafirma.Visible = false;
        }

        private void CautarePret_Click(object sender, EventArgs e)
        {
            lblPret.Visible = true;
            textPret.Visible=true;
            cautpret.Visible=true;
            lblFirma.Visible = false;
            firmacautare.Visible = false;
            cautafirma.Visible = false;
            lblnumevanzator.Visible = false;
            lblprenumevanzator.Visible = false;
            CautareNume.Visible = false;
            CautarePrenume.Visible = false;
            Cauta.Visible = false;
        }

        private void cautpret_Click(object sender, EventArgs e)
        {
            Cumpara.Visible = true;
            dataGridView1.Visible = true;
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminMasini = new AdministrareFisier(caleCompletaFisier);
            string[] lines = File.ReadAllLines(caleCompletaFisier);
            string[] values;
            int nr=Convert.ToInt32(textPret.Text);
            int pr = 0;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].Split(';');
                pr=Convert.ToInt32(values[8]);
                if (pr <= nr)
                {

                    string[] row = new string[values.Length];
                    for (int j = 0; j < values.Length; j++)
                        row[j] = values[j].Trim();
                    dataGridView1.Rows.Add(row);
                }

            }

            lblPret.Visible = false;
            textPret.Visible = false;
            cautpret.Visible = false;
        }

        private void NumeCumparator_TextChanged(object sender, EventArgs e)
        {
            this.Controls.Add(NumeCumparator);
         
        }

        private void PrenumeCumparator_TextChanged(object sender, EventArgs e)
        {
            this.Controls.Add(PrenumeCumparator);
        }
    }
}
