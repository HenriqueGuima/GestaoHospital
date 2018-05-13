using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hospital
{
    class Menu_Principal
    {
        static public void Principal()
        {

            #region COMMENT
            //Menu_Patient patient = new Menu_Patient();
            //Menu_Doctors doctor = new Menu_Doctors();
            //Menu_Symptoms symptom = new Menu_Symptoms();
            //Menu_Diseases disease = new Menu_Diseases();

            //do
            //{
            //Medic.MostraM(); // Teste para ver se mostra o ficheiro

            #endregion

            Console.WriteLine("Bem Vindo.\n\n");
            Console.WriteLine("1. Patients");
            Console.WriteLine("2. Doctors");
            Console.WriteLine("3. Symptoms");
            Console.WriteLine("4. Diseases");
            Console.WriteLine("0. Close");

            #region COMMENT
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
            #endregion
        }

        static public void PatientsI()
        {
            Patient p1 = new Patient();
            Patients patients = new Patients();
            patients.AddP(p1);

            Symptom s1 = new Symptom();
            Symptoms symptoms = new Symptoms();
            symptoms.AddS(s1);

            Console.Clear();
            int opcao;
            Menu_Principal menu = new Menu_Principal();
            Menu_Doctors doctor = new Menu_Doctors();

            #region COMMENT
            //Menu_Patient patient = new Menu_Patient();
            //Menu_Symptoms symptom = new Menu_Symptoms();
            //string path = @"Patients.txt";
            //string[] a = File.ReadAllLines(path);
            //p = new Patient[a.Length];
            #endregion

            do
            {
                Console.Clear();
                Console.WriteLine("1. New Patient");
                Console.WriteLine("2. List Patients");
                //Console.WriteLine("3- Edit Patient");
                //Console.WriteLine("4- Remove Patient");
                Console.WriteLine("0. Return");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
               {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("Nome: ");
                        p1.Nome = Console.ReadLine();

                        Console.WriteLine("\nCondição: ");
                        p1.Cond = Console.ReadLine();

                        Enum prioridades = Patient.Prioridades.prioridade2;

                        #region BOOL PRIORIDADES
                    //A serem usados para ciclos condicionais
                    bool PrioridadeNormal(Patient.Prioridades prn)
                    {
                        return (prn & Patient.Prioridades.prioridade2) > 0;
                    }

                    bool PrioridadeBaixa(Patient.Prioridades prb)
                    {
                        return (prb & Patient.Prioridades.prioridade3) > 0;
                    }

                        #endregion

                        #region CONDIÇÕES PARA PRIORIDADE 1
                        if (p1.Cond.Contains("cardíaco") || p1.Cond.Contains("miocárdio"))
                        {
                        Console.WriteLine("Olá {0}! Aqui estão os cardiologistas disponíveis:\n", p1.Nome);
                        Medic.MostraCard();

                        }
                        else if (p1.Cond.Contains("Enfarte") || p1.Cond.Contains("enfarte"))
                        {
                        //Patient.Prioridades.prioridade1.ToString();
                        //resposta = "s";
                        //Console.WriteLine(p1.Cond);

                        prioridades = Patient.Prioridades.prioridade1;

                        DateTime thisDay = DateTime.Today;
                        DateTime thisTime = DateTime.UtcNow;
                        //Console.WriteLine("\n{0} com {1} vai automaticamente para consulta em {2} como {3}", p1.Nome, p1.Cond , thisDay.ToString(), prioridades.ToString());
                        Console.WriteLine("\nOlá {0}! Aqui estão os cardiologistas disponíveis:\n", p1.Nome);

                        Medic.MostraCard();
                        string OpMedico = Console.ReadLine();
                        Medic.EscolheMedico(OpMedico);

                        #region ESCREVE OS DADOS PARA UM FICHEIRO
                        string fileName = "Patients.txt";

                        using (System.IO.StreamWriter file = new System.IO.StreamWriter("Patients.txt", true))
                        {
                            //file.WriteLine("\n\nNome : {0}\n Condição: {1} \nData: {2}", p1.Nome, p1.Cond, thisDay);
                            Console.WriteLine("\n");
                            file.WriteLine("\n> {0} :: {1} com {2} vai automaticamente para consulta em {3} como {4}", thisTime.ToString(), p1.Nome, p1.Cond, thisDay.ToString("D"), prioridades.ToString());

                            //Medic m = new Medic () 
                            //Medic.Horario();
                        }
                        using (StreamReader sr = File.OpenText(fileName))
                        {
                            string s = "";
                            while ((s = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(s);
                            }
                            Console.WriteLine("");
                        }

                        #endregion

                        //Console.WriteLine("\n{0} {1} em ", p1.Cond, prioridades.ToString());
                        }
                        #endregion

                        #region CONDIÇÕES PARA PRIORIDADE 2
                        if (p1.Cond.Contains("depressão") || p1.Cond.Contains("ansiedade"))
                        {
                            //PrioridadeBaixa(Patient.Prioridades.prioridade2);
                            //Console.WriteLine(Patient.Prioridades.prioridade2);

                            Console.WriteLine("Olá {0}! Aqui estão os psicólogos disponíveis:\n", p1.Nome);
                            Medic.MostraPsicologo();

                            Console.WriteLine("\nMarcar consulta? [s], [n]");
                            string resposta = Console.ReadLine();

                            if (resposta == "s")
                            {
                                Console.WriteLine("Data: (dd/mm/aaaa HH:mm)");
                                Horario h = new Horario();
                                h.MostraHorario();
                                string data = Console.ReadLine();

                                DateTime ParseDate = DateTime.Parse(data);
                                Console.WriteLine(ParseDate);

                                string DataS = Convert.ToString(ParseDate);

                                #region ESCREVE OS DADOS PARA UM FICHEIRO
                                string fileName = @"C:\Users\HenriqueAlbertoBarro\source\repos\GestaoHospital\Hospital\Hospital\Patients.txt";

                                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\HenriqueAlbertoBarro\source\repos\GestaoHospital\Hospital\Hospital\Patients.txt", true))
                                {
                                    file.WriteLine("\n\nNome : {0}\n Condição: {1} \nData: {2}", p1.Nome, p1.Cond, ParseDate);
                                }
                                using (StreamReader sr = File.OpenText(fileName))
                                {
                                    string s = "";
                                    while ((s = sr.ReadLine()) != null)
                                    {
                                        Console.WriteLine(s);
                                    }
                                    Console.WriteLine("");
                                }

                                #endregion
                            }
                        }
                        #endregion

                        #region CONDIÇÕES PARA PRIORIDADE 3
                        if (p1.Cond.Contains("febre"))
                        {
                            //PrioridadeBaixa(Patient.Prioridades.prioridade3);
                            Console.WriteLine(Patient.Prioridades.prioridade3);
                            Console.WriteLine("Olá {0}! Aqui estão os médicos de medicina geral disponíveis:\n", p1.Nome);
                            Medic.MostraGeral();
                        }
                        #endregion

                        Console.ReadLine();
                    break;

                    case 2:
                        Console.Clear();
                        Patient.MostraP();
                        Console.ReadKey();
                        break;
                    default:
                        //menu.Show();
                        break;
                }
            } while (opcao != 0);

            #region COMMENT
            //Console.WriteLine("Nome: ");
            //p1.Nome = Console.ReadLine();
            //Console.WriteLine("Sintomas: ");
            //s1.Sintoma = Console.ReadLine();
            //Console.WriteLine("Olá {0}, o seu médico vai ser...", p1.Nome); //Fazer o programa depois escolher um médico aleatório da lista
            //Console.WriteLine("Ver os que já existem? [s] [n]");

            //resposta = Console.ReadLine();

            //if (resposta == "s")
            //{
            //    //Patients.MostraP();
            //    Medic.MostraM();
            //}
            //else
            //{
            //    Console.WriteLine("Carregue para sair...");
            //    Console.ReadKey();
            //}
            #endregion

            Console.ReadKey();
        }

        //static public string MarcaConsulta(string resposta)
        //{
        //    Patient p1 = new Patient();
        //    Console.WriteLine("\nMarcar consulta? [s], [n]");

        //    do
        //    {
        //        if (resposta == "s" || resposta == "S")
        //        {
        //            Console.WriteLine("Data: (dd/mm/aaaa HH:mm)");

        //            string data = Console.ReadLine();

        //            DateTime ParseDate = DateTime.Parse(data);
        //            Console.WriteLine(ParseDate);

        //            string DataS = Convert.ToString(ParseDate);

        //            //Método que vai dizer que médico está disponível
        //            //TrataData(data);

        //            #region ESCREVE OS DADOS PARA UM FICHEIRO
        //            string fileName = "Patients.txt";

        //            using (System.IO.StreamWriter file = new System.IO.StreamWriter("Patients.txt", true))
        //            {
        //                file.WriteLine("\n\nNome : {0}\n Condição: {1} \nData: {2}", p1.Nome, p1.Cond, ParseDate);
        //            }
        //            using (StreamReader sr = File.OpenText(fileName))
        //            {
        //                string s = "";
        //                while ((s = sr.ReadLine()) != null)
        //                {
        //                    Console.WriteLine(s);
        //                }
        //                Console.WriteLine("");
        //            }

        //            #endregion
        //        }
        //        else if (resposta == "n" || resposta == "N")
        //        {
        //            Menu_Principal.PatientsI();
        //        }
        //    } while (resposta != "s" || resposta != "S" || resposta != "n" || resposta != "N");

        //    Console.ReadLine();
        //}
    }
}
