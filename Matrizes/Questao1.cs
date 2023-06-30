using System;

class Program
{
    static void InverterDiagonais(int[,] matriz)
    {
        int tamanho = matriz.GetLength(0);

        // Invertendo a diagonal principal
        for (int i = 0; i < tamanho / 2; i++)
        {
            for (int j = 0; j < tamanho / 2; j++)
            {
                int temp = matriz[i, j];
                matriz[i, j] = matriz[tamanho - 1 - i, tamanho - 1 - j];
                matriz[tamanho - 1 - i, tamanho - 1 - j] = temp;
            }
        }

        // Invertendo a diagonal secundária
        for (int i = 0; i < tamanho / 2; i++)
        {
            for (int j = tamanho / 2 + 1; j < tamanho; j++)
            {
                int temp = matriz[i, j];
                matriz[i, j] = matriz[tamanho - 1 - i, tamanho - 1 - j];
                matriz[tamanho - 1 - i, tamanho - 1 - j] = temp;
            }
        }
    }

    static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);

        InverterDiagonais(matriz);

        Console.WriteLine("\nMatriz com diagonais invertidas:");
        ImprimirMatriz(matriz);
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int tamanho = matriz.GetLength(0);

        for (int i = 0; i < tamanho; i++)
        {
            for (int j = 0; j < tamanho; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
