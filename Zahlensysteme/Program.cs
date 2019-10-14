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
                auswahl = Convert.ToInt32(Console.ReadLine());

                if (auswahl == 1)
                {
                    Console.WriteLine("Dezimalzahl eingeben:");
                    int dez;
                    dez = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(dez + " in dezimal: " + Von2zu10(dez));
                    
                }
                else if (auswahl == 2)
                {
                    Console.WriteLine("Binärzahl eingeben:");
                    string bin = Console.ReadLine();
                    Console.WriteLine(bin+" in dezimal: "+Von2zu10(bin));

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


      }
}
