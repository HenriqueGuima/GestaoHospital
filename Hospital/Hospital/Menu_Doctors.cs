using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Menu_Doctors
    {
        public void Show()
        {
            Console.Clear();
            int opcao;
            Menu_Principal menu = new Menu_Principal();
            Menu_Patient patient = new Menu_Patient();
            Menu_Doctors doctor = new Menu_Doctors();
            Menu_Symptoms symptom = new Menu_Symptoms();
            Menu_Diseases disease = new Menu_Diseases();

            do
            {
                Console.WriteLine("1- New Doctor");
                Console.WriteLine("2- List Doctors");
                Console.WriteLine("3- Edit Doctor");
                Console.WriteLine("4- Remove Doctor");
                Console.WriteLine("0- Return");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.Clear();
                        menu.Show();
                        break;
                }
            } while (opcao != 0);
        }
    }
}
