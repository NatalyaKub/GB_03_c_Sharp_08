// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillMatrix(int m, int n){
    int [,] array = new int[m, n];
    int k = 1;
    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            array[i, j] = k++;
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
Console.WriteLine("Задайте размер двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = FillMatrix(m, n);
PrintArray(array);
Console.WriteLine();


