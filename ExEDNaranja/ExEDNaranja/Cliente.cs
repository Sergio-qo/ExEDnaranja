using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEDNaranja
{
    public class Cliente
    {
        private string nombre;
        private string dni;
        private double saldo;
        public double Saldo { get { return saldo; } }
        /// <summary>
        /// Creamos el constructor cliente que pide los parametros
        /// </summary>
        /// <param name="nom">Almacena el nombre </param>
        /// <param name="Dni">Almacena el DNI </param>
        public Cliente(string nom,string Dni)
        {
            nombre = nom;
            dni = Dni;
            saldo = 100;
        }
        /// <summary>
        /// Es un constructor vacio para llamar a las funciones
        /// </summary>
        public Cliente()
        {
            saldo = 100;
        }




        /// <summary>
        /// Suma el saldo mas un saldo indicado
        /// </summary>
        /// <param name="sal">Recibe el parametro saldo a añadir</param>
        public void SumaSaldo(double sal)
        {
            saldo += sal;
        }
        /// <summary>
        /// Resta el saldo menos un saldo indicado
        /// </summary>
        /// <param name="sal">Recibe el parametro saldo a restar de saldo</param>
        public void RestaSaldo(double sal)
        {
            this.saldo -= sal;
        }
        /// <summary>
        /// Devuelve positivo o negativo dependiendo de si el saldo esta bajo 0
        /// </summary>
        /// <returns>negativo o positivo</returns>
        public string PositivoNegativo()
        {
            string resultado = "";

            if(this.saldo >= 0)
            {
                resultado = "positivo";
            }
            else
            {
                resultado = "negativo";
            }

            return resultado;
        }









    }
}
