using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Menu_Principal
    {
        public void Show()
        {
            int opcao;

            Menu_Patient patient = new Menu_Patient();
            Menu_Doctors doctor = new Menu_Doctors();
            Menu_Symptoms symptom = new Menu_Symptoms();
            Menu_Diseases disease = new Menu_Diseases();
            
            do
            {
                Console.WriteLine("Bem Vindo.\n\n");
                Console.WriteLine("1-Patients");
                Console.WriteLine("2-Doctors");
                Console.WriteLine("3-Symptoms");
                Console.WriteLine("4-Disases");
                Console.WriteLine("0-Close");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        patient.Show();
                        Console.ReadKey();
                        break;
                    case 2:
                        doctor.Show();
                        Console.ReadKey();
                        break;
                    case 3:
                        symptom.Show();
                        Console.ReadKey();
                        break;
                    case 4:
                        disease.Show();
                        Console.ReadKey();
                        break;
                    case 0:
                        System.Environment.Exit(opcao);
                        break;
                }
                Console.Clear();
            } while (opcao != 0);
        }
    }
}
