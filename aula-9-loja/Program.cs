using $safeprojectname$;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //Produtos Base
        Dvd dvd = new Dvd("Senhor dos Aneis", 30);
        Notebook notebook = new Notebook("Dell G15", 3000);
        Videogames videogame = new Videogames("PS5 Pro", 6500);
        Guitarra guitarra = new Guitarra("Guitarra do Slash", 25000);
        Televisores televisor = new Televisores("Samsung Smart Boladona", 7000);

        //Cesta de Compras
        CestaDeCompras minhaCesta = new CestaDeCompras();
        minhaCesta.addProduto(new Notebook(notebook.Nome, notebook.Preco));
        minhaCesta.addProduto(new Dvd(dvd.Nome, dvd.Preco));
        minhaCesta.showProdutos();




        dvd.reajustarPreco();

        Console.WriteLine(dvd.Preco);

        minhaCesta.showProdutos();
        minhaCesta.totalCesta();
    }
}