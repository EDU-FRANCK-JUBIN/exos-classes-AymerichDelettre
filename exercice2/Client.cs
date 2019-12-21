using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.exercice2
{
    public class Client
    {
        private string m_CIN;
        private string m_nom;
        private string m_prenom;
        private string m_tel;

        public string CIN
        {
            get { return m_CIN; }
            set { m_CIN = value; }
        }

        public string Nom
        {
            get { return m_nom; }
            set { m_nom = value; }
        }
        public string Prenom
        {
            get { return m_prenom; }
            set { m_prenom = value; }
        }
        public string Tel
        {
            get { return m_tel; }
            set { m_tel = value; }
        }

        public Client(string cin, string nom, string prenom, string tel)
        {
            CIN = cin;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
        }

        public Client(string cin, string nom, string prenom)
        {
            CIN = cin;
            Nom = nom;
            Prenom = prenom;
        }

        public void Afficher()
        {
            Console.WriteLine("--------Client--------");
            Console.WriteLine("CIN : " + this.m_CIN);
            Console.WriteLine("Nom : " + this.m_nom);
            Console.WriteLine("Prenom : " + this.m_prenom);
            if (null != this.m_tel)
            {
                Console.WriteLine("Tel : " + this.m_tel);
            }
            Console.WriteLine("--------/Client--------\n");
        }
    }
}
