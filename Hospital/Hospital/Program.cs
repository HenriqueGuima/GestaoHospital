using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu_Principal menu = new Menu_Principal();
            ////Dados pré-definidos
            //Employee docente = new Medic (50, "Rodrigo", 62, Medic.Especialidades.Cardiologia);
            //Console.WriteLine(docente.ID);
            //Console.WriteLine(docente.Nome);
            //Console.WriteLine(docente.Idade);
            ////Console.WriteLine(); //Fazer com que apresente enfermaria na mesma sem ter que implementar de novo

            //Employee docente1 = new Medic(0, " ", 0, Medic.Especialidades.Pediatria); //Tentar fazer com que dê para ser o utilizador a inserir

            //Console.WriteLine("\nQuantos docentes a registar?  ");
            //int nDocentes = int.Parse(Console.ReadLine());

            ////Registar num ficheiro os dados

            //for (int i = 0; i < nDocentes; i++)
            //{
            //    Employee docente2 = docente1;
            //    Console.WriteLine("\n\nInserir ID");
            //    docente2.ID = int.Parse(Console.ReadLine());
            //    Console.WriteLine("\n\nInserir idade");
            //    docente2.Idade = int.Parse(Console.ReadLine());
            //    Console.WriteLine("\n\nInserir Nome");
            //    docente2.Nome = Console.ReadLine();
            //    Horario.InsereData();

            //    Console.WriteLine("\n\nId \t{0}\nIdade \t{1}\nNome \t{2}\n", docente2.ID, docente2.Idade, docente2.Nome);
            //}

            ////Ciclo para mostrar tudo no final

            //Console.ReadKey();

            menu.Show();
        }
    }
}
