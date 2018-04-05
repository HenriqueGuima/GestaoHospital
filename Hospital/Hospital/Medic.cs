using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Medic : Employee 
    {
        public enum Especialidades
        {
            Medicina, Enfermaria, Pediatria
        }

        public Especialidades Esp { get; set; }

        public Medic(int id, string nome, int idade, Especialidades esp)
        {
            base.ID = id;
            base.Nome = nome;
            base.Idade = idade;
            this.Esp = esp;
        }
    }
}
