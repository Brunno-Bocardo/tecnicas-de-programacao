using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // EXERCICIO 0
        int num = 0, soma = 0;
        List<int> intList = new List<int>();

        do
        {
            Console.Write("Informe um numero inteiro positivo: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                intList.Add(num);
        } while (num > 0);

        foreach (int i in intList)
            soma += i;

        Console.WriteLine($"Quantidade de valores informados: {intList.Count}");

        if (intList.Count > 0)
            Console.WriteLine($"Media: {Convert.ToDouble(soma) / intList.Count}");


        // EXERCICIO 0.1
        List<string> disciplinas = new List<string>();
        List<string> discProg = new List<string>();
        string disc = String.Empty;

        do
        {
            Console.WriteLine("Informe uma disciplina: ");
            disc = Console.ReadLine();
            if (disc.ToUpper() != "FIM")
                disciplinas.Add(disc);
        } while (disc.ToUpper() != "FIM");

        discProg = disciplinas.FindAll(d => d.ToUpper().Contains("PROG"));
        Console.WriteLine("Disciplinas: ");
        foreach (string d in discProg)
            Console.WriteLine(d);


        // EXERCICIO 1
        List<int> valores_pares = new List<int>();
        List<int> valores_impares = new List<int>();
        int aux = 0;
        int soma = 0;
        do
        {
            Console.WriteLine("Informe um numero inteiro positivo ou negativo: ");
            Console.WriteLine("Digite 0 para sair: ");
            aux = Convert.ToInt32(Console.ReadLine());
            if (aux % 2 == 0)
                valores_pares.Add(aux);
            else
                valores_impares.Add(aux);
        } while (aux != 0);

        Console.WriteLine($"Quantidade de pares: {valores_pares.Count - 1}");
        foreach (int i in valores_pares)
            soma += i;
        Console.WriteLine($"Soma dos pares: {soma}");
        soma = 0;
        Console.WriteLine($"Quantidade de impares: {valores_impares.Count}");
        foreach (int i in valores_impares)
            soma += i;
        Console.WriteLine($"Soma dos impares: {soma}");


        // EXERCICIO 2
        List<int> lista = new List<int>();
        lista.Add(1); lista.Add(2); lista.Add(3); lista.Add(4);
        int num;
        Console.WriteLine("Temos uma lista:");
        foreach (int i in lista)
            Console.Write($"{i} ");
        Console.WriteLine("\nEscolha um item para apagar da lista: ");
        num = Convert.ToInt32(Console.ReadLine());
        lista.Remove(num);
        foreach (int i in lista)
            Console.Write($"{i} ");


        // EXERCICIO 3
        List<int> lista = new List<int>();
        lista.Add(10); lista.Add(2); lista.Add(35); lista.Add(-4);
        Console.WriteLine("Temos uma lista:");
        foreach (int i in lista)
            Console.Write($"{i} ");

        Console.WriteLine($"\nO maior valor é: {lista.Max()}");
        Console.WriteLine($"O menor valor é: {lista.Min()}");
    }
}