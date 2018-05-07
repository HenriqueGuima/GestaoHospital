using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Symptom
    {
        string sintoma;

        static int tsin = 0;

        public Symptom()
        {
            tsin++;
            sintoma = "";
        }

        public Symptom(string sin)
        {
            tsin++;
            this.sintoma = sin;
        }

        public string Sintoma { get { return sintoma; } set { sintoma = value; } }
        public int Tsin{ get {return tsin; }}
    }
}
