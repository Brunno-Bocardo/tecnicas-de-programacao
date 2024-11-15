using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    abstract class Produto
    {
        public String Nome { get; set; }
        public double Preco { get; set; }

        public Produto(String Nome, double Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco;
        }

        public abstract void reajustarPreco();
    }
}
