using $safeprojectname$;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria conta1 = new ContaBancaria(1, 10, 5000, "Brunno");

        conta1.agencia = 3;
        Console.WriteLine(conta1.agencia);
        Console.WriteLine(conta1.titular);
        Console.WriteLine(conta1.saldo);

        conta1.debitar(200);
        Console.WriteLine(conta1.saldo);

        conta1.creditar(1000);
        Console.WriteLine(conta1.saldo);

        // ============================================================================

        ContaPoupanca conta2 = new ContaPoupanca(2, 20, 3000, "Chaves");
        Console.WriteLine(conta2.agencia);
        Console.WriteLine(conta2.titular);
        Console.WriteLine(conta2.saldo);

        conta2.debitar(2000);
        Console.WriteLine(conta2.saldo);

        conta2.creditar(100);
        Console.WriteLine(conta2.saldo);

        // ============================================================================

        ContaCorrente conta3 = new ContaCorrente(3, 30, 54, "Quico");
        Console.WriteLine(conta3.agencia);
        Console.WriteLine(conta3.titular);
        Console.WriteLine(conta3.saldo);

        conta3.debitar(1);
        Console.WriteLine(conta3.saldo);

        conta3.creditar(10);
        Console.WriteLine(conta3.saldo);

    }
}