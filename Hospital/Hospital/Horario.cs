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
        int dia;
        int mes;
        int ano;
        int horas;
        int minutos;

        public Horario()
        {
            mes = 1;
            dia = 1;
            ano = 2000;
            horas = 1;
            minutos = 1;
        }

        public int Mes { get { return (mes); } set {mes = value; } }
        public int Dia { get { return (dia); } set { dia = value; } }
        public int Ano { get { return (ano); } set { ano = value; } }
        public int Horas { get { return (horas); } set { horas = value; } }
        public int Minutos { get { return (minutos); } set { minutos = value; } }

        public static string Getmonth(int mes)
        {
            string mesnome = string.Empty;
            switch (mes)
            {
                case 1:
                    mesnome = "Janeiro";
                    break;
                case 2:
                    mesnome = "Fevereiro";
                    break;
                case 3:
                    mesnome = "Marco";
                    break;
                case 4:
                    mesnome = "Abril";
                    break;
                case 5:
                    mesnome = "Maio";
                    break;
                case 6:
                    mesnome = "Junho";
                    break;
                case 7:
                    mesnome = "Julho";
                    break;
                case 8:
                    mesnome = "Agosto";
                    break;
                case 9:
                    mesnome = "Setembro";
                    break;
                case 10:
                    mesnome = "Outubro";
                    break;
                case 11:
                    mesnome = "Novembro";
                    break;
                case 12:
                    mesnome = "Dezembro";
                    break;
            }
            return (mesnome);
        }
    }
}
