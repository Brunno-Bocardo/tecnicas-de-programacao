internal class Program
{
    private static void Main(string[] args)
    {
        // EXERCÍCIO 1
        Console.WriteLine("Digite um número: ");
        double val = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        double val2 = double.Parse(Console.ReadLine());

        if (val % val2 == 0)
            Console.WriteLine("É multiplo!");
        else
            Console.WriteLine("Não é múltiplo!");


        // EXERCÍCIO 2
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


        // EXERCÍCIO 3
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


        // EXERCÍCIO 4
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


        //EXERCÍCIO 5
        Console.WriteLine("Digite um número inteiro: ");
        int val5 = int.Parse(Console.ReadLine());
        if (val5 % 2 == 0)
            Console.WriteLine("Par");
        else
            Console.WriteLine("Ímpar");


        //EXERCÍCIO 6
        Console.WriteLine("Me diga sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        if(idade >= 65){
            Console.WriteLine("Pode aposentar");
        }
        else {
            int restante = 65 - idade;
            Console.WriteLine($"Você pode se aposentar em {restante} anos");
        }


       
    }
}
