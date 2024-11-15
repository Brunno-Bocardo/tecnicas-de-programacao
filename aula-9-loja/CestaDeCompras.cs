using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    internal class CestaDeCompras
    {
        public List<Produto> ProdutosDaCesta = new List<Produto>();

        public CestaDeCompras() { }

        public bool addProduto(Produto produto) {
            try {
                ProdutosDaCesta.Add(produto);
                return true;
            }
            catch {
                return false;
            }
        }

        public void showProdutos()
        {
            foreach (Produto produto in ProdutosDaCesta) {
                Console.WriteLine(produto.Nome + " | " + produto.Preco);
            }
        }

        public void totalCesta()
        {
            double total = 0;
            foreach(Produto produto in ProdutosDaCesta)
            {
                total += produto.Preco;
            }
            Console.WriteLine("O total da sua cesta é de: " + total);
        }

    }
}
