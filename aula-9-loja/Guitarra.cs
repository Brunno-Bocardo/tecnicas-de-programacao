using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    internal class Guitarra : Produto
    {
        public Guitarra(String Nome, double Preco)
            : base(Nome, Preco) { }

        public override void reajustarPreco()
        {
            this.Preco = Preco * 1.005;
        }
    }
}
