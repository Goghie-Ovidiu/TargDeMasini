using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfata
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
            string[] lines = File.ReadAllLines("MasiniVandute.txt");
            string[] values;
            for (int i = 0; i < lines.Length; i++)
            {

                values = lines[i].Split(';');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                    row[j] = values[j].Trim();
                dataGridView1.Rows.Add(row);

            }
            lines = File.ReadAllLines("NumeCUmparatori.txt");
            
            for (int i = 0; i < lines.Length; i++)
            {

                values = lines[i].Split(';');
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                    row[j] = values[j].Trim();
                dataGridView2.Rows.Add(row);

            }
        }

        private void Inapoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
