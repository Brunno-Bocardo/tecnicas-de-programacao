using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    internal class ContaPoupanca : ContaBancaria
    {
        private float taxaJuros = 0.05f;

        public ContaPoupanca(int agencia, int conta, double saldo, string titular)
            : base(agencia, conta, saldo, titular)
        { }

        public override void creditar(double valor)
        {
            this.saldo = ((valor + saldo) * (1 + this.taxaJuros));
        }

    }
}
