using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Patients
    {
        int N = 100; //Máximo pacientes
        Patient[] patients; //Cria um array de pacientes
        static int tpatient=0; //Pacientes no total, vai servir para os adicionar

        /// <summary>
        /// Construtor Patients
        /// </summary>
        public Patients()
        {
            patients = new Patient[N];
        }

        /// <summary>
        /// Construtor Patients
        /// </summary>
        /// <param name="size">tamanho a ser verificado</param>
        public Patients(int size)
        {
            if (size > N)
            {
                size = N;
                patients = new Patient[size];
            }
        }

        /// <summary>
        /// Propriedade total de pacientes
        /// </summary>
        public int Tpatient { get { return tpatient; } }

        /// <summary>
        /// Método que vai adicionar os pacientes
        /// </summary>
        /// <param name="patient">objecto em causa</param>
        public void AddP(Patient patient)
        {
            patients[tpatient] = patient;
            tpatient++;
        }

        /// <summary>
        /// Mostra os pacientes já existentes
        /// </summary>
        static public void MostraP()
        {
            //variaveis
            int i = 0;
            string line;
            string path = @"Patients.txt";

            // Ler o ficheiro e mostrar linha a linha
            System.IO.StreamReader file = new System.IO.StreamReader("path");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                i++;
            }

            file.Close();

        }
    }
}
