using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    /// <summary>
    /// Enumerandos
    /// </summary>
    
    abstract class Employee
    {
        #region COMMENT

        /*int ID;
        string Nome = " ";
        int Idade;
        private int v1;
        private Employee rodrigo;
        private int v2;
        private Especialidades medicina;

        public Employee(int v1, Employee rodrigo, int v2, Especialidades medicina)
        {
            this.v1 = v1;
            this.rodrigo = rodrigo;
            this.v2 = v2;
            this.medicina = medicina;
        }

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
        }*/
        #endregion

        string nome = "";
        DateTime horario;

        public string Nome { get {return nome; } set {nome = value; } }
        //public int Idade { get; set; }
        public DateTime Horario{ get {return horario; } set {horario = value; } }

        public Employee()
        {
            nome = "";
            horario = DateTime.Now;
        }

        public Employee(string nome, DateTime horario)
        {
            this.nome = nome;
            this.horario = horario;
        }



    }
}
