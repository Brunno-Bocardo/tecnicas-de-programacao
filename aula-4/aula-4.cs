internal class Program
{
    private static void Main(string[] args)
    {

        // EXERCÍCIO 0
        int atual = 0, anterior = 1, soma = 0;
        for (int i = 0; i <= 30; i++)
        {
            Console.Write($"{atual} ");

            soma = anterior + atual;
            atual = anterior;
            anterior = soma;
        }


        // EXERCÍCIO 1
        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 != 0 || i % 3 == 0)
            {
                continue;
            }
            Console.Write($"{i} ");
        }


        // EXERCICIO 2



        // EXERCICIO 3
        int atual = 0, anterior = 1, soma = 0;
        int aux = 0;
        for (int i = 0; i <= 100; i++)
        {
            if (aux >= 20)
                break;
            if (atual % 2 == 0)
            {
                Console.Write($"{atual} ");
                aux++;
            }

            soma = anterior + atual;
            atual = anterior;
            anterior = soma;
        }


        // EXERCICIO 4
        int[] listaEx3 = new int[15];
        int cont=0;
        for (int i = 0; i < listaEx3.Length; i++)
        {
            Console.Write("Digite um número: ");
            listaEx3[i] = int.Parse(Console.ReadLine());
            if (listaEx3[i] >= 10 && listaEx3[i] <= 150)
                cont ++;
        }
        Console.WriteLine($"{cont}");


        // EXERCICIO 5
        Console.WriteLine("Diga um numero");
        int val = int.Parse(Console.ReadLine());
        for (int i = val - 1; i >= 1; --i)
        {
            val *= i;
        }
        Console.WriteLine($"{val}");
    }
}