using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    internal class ContaCorrente : ContaBancaria
    {
        private int taxaSaque = 1;

        public ContaCorrente(int agencia, int conta, double saldo, string titular)
            : base(agencia, conta, saldo, titular)
        { }

        public override void debitar(double valor)
        {
            this.saldo -= (valor + taxaSaque);
        }
    }
}
