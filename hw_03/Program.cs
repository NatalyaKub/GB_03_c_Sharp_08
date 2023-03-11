// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrix(int m, int n){
    int [,] array = new int[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            array[i, j] = new Random().Next(0,10);
        }
    }
    return array;
}

void PrintArray(int[,] arr){
    // Method code.
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ArrayMultiplication(int[,] arrayA, int[,]arrayB, int m, int n, int p){
    int[,] arrayAB = new int [n,p];
    for (int j = 0; j < arrayA.GetLength(1)-1; j++){
	    for (int i = 0; i < arrayA.GetLength(0); i++){
            for (int k = 0; k < arrayB.GetLength(1); k++){
	            arrayAB[i,k] = arrayA[i,j]*arrayB[j,k]+arrayA[i,j+1]*arrayB[j+1,k];
            }
        }
    }
    return arrayAB;
}

Console.WriteLine("Задайте размер двухмерного массива m x n:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Задайте размер двухмерного массива {n} x p:");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] arrayA = FillMatrix(m, n);
PrintArray(arrayA);
Console.WriteLine();


int[,] arrayB = FillMatrix(n, p);
PrintArray(arrayB);
Console.WriteLine();

int[,] arrayAB = ArrayMultiplication(arrayA, arrayB, n, m, p);
PrintArray(arrayAB);

