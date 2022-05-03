using System;
using System.IO;
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
                        string var_vanzator=Console.ReadLine().ToUpper();
                        Console.WriteLine("Introduceti numele cumparatorului");
                        string var_cumparator=Console.ReadLine().ToUpper();
                        Console.WriteLine(adminMasini.GetMasina(var_vanzator,var_cumparator));
                        break;
                        //cautare dupa an fab
                    case "A":
                        Console.WriteLine("");
                        Console.WriteLine("Introduceti an fab");
                        string var_anfab = Console.ReadLine().ToUpper();
                        Console.WriteLine(adminMasini.GetMasinaAnFab(var_anfab));
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
            string numevanzator = Console.ReadLine().ToUpper();

            Console.WriteLine("Introduceti nume cumparatorului ");
            string numecumparator = Console.ReadLine().ToUpper();

            Console.WriteLine("Alegeti firma masinii ");
            Console.WriteLine("1.Volkswagen 2.BMW 3.Mercedes-Benz 4.Audi 5.Ford 6.Skoda 7.Opel 8.Renault 9.Nissan 10.Toyota 11.Hyundai 12.Land Rover 13.Mazda"+
                "14.Porsche 15.Fiat 16.Jeep 17.Mitsubishi 18.Suzuki 19.Seat 20.Citroën");
            int opp;
            int.TryParse(Console.ReadLine(), out opp);
            string fir = "";
            int c = 0;
            while(c==0)
            {
                if(opp==1)
                {
                    fir ="Volkswagen";
                    c = 1;
                }
                else if(opp==2)
                { fir = "BMW";c = 1; }
                else if(opp==3)
                { fir = "Mercedes-Benz";c = 1; }
                else if(opp==4)
                { fir = "Audi";c = 1; }
                else if (opp==5)
                { fir = "Ford";c = 1; }
                else if (opp==6)
                { fir = "Skoda";c= 1; }
                else if (opp ==7)
                { fir = "Opel";c=1; }
                else if(opp ==8)
                { fir = "Renault"; c = 1; }
                else if (opp==9)
                { fir = "Nissan";c = 1; }
                else if (opp==10)
                { fir = "Toyota";c = 1; }
                else
                { Console.WriteLine("Introduceti firma de la tastatura ");
                    fir=Console.ReadLine();
                    c = 1;
                }
                
            }
            Console.WriteLine(fir);
            string firma =fir.ToUpper();

            Console.WriteLine("Introduceti modelul masinei");
            string model = Console.ReadLine().ToUpper();

            Console.WriteLine("Introduceti anul de fabricatie");

            int an_fabricat;
            int.TryParse(Console.ReadLine(), out an_fabricat);
            int k=0;
            while(k==0)
            {
                if(an_fabricat == 0)
                {
                    Console.WriteLine("Anul contine litere. Introduceti anul:");
                    int.TryParse(Console.ReadLine(), out an_fabricat);
                    k = 0;
                }
                else
                {
                    k = 1;
                }
            }


            
            string an_fab = Convert.ToString(an_fabricat);

