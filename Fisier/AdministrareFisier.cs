using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Masini;
namespace Fisier
{
    public class AdministrareFisier
    {

        private const int NR_MAX_MASINI = 150;
        private string numeFisier;

        public AdministrareFisier(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }


//Lab3 salvarea datelor
        public void AddMasina(TargMasini masini)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(masini.ConversieLaSir_PentruFisier());
            }
        }

//Lab 3 cautarea dupa nume
        public string GetMasina(string nume_cumparator, string prenume_cumparator)
        {
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while((linieFisier = streamReader.ReadLine()) != null)
                {
                    string[] linie=linieFisier.Split(';');
                    if(linie[1] == nume_cumparator && linie[2] == prenume_cumparator)
                    {
                        string result = string.Format("{0} {1} {2}", linie[0],linie[1],linie[2]);
                        return result;
                    }
                    
                }
            }
            return string.Format("{0} {1} ", nume_cumparator, prenume_cumparator);
        }

        //cautare an fab
        public string GetMasinaAnFab(string an_fab)
        {
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    string[] linie = linieFisier.Split(';');
                    if (linie[5] == an_fab)
                    {
                        string result = string.Format("{0} {1} {2} {3}", linie[0], linie[1], linie[2], linie[5]);
                        return result;
                    }

                }
            }
            return string.Format("{0} {1} ", an_fab);
        }



        public TargMasini[] GetMasini(out int nrMasini)
        {
            TargMasini[] masini = new TargMasini[NR_MAX_MASINI];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrMasini = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    masini[nrMasini++] = new TargMasini(linieFisier);
                }
            }
            Array.Resize(ref masini, nrMasini);
            return masini;
        }

    }
}
