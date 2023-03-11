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

// int[,] arrayAB = new int [n,k];
// for (int j = 0; j<n-1; j++){ //arrayA.Get.Lenght(0)
// 	for (int i = 0; i<m; i++){//arrayA.Get.Lenght(1)
// for (int k = 0; k<p; k++){//arrayB.Get.Lenght(1)
// 	AB[i,k] = A[i,j]*B[j,k]+A[i,j+1]*B[j+1,k];
// }
// }
// }


Console.WriteLine("Задайте размер двухмерного массива m x n:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Задайте размер двухмерного массива {n} x k:");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] arrayA = FillMatrix(m, n);
PrintArray(arrayA);
Console.WriteLine();


int[,] arrayB = FillMatrix(n, k);
PrintArray(arrayB);
Console.WriteLine();

// int[,] arrayAB = перемножаем
// print (arrayAB)

