using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    internal class ContaBancaria
    {

        public int agencia { get; set; }
        public int conta { get; set; }
        public double saldo { get; set; }
        public string titular { get; set; }


        public ContaBancaria(int agencia, int conta, double saldo, string titular)
        {
            this.agencia = agencia;
            this.conta = conta;
            this.saldo = saldo;
            this.titular = titular;
        }

        public virtual void debitar(double valor)
        {
            this.saldo -= valor;    
        }

        public virtual void creditar(double valor)
        {
            this.saldo += valor;
        }
    }
}
