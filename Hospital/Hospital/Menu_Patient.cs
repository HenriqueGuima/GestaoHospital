using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hospital
{
    class Menu_Patient
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

            string path = @"Patients.txt";
            string[] a = File.ReadAllLines(path);
            p = new Patient[a.Length];

            do
            {
                Console.WriteLine("1- New Patient");
                Console.WriteLine("2- List Patients");
                Console.WriteLine("3- Edit Patient");
                Console.WriteLine("4- Remove Patient");
                Console.WriteLine("0- Return");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 2:
                        for (int i = 0; i < a.Length; i++)
                        {
                            string fullName = new string(a[i].ToArray());
                        }
                        break;
                    case 0:
                        Console.Clear();
                        menu.Show();
                        break;
                }
            } while (opcao != 0);
        }
    }
}
