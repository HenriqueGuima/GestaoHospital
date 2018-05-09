using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Patient
    {
        string nome;
        string cond;

        static int tpatient = 0;

        public enum Prioridades
        {
            prioridade1, prioridade2, prioridade3 
        }

        public Patient()
        {
            tpatient++;
            nome = "";
            cond = "";
        }

        public Patient(string nome, string cond)
        {
            tpatient++;
            this.nome = nome;
            this.cond = cond;
        }

        public string Nome { get { return nome; } set { nome = value; } }
        public string Cond { get {return cond; } set {cond = value; } }
        public int Tpatient{ get {return tpatient; } }

        static public void MostraP()
        {
            //variaveis
            int i = 0;
            string line;
            string path = @"c:\Users\HenriqueAlbertoBarro\source\repos\GestaoHospital\Hospital\Hospital\Patients.txt";

            // Ler o ficheiro e mostrar linha a linha
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                i++;
            }

            file.Close();

        }
    }

    
}
