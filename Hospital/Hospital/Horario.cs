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
        //public static void InsereData()
        //{
        //    Console.WriteLine("Insira a data da consulta");
        //    Console.WriteLine("\n0000-00-00 00:00:00");

        //    var Input = Console.ReadLine();

        //    DateTime resultado;
        //    DateTime.TryParse(Input, out resultado);

        //}
        //Fazer cenas com o DateTime

        //public int Data (int dia, int mes, int ano)
        //{
        //    int Dia = dia;
        //    int Mes = mes;
        //    int Ano = ano;
        //}

        //public int Dia{ get; set; }
        //public int Mes{ get; set; }
        //public int Ano { get; set; }

        //resolver erros
        public void InsereData ()
        {
            string[] formatos = { "ddMMaaaa", "HHmmss" };
            string data = Console.ReadLine();
            string[] datas = new string[] { data };

            DateTime parsedDate;

            foreach (var data in datas)
            {
                if (DateTime.TryParseExact(datas, formatos, null, DateTimeStyles.AllowWhiteSpaces | DateTimeStyles.AdjustToUniversal, out parsedDate));
                {
                    Console.WriteLine("{1:g}", datas, parsedDate);
                }else
            	{
                    Console.WriteLine("Não foi convertido {0}", datas);
                }
            }
           
        }
    }
}
