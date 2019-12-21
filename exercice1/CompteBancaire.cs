using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exercice1
{
    public class CompteBancaire
    {
        private string m_titulaire;
        private double m_solde;
        private string m_devise;

        private int m_NbComptes;

        public CompteBancaire(string titulaire, double solde, string devise)
        {
            this.Titulaire = titulaire;
            this.Solde = solde;
            this.Devise = devise;
        }

        public string Titulaire
        {
            get { return m_titulaire; }
            set { m_titulaire = value; }
        }

        public double Solde
        {
            get { return m_solde; }
            set { m_solde = value; }
        }

        public string Devise
        {
            get { return m_devise; }
            set { m_devise = value; }
        }

        public int NbComptes
        {
            get { return m_NbComptes; }
            set { m_NbComptes = value; }
        }

        public void Crediter(double montant)
        {
            Console.WriteLine("Le compte de " + this.m_titulaire + " va être créditer de " + montant);
            this.m_solde += montant;
            Console.WriteLine("Le solde de " + this.m_titulaire + " est maintenant de " + m_solde);
        }

        public void Debiter(double montant)
        {
            Console.WriteLine("Le compte de " + this.m_titulaire + " va être débiter de " + montant);
            this.m_solde -= montant;
            Console.WriteLine("Le solde de " + this.m_titulaire + " est maintenant de " + m_solde);
        }

        public string Decrire()
        {
            Console.WriteLine("Compte de " + this.m_titulaire + " :");
            Console.WriteLine("Solde : " + this.m_solde);
            Console.WriteLine("Devise : " + this.m_devise);

            return "Compte de " + this.m_titulaire + "\n Solde: " + this.m_solde + "\n Devise : " + this.m_devise;
        }
    }
}
