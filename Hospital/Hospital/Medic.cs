using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Medic : Employee 
    {
        public enum Especialidades
        {
            Pediatria, Cardiologia
        }

        public Especialidades Esp { get; set; }

        public Medic(int id, string nome, int idade, Especialidades esp)
        {
            base.ID = id;
            base.Nome = nome;
            base.Idade = idade;
            this.Esp = esp;
        }

        static public void MostraM()
        {
            //variaveis
            int i = 0;
            string line;
            string path = @"c:\Users\HenriqueAlbertoBarro\source\repos\GestaoHospital\Hospital\Hospital\Doctors.txt";

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
