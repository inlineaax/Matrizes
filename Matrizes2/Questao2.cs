using System;

class Program
{
    static int ContarSubmatriz(int[,] matrizA, int[,] submatrizB)
    {
        int linhasA = matrizA.GetLength(0);
        int colunasA = matrizA.GetLength(1);
        int linhasB = submatrizB.GetLength(0);
        int colunasB = submatrizB.GetLength(1);

        int contador = 0;

        for (int i = 0; i <= linhasA - linhasB; i++)
        {
            for (int j = 0; j <= colunasA - colunasB; j++)
            {
                if (VerificarSubmatriz(matrizA, submatrizB, i, j))
                {
                    contador++;
                }
            }
        }

        return contador;
    }

    static bool VerificarSubmatriz(int[,] matrizA, int[,] submatrizB, int inicioLinha, int inicioColuna)
    {
        int linhasB = submatrizB.GetLength(0);
        int colunasB = submatrizB.GetLength(1);

        for (int i = 0; i < linhasB; i++)
        {
            for (int j = 0; j < colunasB; j++)
            {
                if (matrizA[inicioLinha + i, inicioColuna + j] != submatrizB[i, j])
                {
                    return false;
                }
            }
        }

        return true;
    }

    static void Main()
    {
        int[,] matrizA = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 1, 2, 3},
            {4, 5, 6, 7}
        };

        int[,] submatrizB = {
            {1, 2},
            {5, 6}
        };

        int ocorrencias = ContarSubmatriz(matrizA, submatrizB);
        Console.WriteLine("Número de ocorrências da submatriz B na matriz A: " + ocorrencias);
    }
}
