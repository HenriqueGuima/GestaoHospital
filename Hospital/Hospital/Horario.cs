using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Hospital
{
    class Horario : Employee
    {
        public string[,] MostraHorario()
        {
                int i = 0, j = 0;
                string line;
                string path = "Horario.txt";
                string[,] horario = new string[19, 8];

                System.IO.StreamReader file = new System.IO.StreamReader(path);

                while ((line = file.ReadLine()) != null)
                {
                    //string[] entradas = line.Split('\t'); //diferenciacao de tipos por \t
                    for (j = 0; (line = file.ReadLine()) != null; j++)
                    {
                        line = horario[i, j];
                        Console.WriteLine(line);
                    }
                    i++;
                }
                return horario;
        }
    }
}
