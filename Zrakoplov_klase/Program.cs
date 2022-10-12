using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zrakoplov_klase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
            Zrakoplov PC21 = new Zrakoplov("Pilatus", 1200, 1330);

            Console.WriteLine(x380.ToString() + "\r\n");
            Console.WriteLine(C162.ToString() + "\r\n");
            Console.WriteLine(PC21.ToString() + "\r\n");
            Console.ReadKey();
        }

        class Zrakoplov
        {
            string naziv;
            double snagaMotora;
            int dosegLeta;

            public string Naziv { get => naziv; set => naziv = value; }
            public double SnagaMotora { get => snagaMotora; set => snagaMotora = value; }
            public int DosegLeta { get => dosegLeta; set => dosegLeta = value; }

            public override string ToString()
            {
                string ispis = "Naziv: " + Naziv
                    + "\r\nSnaga motora: " + SnagaMotora
                    + " kW\r\nDoseg leta: " + DosegLeta + " km";
                return ispis;
            }

            public Zrakoplov()
            {

            }
            public Zrakoplov(string naziv, double snagaMotora, int dosegLeta)
            {
                this.naziv = naziv;
                this.snagaMotora=snagaMotora;
                this.dosegLeta=dosegLeta;
            }

        }

    }
}
