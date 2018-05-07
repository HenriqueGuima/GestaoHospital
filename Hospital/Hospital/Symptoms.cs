using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Symptoms
    {
        int N = 5; //Máximo sintomas
        Symptom[] symptoms; //Cria um array de sintomas
        static int tsin = 0; //sintomas no total, vai servir para os adicionar

        /// <summary>
        /// Construtor Patients
        /// </summary>
        public Symptoms()
        {
            symptoms = new Symptom[N];
        }

        /// <summary>
        /// Construtor Patients
        /// </summary>
        /// <param name="size">tamanho a ser verificado</param>
        public Symptoms(int size)
        {
            if (size > N)
            {
                size = N;
                symptoms = new Symptom[size];
            }
        }

        /// <summary>
        /// Propriedade total de sintomas
        /// </summary>
        public int Tsin { get { return tsin; } }

        /// <summary>
        /// Método que vai adicionar os sintomas
        /// </summary>
        /// <param name="patient">objecto em causa</param>
        public void AddS(Symptom symptom)
        {
            symptoms[tsin] = symptom;
            tsin++;
        }

        /// <summary>
        /// Mostra os pacientes já existentes
        /// </summary>
        static public void MostraS()
        {
            //variaveis
            int i = 0;
            string line;
            string path = @"Symptoms.txt";

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
