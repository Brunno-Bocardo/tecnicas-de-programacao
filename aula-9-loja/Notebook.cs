using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$ 
{
    internal class Notebook : Produto
    {
        public Notebook(String Nome, double Preco)
            : base(Nome, Preco) { }

        public override void reajustarPreco()
        {
            this.Preco = Preco * 1.02;
        }
    }
}
