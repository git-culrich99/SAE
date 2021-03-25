using System;

namespace Aufgabe_Bruchrechner
{
    static class Bruchrechner
    {
        public static void addieren(int z1,int n1,int z2,int n2)
        {
            int zErg = 0;
            int nErg = 0;
            if(n1 == n2)
            {
                zErg = z1 + z2;
                nErg = n1;
            }
            else
            {
                zErg = (z1 * n2) + (z2 * n1);
                nErg = n1 * n2;
            }
            Console.WriteLine("Addieren: Zähler = {0} Nenner = {1}", zErg, nErg);
            Bruchrechner.berechneKommazahl(zErg, nErg);

        }
        public static void subtrahieren(int z1, int n1, int z2, int n2)
        {
            int zErg = 0;
            int nErg = 0;
            if (n1 == n2)
            {
                zErg = z1 - z2;
                nErg = n1;
            }
            else
            {
                zErg = (z1 * n2) - (z2 * n1);
                nErg = n1 * n2;
            }
            Console.WriteLine("Subtrahieren: Zähler = {0} Nenner = {1}", zErg, nErg);
            Bruchrechner.berechneKommazahl(zErg, nErg);

        }
        public static void multiplizieren(int z1, int n1, int z2, int n2)
        {
            int zErg = 0;
            int nErg = 0;
            zErg = z1 * z2;
            nErg = n1 * n2;
            Console.WriteLine("Multiplizieren: Zähler = {0} Nenner = {1}", zErg, nErg);
            Bruchrechner.berechneKommazahl(zErg, nErg);

        }
        public static void dividieren(int z1, int n1, int z2, int n2)
        {
            int zErg = 0;
            int nErg = 0;
            zErg = z1 * n2;
            nErg = n1 * z2;
            Console.WriteLine("Dividieren: Zähler = {0} Nenner = {1}", zErg, nErg);
            Bruchrechner.berechneKommazahl(zErg, nErg);

        }
        public static void berechneKommazahl(int z, int n)
        {
            double kommazahl,dZ,dN;
            dZ = Convert.ToDouble(z);
            dN = Convert.ToDouble(n);

            kommazahl = dZ / dN;
            Console.WriteLine("Kommazahl: {0}",kommazahl);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int z1, n1, z2, n2;
            
            Console.Write("z1: ");
            z1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("n1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("z2: ");
            z2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("n2: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            

            Bruchrechner.addieren(z1, n1, z2, n2);
            Bruchrechner.subtrahieren(z1, n1, z2, n2);
            Bruchrechner.multiplizieren(z1, n1, z2, n2);
            Bruchrechner.dividieren(z1, n1, z2, n2);

            Console.ReadKey();


        }
    }
}
