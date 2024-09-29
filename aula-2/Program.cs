internal class Program
{
    private static void Main(string[] args)
    {
        // EXERCÍCIO 0
        Console.WriteLine("Digite um número: ");
        double val = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        double val2 = double.Parse(Console.ReadLine());

        if (val % val2 == 0)
            Console.WriteLine("É multiplo!");
        else
            Console.WriteLine("Não é múltiplo!");


        // EXERCÍCIO 1
        Console.WriteLine("Digite um número entre 1 e 10: ");
        double val3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número entre 1 e 10: ");
        double val4 = double.Parse(Console.ReadLine());

        double media = (val3 + val4) / 2;
        if (media >= 6)
            Console.WriteLine("Aprovado!");
        else if (media >= 4 && media <= 5.9)
            Console.WriteLine("Recuperação!");
        else
            Console.WriteLine("Reprovado!");


        // EXERCÍCIO 2
        int[] listaEx3 = new int[3];
        for (int i = 0; i < listaEx3.Length; i++) {
            Console.Write("Digite um número: ");
            listaEx3[i] = int.Parse(Console.ReadLine());
        }

        // solução legal
        Array.Sort(listaEx3);
        Console.Write("Lista ordenada: ");
        foreach (int i in listaEx3) { Console.Write(i + " "); }

        Console.WriteLine("\n");

        // solução pedida
        if (listaEx3[0] < listaEx3[1] && listaEx3[0] < listaEx3[2]) {
            if (listaEx3[1] < listaEx3[2]) {
                Console.WriteLine(listaEx3[0] + " " + listaEx3[1] + " " + listaEx3[2]);
            }
            else {
                Console.WriteLine(listaEx3[0] + " " + listaEx3[2] + " " + listaEx3[1]);
            }
        }
        else if (listaEx3[1] < listaEx3[0] && listaEx3[1] < listaEx3[2]) {
            if (listaEx3[0] < listaEx3[2]) {
                Console.WriteLine(listaEx3[1] + " " + listaEx3[0] + " " + listaEx3[2]);
            }
            else {
                Console.WriteLine(listaEx3[1] + " " + listaEx3[2] + " " + listaEx3[0]);
            }
        }
        else if (listaEx3[2] < listaEx3[0] && listaEx3[2] < listaEx3[1]) {
            if (listaEx3[0] < listaEx3[1]) {
                Console.WriteLine(listaEx3[2] + " " + listaEx3[0] + " " + listaEx3[1]);
            }
            else {
                Console.WriteLine(listaEx3[2] + " " + listaEx3[1] + " " + listaEx3[0]);
            }
        }


        // EXERCÍCIO 3
        Console.Write("Digite o valor de um código: ");
        int valCodigo = int.Parse(Console.ReadLine());
        switch (valCodigo) {
            case 1:
                Console.WriteLine("Alimento não-perecível");
                break;
            case int n when (n >= 2 && n <= 4):
                Console.WriteLine("Alimento perecível");
                break;
            case int n when (n == 5 || n == 6):
                Console.WriteLine("Vestuário");
                break;
            case 7:
                Console.WriteLine("Higiene Pessoal");
                break;
            case int n when (n >= 8 && n <= 15):
                Console.WriteLine("Limpeza");
                break;
            default:
                Console.WriteLine("Inválido");
                break;
        }


        //EXERCÍCIO 4
        Console.WriteLine("Digite um número inteiro: ");
        int val5 = int.Parse(Console.ReadLine());
        if (val5 % 2 == 0)
            Console.WriteLine("Par");
        else
            Console.WriteLine("Ímpar");


        //EXERCÍCIO 5
        Console.WriteLine("Me diga sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        if(idade >= 65){
            Console.WriteLine("Pode aposentar");
        }
        else {
            int restante = 65 - idade;
            Console.WriteLine($"Você pode se aposentar em {restante} anos");
        }


        //EXERCÍCIO 6
        Dictionary<string, List<string>> compatibilidade = new Dictionary<string, List<string>>()
        {
            { "A+", new List<string>{ "A+", "A-", "O+", "O-" } },
            { "A-", new List<string>{ "A-", "O-" } },
            { "B+", new List<string>{ "B+", "B-", "O+", "O-" } },
            { "B-", new List<string>{ "B-", "O-" } },
            { "AB+", new List<string>{ "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" } },
            { "AB-", new List<string>{ "A-", "B-", "AB-", "O-" } },
            { "O+", new List<string>{ "O+", "O-" } },
            { "O-", new List<string>{ "O-" } }
        };

        Console.Write("Digite o nome da primeira pessoa (receptor): ");
        string nome1 = Console.ReadLine();
        Console.Write("Digite o tipo sanguíneo da primeira pessoa: ");
        string tipo1 = Console.ReadLine().ToUpper();

        Console.Write("Digite o nome da segunda pessoa (doador): ");
        string nome2 = Console.ReadLine();
        Console.Write("Digite o tipo sanguíneo da segunda pessoa: ");
        string tipo2 = Console.ReadLine().ToUpper();

        if (compatibilidade.ContainsKey(tipo1) && compatibilidade[tipo1].Contains(tipo2))
            Console.WriteLine($"{nome1} pode receber sangue de {nome2}.");
        else
            Console.WriteLine($"{nome1} não pode receber sangue de {nome2}.");


        // EXERCÍCIO 7
        Console.Write("Digite a altura em centímetros: ");
        double alturaCm = double.Parse(Console.ReadLine());

        double altura = alturaCm / 100;

        Console.WriteLine("Digite seu sexo:");
        Console.WriteLine("[H] - Homem");
        Console.WriteLine("[M] - Mulher");
        Console.Write(": ");
        char sexo = char.ToUpper(Console.ReadLine()[0]);

        double pesoIdeal = 0;

        if (sexo == 'H')
            pesoIdeal = (72.7 * altura) - 58;
        else if (sexo == 'M')
            pesoIdeal = (62.1 * altura) - 44.7;

        Console.WriteLine($"O peso ideal para uma pessoa de sexo {sexo} e altura {alturaCm} cm é: {pesoIdeal:F2} kg.");
    
        
        // EXERCÍCIO 8
        Console.WriteLine("Digite o valor do empréstimo: ");
        double valorEmprestimo = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número de parcelas: ");
        int numeroParcelas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o salário bruto do cliente: ");
        double salarioBruto = double.Parse(Console.ReadLine());

        double valorParcela = valorEmprestimo / numeroParcelas;
        double limiteParcela = 0.25 * salarioBruto;

        if (valorParcela <= limiteParcela)
            Console.WriteLine("Empréstimo aprovado!");
        else
            Console.WriteLine("Empréstimo negado.");


        // EXERCÍCIO 9
        Console.WriteLine("Digite o tipo de combustível:");
        Console.WriteLine("[A] - Álcool (R$ 3,04/l)");
        Console.WriteLine("[G] - Gasolina (R$ 4,84/l)");
        Console.WriteLine(": ");
        char tipoCombustivel = char.ToUpper(Console.ReadLine()[0]);

        Console.WriteLine("Digite a capacidade do tanque em litros: ");
        double capacidadeTanque = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de litros atualmente no tanque: ");
        double litrosNoTanque = double.Parse(Console.ReadLine());

        if (litrosNoTanque > capacidadeTanque)
        {
            Console.WriteLine("Erro: A quantidade de litros no tanque não pode ser maior que a capacidade total.");
            return;
        }

        double precoPorLitro = 0;
        if (tipoCombustivel == 'A')
            precoPorLitro = 3.04;
        else if (tipoCombustivel == 'G')
            precoPorLitro = 4.84;
        else {
            Console.WriteLine("Erro: Tipo de combustível inválido. Digite 'A' para Álcool ou 'G' para Gasolina.");
            return;
        }

        double litrosParaEncher = capacidadeTanque - litrosNoTanque;
        double custoTotal = litrosParaEncher * precoPorLitro;

        Console.WriteLine($"O custo total para encher o tanque será de R$ {custoTotal}.");
    }
}
