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

        private const int NR_MAX_MASINI = 50;
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
        public string GetMasina(string nume_vanzator, string nume_cumparator)
        {
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while((linieFisier = streamReader.ReadLine()) != null)
                {
                    string[] linie=linieFisier.Split(';');
                    if(linie[1] == nume_vanzator && linie[2] == nume_cumparator)
                    {
                        string result = string.Format("{0} {1} {2}", linie[0],linie[1],linie[2]);
                        return result;
                    }
                    
                }
            }
            return string.Format("{0} {1} ", nume_vanzator, nume_cumparator);
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

            return masini;
        }

    }
}
