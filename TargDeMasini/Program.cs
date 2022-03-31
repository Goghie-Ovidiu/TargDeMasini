using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;
using Masini;
using Fisier;
namespace TargDeMasini
{
    public class Program
    {
        static void Main(string[] args)
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareFisier adminMasini = new AdministrareFisier(numeFisier);
            TargMasini MasinaNoua = new TargMasini();
            int nrMasini = 0;
            adminMasini.GetMasini(out nrMasini);

            string optiune;
            do
            {
                Console.WriteLine("\nC. Citire informatii despre masina de la tastatura");
                Console.WriteLine("L. Cautare dupa numele vanzatorului si a cumparatorului");
                Console.WriteLine("F. Afisare masini din fisier");
                Console.WriteLine("S. Salvare masina in fisier");
                Console.WriteLine("D. Citirea argumentelor din linia de comanda");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "C":
                        Console.WriteLine("");
                        MasinaNoua = CitireMasinaTastatura();
                        break;
                    case "F":
                        Console.WriteLine("");
                        TargMasini[] masini = adminMasini.GetMasini(out nrMasini);
                        AfisareMasini(masini, nrMasini);
                        break;

//Lab 3 cautarea dupa nume(pana acum)
                    case "L":
                        Console.WriteLine("");
                        Console.WriteLine("Introduceti numele vanzatorului");
                        string var_vanzator=Console.ReadLine();
                        Console.WriteLine("Introduceti numele cumparatorului");
                        string var_cumparator=Console.ReadLine();
                        Console.WriteLine(adminMasini.GetMasina(var_vanzator,var_cumparator));
                        break;
//Lab 3 salvarea datelor
                    case "S":
                        Console.WriteLine("");
                        int idMasina = nrMasini + 1;
                        MasinaNoua.SetIdMasina(idMasina);
                        adminMasini.AddMasina(MasinaNoua);
                        nrMasini = nrMasini + 1;
                        break;

//Lab 4 citirea argumentelor
                    case "D":
                        Console.WriteLine("");
                        if (args.Length == 0)
                            Console.Write("Linia de comanda nu contine argumente\n\n");
                        else
                        {                            
                           Console.WriteLine("Numarul de argumente este: {0}", args.Length);
                            foreach (string param in args)
                                Console.WriteLine(param);
                            switch (args[0])
                            {
                                case "about":
                                    Console.WriteLine("Targ de masini");
                                       break;
                                case "despre":
                                    Console.WriteLine("Masini de vanzare");
                                    break;
                                default:
                                    Console.WriteLine("Comanda necunoscuta");
                                    break;
                            }
                        }
                        
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");
            Console.ReadKey();
        }

        public static void AfisareMasina(TargMasini masina)
        {
            string infoMasina = string.Format("Masina cu id-ul #{0} are specificatiile: Nume Vanzator: {1}. Nume Cumparator: {2}. Firma: {3}. Model: {4}. An Fabricatie: {5}." +
                "Culoarea: {6}. Optiuni: {7}. Data tranzactiei: {8}. Pret: {9}.",
                   masina.GetIdMasina(),
                   masina.GetNumeVanzator() ?? " NECUNOSCUT ",
                   masina.GetNumeCumparator() ?? " NECUNOSCUT ",
                   masina.GetFirma() ?? "NECUNOSCUT ",
                   masina.GetModel() ?? " NECUNOSCUT ",
                   masina.GetAnFab() ?? "NECUNOSCUT ",
                   masina.GetCuloare() ?? "NECUNOSCUT ",
                   masina.GetOptiuni() ?? "NECUNOSCUT ",
                   masina.GetDataTranz() ?? "NECUNOSCUT ",
                   masina.GetPret() ?? " NECUNOSCUT ");

            Console.WriteLine(infoMasina);
        }

//Lab3 afisarea datelor din fisier
        public static void AfisareMasini(TargMasini[] masini, int nrMasini)
        {
            Console.WriteLine("Informatii:");
            for (int contor = 0; contor < nrMasini; contor++)
            {
                AfisareMasina(masini[contor]);
            }
        }


//Lab 3 citire de la tastatura
        public static TargMasini CitireMasinaTastatura()
        {
            Console.WriteLine("Introduceti numele vanzatorului ");
            string numevanzator = Console.ReadLine();

            Console.WriteLine("Introduceti nume cumparatorului ");
            string numecumparator = Console.ReadLine();

            Console.WriteLine("Introduceti firma masinei ");
            string firma = Console.ReadLine();

            Console.WriteLine("Introduceti modelul masinei");
            string model = Console.ReadLine();

            Console.WriteLine("Introduceti anul de fabricatie");
            string an_fab = Console.ReadLine();

            Console.WriteLine("Introduceti culoarea");
            string culoare = Console.ReadLine();

            Console.WriteLine("Introduceti optiuni");
            string optiuni = Console.ReadLine();

            Console.WriteLine("Introduceti data tranzactie");
            string data_tranz = Console.ReadLine();

            Console.WriteLine("Introduceti pretul");
            string pret = Console.ReadLine();

            TargMasini masina = new TargMasini(0, numevanzator, numecumparator, model, firma, an_fab, culoare, optiuni, data_tranz, pret);

            return masina;
        }
    }
}
