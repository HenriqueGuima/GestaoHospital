using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Menu_Principal
    {
        static public void Principal()
        {
            int opcao;

            //Menu_Patient patient = new Menu_Patient();
            //Menu_Doctors doctor = new Menu_Doctors();
            //Menu_Symptoms symptom = new Menu_Symptoms();
            //Menu_Diseases disease = new Menu_Diseases();

            //do
            //{
            Medic.MostraM(); // Teste para ver se mostra o ficheiro
            Console.WriteLine("Bem Vindo.\n\n");
                Console.WriteLine("1. Patients");
                Console.WriteLine("2. Doctors");
                Console.WriteLine("3. Symptoms");
                Console.WriteLine("4. Diseases");
                Console.WriteLine("0. Close");
                //opcao = int.Parse(Console.ReadLine());

            //    switch (opcao)
            //    {
            //        case 1:
            //            patient.Show();
            //            Console.ReadKey();
            //            break;
            //        case 2:
            //            doctor.Show();
            //            Console.ReadKey();
            //            break;
            //        case 3:
            //            symptom.Show();
            //            Console.ReadKey();
            //            break;
            //        case 4:
            //            disease.Show();
            //            Console.ReadKey();
            //            break;
            //        case 0:
            //            System.Environment.Exit(opcao);
            //            break;
            //    }
            //    Console.Clear();
            //} while (opcao != 0);
        }
        //Fazer o mesmo para adicionar doença & sintomas

        static public void PatientsI()
        {
            Patient p1 = new Patient();
            Patients patients = new Patients();
            patients.AddP(p1);
            string resposta;
            

            Console.WriteLine("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Olá {0}, o seu médico vai ser...", p1.Nome); //Fazer o programa depois escolher um médico aleatório da lista
            Console.WriteLine("Ver os que já existem? [s] [n]\n");

            resposta = Console.ReadLine();

            if (resposta == "s")
            {
                //Patients.MostraP();
                //Medic.MostraM();
            }
            else
            {
                Console.WriteLine("Carregue para sair...");
                Console.ReadKey();
            }
            
            Console.ReadKey();
        }
    }
}
