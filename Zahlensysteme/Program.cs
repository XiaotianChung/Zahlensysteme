using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlensysteme
{
    class Program
    {
        static void Main(string[] args)
        {
                string nochmal;
            do
            {
                int auswahl;
                
                Console.WriteLine("Zahlensysteme in vershiedene Systeme umwandeln:");
                Console.WriteLine("1:Dezimal zu Binär");
                Console.WriteLine("2:Binär zu Dizimal");
                Console.WriteLine("3:Dezimal zu Hexadizimal");
                Console.WriteLine("4:Hexadizimal zu Dizimal");

                auswahl = Convert.ToInt32(Console.ReadLine());

                if (auswahl == 1)
                {
                    Console.WriteLine("Dezimalzahl eingeben:");
                    int dez;
                    dez = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(dez + " in dezimal: " + Von10zu2(dez));

                }
                else if (auswahl == 2)
                {
                    Console.WriteLine("Binärzahl eingeben:");
                    string bin = Console.ReadLine();
                    Console.WriteLine(bin + " in dezimal: " + Von2zu10(bin));

                }
                else if (auswahl == 3)
                {
                    Console.WriteLine("Dezimalzahl eingeben:");
                    int dez;
                    dez = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(dez + " in hexadezimal: " + Von10zu16(dez));

                }
                else if (auswahl == 4)
                {
                    Console.WriteLine("Hexadizimal eingeben:");
                    string bin = Console.ReadLine();
                    Console.WriteLine(bin + " in dezimal: " + Von16zu10(bin));

                }
                else
                {
                    Console.WriteLine("Bitte wählen Sie 1 oder 2!");
                }
                Console.WriteLine("Neue Zahl umwandlen (j/n)");
                nochmal = Console.ReadLine();
            } while (nochmal== "j");
        }

        static string Von10zu2(int dez)
        {
            string bin = "";
            int Q, R, Z;
            Z = dez;
            Q = 1;
            while (Q != 0)
            {
                Q = Z / 2;
                R = Z % 2;
                bin += Convert.ToString(R);
                Z = Q;
            }
            return bin;
        }

        static string Umkehren(string bin)
        {
            string bu = "";
            for (int i = bin.Length - 1; i == 0; i--)
            {
                bu += bin[i];
            }
            return bu;
        }

        static double Von2zu10(string bin)
        {
            double Z=0, S, E;
            for (int i = 0; i < bin.Length; i++)
            {
                S = Convert.ToDouble(Convert.ToString(bin[i]));
                E = Convert.ToDouble(bin.Length - 1 - i);
                Z += S * Math.Pow(2, E);            
            }
            return Z;
        }


        static string Von10zu16(int dez)
        {
            string hexa = "";
            int Q, R, Z;
            Z = dez;
            Q = 1;
            while (Q != 0)
            {
                Q = Z / 16;
                R = Z % 16;
                hexa += ZahlZuBuchstaben(R);
                Z = Q;
            }
            return hexa;
        }

        static string ZahlZuBuchstaben(int Zahl)
        {
            if (Zahl == 10) return "A";
            else if (Zahl == 11) return "B";
            else if (Zahl == 12) return "C";
            else if (Zahl == 13) return "D";
            else if (Zahl == 14) return "E";
            else if (Zahl == 15) return "F";
            else return Convert.ToString(Zahl);

        }

        static double Von16zu10(string bin)
        {
            double Z = 0, S, E;
            for (int i = 0; i < bin.Length; i++)
            {
                S = Convert.ToDouble(BuchstabenZuZahl(Convert.ToString(bin[i])));
                
                E = Convert.ToDouble(bin.Length - 1 - i);
                Z += S * Math.Pow(16, E);
            }
            return Z;
        }
        static int BuchstabenZuZahl(string bin)
        {
            if (bin == "A") return 10;
            else if (bin == "B") return 11;
            else if (bin== "C") return 12;
            else if (bin == "D") return 13;
            else if (bin == "E") return 14;
            else if (bin== "F") return 15;
            else return Convert.ToInt32(bin);
        }


    }
}
