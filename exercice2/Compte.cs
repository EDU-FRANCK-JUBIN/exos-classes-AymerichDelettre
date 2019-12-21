using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exercice2
{
    public class Compte
    {
        private double m_solde;
        private Client m_client;
        private int m_code;

        public double Solde
        {
            get { return m_solde; }
        }

        public Client Client
        {
            get { return m_client; }
            set { m_client = value; }
        }

        public int Code
        {
            get { return m_code; }
        }

        public Compte(Client client)
        {
            m_solde = 0;
            Client = client;
            Program.baseCode++;
            m_code = Program.baseCode;
        }

        public void Crediter(double montant)
        {
            this.m_solde += montant;
        }

        public void Crediter(double montant, Compte compte)
        {
            this.m_solde += montant;
            compte.Debiter(montant);
        }

        public void Debiter(double montant)
        {
            this.m_solde -= montant;
        }

        public void Debiter(double montant, Compte compte)
        {
            this.m_solde -= montant;
            compte.Crediter(montant);
        }

        public void Resumer()
        {
            Console.WriteLine("--------Compte--------");
            Console.WriteLine("Numero de compte : " + this.Solde);
            Console.WriteLine("Solde : " + this.Solde);
            Console.WriteLine("Client : \n");
            this.Client.Afficher();
            Console.WriteLine("--------/Compte--------\n\n");
        }

        public void DisplayNbComptes()
        {
            Console.WriteLine(Program.baseCode.ToString() + " comptes ont été créés");
        }
    }
}