//Lab5

            Console.WriteLine("Alegeti culoarea ");
            Console.WriteLine("1 - Rosu \n" +
            "2 - Verde \n" +
            "3 - Negru \n"+
            "4 - Albastru\n" +
            "5 - Alb\n" +
            "6 - Portocaliu\n" +
            "7 - Gri\n");
            int optiune = Convert.ToInt32(Console.ReadLine());
            int l=0;
            while(l==0)
            {
                if (optiune == 1)
                { Console.WriteLine($"Ati ales culoare: {(culori)optiune}"); l = 2; }
                else if(optiune == 2)
                { Console.WriteLine($"Ati ales culoare: {(culori)optiune}"); l = 2; }
                else if(optiune==3)
                { Console.WriteLine($"Ati ales culoare: {(culori)optiune}"); l = 2; }
                else if (optiune == 4)
                { Console.WriteLine($"Ati ales culoare: {(culori)optiune}"); l = 2; }
                else if(optiune==5)
                { Console.WriteLine($"Ati ales culoare: {(culori)optiune}"); l = 2; }
                else if(optiune==6)
                { Console.WriteLine($"Ati ales culoare: {(culori)optiune}"); l = 2; }
                else if(optiune==7)
                { Console.WriteLine($"Ati ales culoare: {(culori)optiune}"); l = 2; }
                else
                {
                    Console.WriteLine("Optiune inexistenta");
                    optiune = Convert.ToInt32(Console.ReadLine());
                    l = 0;
                }
            }
            var s = (culori)optiune;
            string culoare = s.ToString();

            Console.WriteLine("Introduceti optiuni");


            Console.WriteLine("Are optiuni?");
            string optiunee = Convert.ToString(Console.ReadLine()).ToUpper();
            string op = "";
            string ss = "";
            if (optiunee == "DA")
            {
                Console.WriteLine("Aer conditionat?");
                op = Console.ReadLine().ToUpper();
                if (op == "DA")
                    ss = ss + Optiuni.Aer_Conditionat + " ";
                else if (op == "NU")
                    ss = ss;
                Console.WriteLine("Navigatie ");
                op = Console.ReadLine().ToUpper();
                if (op == "DA")
                    ss = ss + Optiuni.Navigatie + " ";
                else if (op == "NU")
                    ss = ss;
                Console.WriteLine("cutie automata ");
                op = Console.ReadLine().ToUpper();
                if (op == "DA")
                    ss = ss + Optiuni.Cutie_Automata + " ";
                else if (op == "NU")
                    ss = ss;
            }
            if (ss == string.Empty)
                ss = "Nu exista optiuni";
            string optiuni = ss;




            Console.WriteLine("Introduceti data tranzactie");
            
            string data_tranz="",aann="",lunaaa="",ziuaaa="";


            Console.WriteLine("anul:");
            int an = Convert.ToInt32(Console.ReadLine());
            string anul;
            int ok = 0;
            while (ok == 0)
            {
      
                    if (an>=an_fabricat)
                    {
                        anul = Convert.ToString(an);
                        aann = anul;
                        ok = 1;
                    }
                    else
                    {
                        Console.WriteLine("In acest an nu s-a fabricat masina");
                        an = Convert.ToInt32(Console.ReadLine());
                        ok = 0;
                    }
            }



            Console.WriteLine("luna:");
            int luna = Convert.ToInt32(Console.ReadLine());
            string lu;
            while (ok == 1)
            {
                if (luna > 0 && luna < 13)
                {
                    lu = Convert.ToString(luna);
                    lunaaa = lu;
                    ok = 2;
                }
                else
                {
                    Console.WriteLine("Nu exista luna");
                    luna = Convert.ToInt32(Console.ReadLine());
                    ok = 1;
                }
            }

            Console.WriteLine("ziua:");
            int ziua =Convert.ToInt32(Console.ReadLine());
            string zz;
            
            while(ok==2)
            {
                if (luna == 1 || luna == 3 || luna == 5 || luna == 7 || luna == 8 || luna == 10 || luna == 12)
                {
                    if (ziua > 0 && ziua < 32)
                    {
                        zz = Convert.ToString(ziua);
                        ziuaaa = zz;
                        ok = 3;
                    }
                    else
                    {
                        Console.WriteLine("Nu exista aceasta zi. Introduceti ziua");
                        ziua = Convert.ToInt32(Console.ReadLine());
                        ok = 2;

                    }
                }
                else if (luna == 2)
                {
                    if (ziua > 0 && ziua < 29)
                    {
                        zz = Convert.ToString(ziua);
                        ziuaaa= zz;
                        ok = 3;
                    }
                    else
                    {
                        Console.WriteLine("Nu exista aceasta zi. Introduceti ziua");
                        ziua = Convert.ToInt32(Console.ReadLine());
                        ok = 2;

                    }
                }
                else
                {
                    if (ziua > 0 && ziua < 31)
                    {
                        zz = Convert.ToString(ziua);
                        ziuaaa = zz;
                        ok = 3;
                    }
                    else
                    {
                        Console.WriteLine("Nu exista aceasta zi. Introduceti ziua");
                        ziua = Convert.ToInt32(Console.ReadLine());
                        ok = 2;

                    }
                }

            }

            data_tranz = ziuaaa +"/"+ lunaaa +"/"+ aann;
            


            Console.WriteLine("Introduceti pretul");
            string pret = Console.ReadLine().ToUpper();

            TargMasini masina = new TargMasini(0, numevanzator, numecumparator, model, firma, an_fab, culoare, optiuni, data_tranz, pret);

            return masina;
        }

        public enum culori
        {
            Rosu = 1,
            Verde = 2,
            Negru = 3,
            Albastru=4,
            Alb=5,
            Portocaliu=6,
            Gri=7

        };

        [Flags]
        public enum Optiuni
        {
            Aer_Conditionat,
            Navigatie,
            Cutie_Automata
        }
        
    }
}
