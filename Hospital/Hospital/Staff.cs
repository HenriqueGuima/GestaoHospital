using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    /// <summary>
    /// Enummerandos
    /// </summary>
    enum Especialidades
    {
        Medicina, Enfermaria, Pediatria
    }
    class Staff
    {
        int ID;
        string Nome = " ";
        int Idade;
        //Fazer mais alguns
        //Especialidades esp;

        /// <summary>
        /// Propriedades
        /// </summary>
        public class Ficha
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public int Idade{ get; set; }
            public Especialidades Especialidades { get; set; }
        }
        /// <summary>
        /// Método para criar uma nova ficha de utente
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        /// <param name="especialidades"></param>
        public void CriaFicha (int id, string nome, int idade, Especialidades especialidades)
        {
            //Ficha com os dados
            Ficha ficha = new Ficha
            {
                ID = id,
                Nome = nome,
                Idade = idade,
                Especialidades = especialidades

            };
        }
    }
}
