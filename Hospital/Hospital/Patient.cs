using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Patient
    {
        string nome;

        static int tpatient = 0;

        public Patient()
        {
            tpatient++;
            nome = "";
        }

        public Patient(string nome)
        {
            tpatient++;
            this.nome = nome;
        }

        public string Nome { get { return nome; } set { nome = value; } }
        public int Tpatient{ get {return tpatient; }}
    }
}
