
using System;
using Microsoft.Extensions.Options;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // EXERCICIO 1
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int soma = 0;
        for (int i = 0; i < array.Length; i++) {
            soma += array[i];
        }
        Console.WriteLine($"A média do array é: {soma / (double)array.Length}");


        // EXERCICIO 2
        int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        foreach (int val in array2) {
            if (val > 1) {
                bool ehPrimo = true; 
                if (val == 2) {
                    Console.WriteLine($"{val} é primo.");
                    continue;
                }
                
                if (val % 2 == 0) 
                    ehPrimo = false;
                
                else {
                    for (int i = 3; i <= Math.Sqrt(val); i += 2) {
                        if (val % i == 0) {
                            ehPrimo = false;
                            break; 
                        }
                    }
                }

                if (ehPrimo)
                    Console.WriteLine($"{val} é primo.");
            }
        }


        // EXERCICIO 3
        int[,] matriz = new int[5, 5];
        int totalSomaMatriz = 0;

        Console.WriteLine("Digite os valores da matriz 5x5:");
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++){
                Console.Write($"Elemento [{i+1},{j+1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
                totalSomaMatriz += matriz[i, j]; 
            }
        
        Console.WriteLine("\nSoma e média de cada linha:");
        for (int i = 0; i < 5; i++){
            int somaLinha = 0;
            for (int j = 0; j < 5; j++)
                somaLinha += matriz[i, j];
            
            Console.WriteLine($"Linha {i+1}: Soma = {somaLinha}, Média = {(double)somaLinha / 5}");
        }

        Console.WriteLine("\nSoma e média de cada coluna:");
        for (int j = 0; j < 5; j++){
            int somaColuna = 0;
            for (int i = 0; i < 5; i++)
                somaColuna += matriz[i, j];
            
            Console.WriteLine($"Coluna {j+1}: Soma = {somaColuna}, Média = {(double)somaColuna / 5}");
        }

        double mediaMatriz = (double)totalSomaMatriz / (5 * 5);
        Console.WriteLine($"\nSoma total da matriz: {totalSomaMatriz}");
        Console.WriteLine($"Média total da matriz: {mediaMatriz}");


        // EXERCICIO 4
        int[,] matriz = new int[5, 5];
        int totalSomaMatriz = 0;
        bool identidade=true;

        Console.WriteLine("Digite os valores da matriz 5x5:");
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++){
                Console.Write($"Elemento [{i+1},{j+1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
                totalSomaMatriz += matriz[i, j]; 
            }
        
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++){
                if (i == j && matriz[i, j] != 1) {
                    identidade = false; 
                    break;
                }

                if (i != j && matriz[i, j] !=0) {
                    identidade = false; 
                    break;
                }
            }
            if (!identidade) break;
        }
        
        Console.WriteLine(identidade ? "É identidade" : "Não é identidade");


        // EXERCICIO 5
        Console.Write("Digite o número de linhas (N): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de colunas (M): ");
        int m = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, m];
        int[,] matrizTransposta = new int[m, n];

        Console.WriteLine("Digite os valores da matriz:");
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++){
                Console.Write($"Elemento [{i+1},{j+1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                matrizTransposta[j, i] = matriz[i, j];
            
        Console.WriteLine("\nMatriz original:");
        for (int i = 0; i < n; i++){
            for (int j = 0; j < m; j++)
                Console.Write(matriz[i, j] + "\t");
            Console.WriteLine();
        }

        Console.WriteLine("\nMatriz transposta:");
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++)
                Console.Write(matrizTransposta[i, j] + "\t");
            Console.WriteLine();
        }
    }
}