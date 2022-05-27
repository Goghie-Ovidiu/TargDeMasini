using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Masini.Enumerari;
namespace Masini
{
    public class TargMasini
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID = 0;
        private const int NUME_VANZATOR = 1;
        private const int NUME_CUMPARATOR = 2;
        private const int MODEL = 4;
        private const int FIRMA = 3;
        private const int AN_FAB = 5;
        private const int CULOARE = 6;
        private const int OPTIUNI = 7;
        private const int DATA_TRANZ = 8;
        private const int PRET = 9;


        public int idMasina { get; set; }
        public string nume_vanzator { get; set; }
        public string nume_cumparator { get; set; }
        public string model { get; set; }
        public string firma { get; set; }
        public string an_fab { get; set; }
        public string culoare { get; set; }
        public string optiuni { get; set; }
        public string data_tranz { get; set; }
        public string pret { get; set; }

        

        public TargMasini()
        {
            nume_vanzator = nume_cumparator = firma = string.Empty;
            model = an_fab = culoare = optiuni = string.Empty;
            data_tranz = pret = string.Empty;
        }

        
        public TargMasini(int idMasina, string nume_vanzator, string nume_cumparator, string firma, string model, string an_fab, string culoare, string optiuni, string data_tranz, string pret)
        {
            this.idMasina = idMasina;
            this.nume_vanzator = nume_vanzator;
            this.nume_cumparator = nume_cumparator;
            this.firma = firma;
            this.model = model;
            this.an_fab = an_fab;
            this.culoare = culoare;
            this.optiuni = optiuni;
            this.data_tranz = data_tranz;
            this.pret = pret;
        }

        
        public TargMasini(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            idMasina = Convert.ToInt32(dateFisier[ID]);
            nume_vanzator = dateFisier[NUME_VANZATOR];
            nume_cumparator = dateFisier[NUME_CUMPARATOR];        
            firma = dateFisier[FIRMA];
            model = dateFisier[MODEL];
            an_fab = dateFisier[AN_FAB];
            culoare = dateFisier[CULOARE];
            optiuni = dateFisier[OPTIUNI];
            data_tranz = dateFisier[DATA_TRANZ];
            pret = dateFisier[PRET];
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idMasina.ToString(),
                (nume_vanzator ?? " NECUNOSCUT "),
                (nume_cumparator ?? " NECUNOSCUT "),
                (firma ?? " NECUNOSCUT "),
                (model ?? " NECUNOSCUT "),
                (an_fab ?? " NECUNOSCUT "),
                (culoare ?? "NECUNOSCUT "),
                (optiuni ?? "NECUNOSCUT "),
                (data_tranz ?? "NECUNOSCUT "),
                (pret ?? " NECUNOSCUT "));

            return obiectPentruFisier;
        }

        public int GetIdMasina()
        {
            return idMasina;
        }

        public string GetNumeVanzator()
        {
            return nume_vanzator;
        }

        public string GetNumeCumparator()
        {
            return nume_cumparator;
        }
        public string GetModel()
        { return model; }
        public string GetFirma()
        {
            return firma;
        }
        public string GetAnFab()
        { return an_fab; }
        public string GetCuloare()
        { return culoare; }
        public string GetOptiuni()
        { return optiuni; }
        public string GetDataTranz()
        { return data_tranz; }
        public string GetPret()
        { return pret; }
        public void SetIdMasina(int idMasina)
        {
            this.idMasina = idMasina;
        }

    }
}
