internal class Program
{
    private static void Main(string[] args)
    {
        // EXERCPICIO 1
        int senha;
        do
        {
            Console.WriteLine("Digite A senha");
            senha = int.Parse(Console.ReadLine());

            if (senha != 12345)
                Console.WriteLine("Senha incorreta, tente novamente");
        } while (senha != 12345);
        Console.WriteLine("Bem-vindo, Jeremias");


        // EXERCICIO 2
        int num, quantidadePar = 0, quantidadeImpar = 0, somaPar = 0, somaImpar = 0;
        do
        {
            Console.WriteLine("Digite um numero");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                quantidadePar++;
                somaPar += num;
            }
            else
            {
                quantidadeImpar++;
                somaImpar += num;
            }

        } while (num != 0);
        double media = somaImpar / quantidadeImpar;
        Console.WriteLine($"Quantidade de pares:{quantidadePar}");
        Console.WriteLine($"Soma dos pares:{somaPar}");
        Console.WriteLine($"Quantidade de impares:{quantidadeImpar}");
        Console.WriteLine($"Média dos impares:{media}");


        // EXERCICIO 3
        String op = null;
        int quantidadeCarrosTotal = 0;
        double valorTotal = 0;
        int ano;
        int valor;
        do
        {
            Console.WriteLine("Você tem um carro pra informar?");
            op = Console.ReadLine();

            if(op == "s")
            {
                Console.WriteLine("Digite o ano do carro");
                ano = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o preço do carro");
                valor = int.Parse(Console.ReadLine());

                if (ano <= 2000)
                {
                    valorTotal += valorTotal + (valor * 0.88);
                    quantidadeCarrosTotal++;
                } 
                else
                {
                    valorTotal += valorTotal + (valor * 0.93);
                }
            }
        } while (op != "n");
        Console.WriteLine($"Quantidade de carros até 2000: {quantidadeCarrosTotal}");
        Console.WriteLine($"Total nos carros: {valorTotal}");
    }
}