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
           Cardiologia, Neurologia, Ortopedia, Dermatologia, Ginecologia, Psicologia, Pneumologia, Geral
        }

        
        public Especialidades Esp { get; set; }

        public Medic(string nome, Especialidades esp, DateTime horario)
        {
            //base.ID = id;
            base.Nome = nome;
            //base.Idade = idade;
            this.Esp = esp;
            //this.Horario = horario;
        }

        static public void MostraM()
        {
            //variaveis
            int i = 0;
            string line;
            string path = "Doctors.txt";

            // Ler o ficheiro e mostrar linha a linha
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                i++;
            }

            file.Close();

        }

        static public void MostraCard()
        {
            int i = 0;
            string line;
            string path = "Doctors.txt";

            System.IO.StreamReader file = new System.IO.StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("Cardiologista"))
                {
                    System.Console.WriteLine(line);
                    i++;
                }
                
            }

            file.Close();
        }

        static public void MostraPsicologo()
        {
            int i = 0;
            string line;
            string path = "Doctors.txt";

            System.IO.StreamReader file = new System.IO.StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("Psicologo"))
                {
                    System.Console.WriteLine(line);
                    i++;
                }

            }

            file.Close();
        }

        static public void MostraGeral()
        {
            int i = 0;
            string line;
            string path = "Doctors.txt";

            System.IO.StreamReader file = new System.IO.StreamReader(path);

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("Medicina Geral"))
                {
                    System.Console.WriteLine(line);
                    i++;
                }

            }

            file.Close();
        }

        static public string EscolheMedico (string input)
        {
            if (input.Contains("Armindo Ponce"))
            {
                if (Disponivel())
                {
                    return "Purificacão Armindo Ponce Maurício Pardal";
                }
            }
            else if (input.Contains("Fonseca Belarmina"))
            {
                if (Disponivel())
                {
                    return "Fosceca Belarmina Iria Rebouta Rios";
                }
            }

            return input;
        }


        static public bool Disponivel()
        {
            DateTime hora = new DateTime();
            hora.AddHours(1);


            if (DataH() > DateTime.Now && DataH() < hora)
            {
                return true;
            }
            return false;
        }

        static public DateTime DataH()
        {
            DateTime data = DateTime.Now;

            return data;
        }
        


    }
}
