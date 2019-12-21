using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exercice3
{
    public class Article
    {
        private string m_reference;
        private string m_designation;
        private double m_prixHT;
        private double m_tauxTVA;

        public static double TauxGlobalTVA = 20;

        public string Reference
        {
            get { return m_reference; }
            set { m_reference = value; }
        }

        public string Designation
        {
            get { return m_designation; }
            set { m_designation = value; }
        }

        public double PrixHT
        {
            get { return m_prixHT; }
            set { m_prixHT = value; }
        }

        public double TauxTVA
        {
            get { return m_tauxTVA; }
            set { m_tauxTVA = value; }
        }

        public Article()
        {

        }

        public Article(string reference, string designation, double prixHT, double tauxTVA)
        {
            Reference = reference;
            Designation = designation;
            PrixHT = prixHT;
            TauxTVA = tauxTVA;
        }

        public Article(string reference, string designation)
        {
            Reference = reference;
            Designation = designation;
        }

        /// <summary>
        /// Constructeur de copie
        /// </summary>
        /// <param name="prevArticle"></param>
        public Article(Article prevArticle)
        {
            Reference = prevArticle.Reference;
            Designation = prevArticle.Designation;
            PrixHT = prevArticle.PrixHT;
            TauxTVA = prevArticle.TauxTVA;
        }

        /// <summary>
        /// Calcul avec le taux tva de l'objet
        /// </summary>
        /// <returns></returns>
        public double CalculerPrixTTC()
        {
            return PrixHT + (PrixHT * (TauxTVA / 100));
        }

        /// <summary>
        /// Calcul du prix TTC avec la TVA Globale
        /// </summary>
        /// <returns></returns>
        public double CalculerGlobalTVA_TTC()
        {
            return PrixHT + (PrixHT * (TauxGlobalTVA / 100));
        }

        public void Afficher()
        {
            Console.WriteLine("--------Atticle--------");
            Console.WriteLine("Reference : " + this.Reference);
            Console.WriteLine("Designation : " + this.Designation);
            Console.WriteLine("PrixHT : " + this.PrixHT);
            Console.WriteLine("Taux TVA : " + this.TauxTVA);
            Console.WriteLine("PrixTTC : " + this.CalculerPrixTTC());
            Console.WriteLine("--------/Atticle--------\n\n");
        }
    }
}
