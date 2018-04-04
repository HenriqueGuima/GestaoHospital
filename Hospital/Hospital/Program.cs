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
            Staff Rodrigo = new Staff();
            Rodrigo.CriaFicha(46, "Rodrigo", 30, Especialidades.Medicina); 
        }
    }
}
