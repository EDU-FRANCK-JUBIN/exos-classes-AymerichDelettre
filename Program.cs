using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.exercice2;
using ConsoleApp1.exercice3;

namespace ConsoleApp1
{
    class Program
    {
        public static int baseCode = 0;

        static void Main(string[] args)
        {
            double a = 12;
            double b = 5;
            double c = 12.5;
            double d = 1253.68;

            Console.WriteLine("1.1 :");
            Console.Write(a+b*c-d);

            double moy = (1.0 + 5.5 + 9.9 + 2.8 + 9.6) / 5;
            Console.WriteLine("1.2 :");
            Console.WriteLine(moy);

            Console.WriteLine("Entrez le rayon:");
            double rayon = double.Parse(Console.ReadLine());
            double perimetre = 2 * Math.PI * rayon;
            Console.WriteLine("2.0 périmètre :");
            Console.WriteLine(perimetre);

            double surface = Math.PI * Math.Pow(rayon, 2);
            Console.WriteLine("2.0 surface :");
            Console.WriteLine(surface);

            Program.Exo2();
            Program.Exo3();

            Console.ReadLine();
        }

        public static void Exo2()
        {
            Client testClient = new Client("4564646446465", "testNom", "testPrenom");
            Compte testCompte1 = new Compte(testClient);
            Compte testCompte2 = new Compte(testClient);

            //add 5000 to c1
            testCompte1.Crediter(5000);
            //take 2000 in c1 and credit c2
            testCompte2.Crediter(2000, testCompte1);

            //c1 must be at 3k and c2 at 2k
            testCompte1.Resumer();
            testCompte2.Resumer();
        }

        public static void Exo3()
        {
            Console.WriteLine("---------EXO3--------");
            Article art1 = new Article();
            Article art2 = new Article("02", "du manger", 100, 10);
            Article art3 = new Article("03", "pizza");
            Article art4 = new Article(art2);

            art1.Afficher();
            art2.Afficher();
            art3.Afficher();
            art4.Afficher();

            Console.WriteLine("Prix art 4 (ref 02) avec TTC globale de 20% :");
            Console.WriteLine(art4.CalculerGlobalTVA_TTC());
        }
    }
}
