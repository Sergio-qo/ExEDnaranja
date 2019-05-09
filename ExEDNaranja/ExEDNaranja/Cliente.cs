using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEDNaranja
{
    class Cliente
    {
        private string nombre;
        private string dni;
        private double saldo;

        public Cliente()
        {
            this.saldo = 100;
        }





        public void SumaSaldo(double saldo)
        {
            this.saldo += saldo;
        }

        public void RestaSaldo(double saldo)
        {
            this.saldo -= saldo;
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
