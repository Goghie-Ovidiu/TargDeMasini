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
        public Cumparator()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminMasini = new AdministrareFisier(caleCompletaFisier);
            InitializeComponent();
            
            int counter = 0;
            string line;
            StreamReader file = new StreamReader(@"E:\\[Proiect] PIU\\TargDeMasini\\Masini.txt");
            while ((line = file.ReadLine()) != null)
            {
                //add the line to CheckedListBox, you need to pass the parameters "index" & "string"
                checkedListBox1.Items.Insert(counter, line);

                //increase the index
                counter++;
            }

            //close the file
            file.Close();
        }
        
        DataTable table=new DataTable();


        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=checkedListBox1.Items.Count-1; i>=0; i--)
            {
                if (checkedListBox1.GetItemChecked(i))
                    checkedListBox1.Items.Remove(checkedListBox1.Items[i]);
            }
           // string textfile=File.ReadAllText(checkedListBox1.SelectedItem.ToString());
           // textfile=textfile.Replace("\r\n", "\n");

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
