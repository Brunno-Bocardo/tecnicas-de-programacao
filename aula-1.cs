internal class Program
{
    private static void Main(string[] args)
    {
        // EXERCÍCIO 1
        Console.Write("Digite o primeiro número: ");
        string num1String = Console.ReadLine();
        int num1 = int.Parse(num1String);

        Console.Write("Digite o segundo número: ");
        string num2String = Console.ReadLine();
        int num2 = int.Parse(num2String);

        Console.WriteLine($"Soma: {num1+num2}");
        Console.WriteLine($"Subtração: {num1-num2}");
        Console.WriteLine($"Multiplicação: {num1*num2}");
        Console.WriteLine($"Divisão: {num1/num2}");


        // EXERCÍCIO 2
        Console.Write("Digite o raio de um círculo: ");
        string raioString = Console.ReadLine();
        int raio = int.Parse(raioString);
        double area = 3.14 * Math.Pow(raio, 2 );
        Console.WriteLine($"A área do círculo é: {area}");


        // EXERCÍCIO 3
        Console.Write("Digite o cateto 1: ");
        string cat1String = Console.ReadLine();
        int cat1 = int.Parse(cat1String);

        Console.Write("Digite o cateto 2: ");
        string cat2String = Console.ReadLine();
        int cat2 = int.Parse(cat2String);

        Console.WriteLine($"A hipotenusa desse triângulo é: {Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2))}");


        // EXERCÍCIO 4
        Console.Write("Digite o raio da Lata: ");
        string raioLataString = Console.ReadLine();
        int raioLata = int.Parse(raioLataString);

        Console.Write("Digite a altura da Lata: ");
        string alturaLataString = Console.ReadLine();
        int alturaLata = int.Parse(alturaLataString);

        double volume = (3.14 * Math.Pow(raioLata, 2)) * alturaLata;
        Console.WriteLine($"O volume da lata é: {volume}");
    }
}
