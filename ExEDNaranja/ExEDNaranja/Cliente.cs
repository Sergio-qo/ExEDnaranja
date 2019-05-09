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

        public Cliente()
        {
            saldo = 100;
        }





        public void SumaSaldo(double sal)
        {
            saldo += sal;
        }

        public void RestaSaldo(double sal)
        {
            this.saldo -= sal;
        }

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
