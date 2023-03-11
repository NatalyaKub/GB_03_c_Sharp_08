// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

//найти сумму строк
 int[] RowSum(int[,] array, int m){
    int[] rowSum = new int[m];
	for (int i = 0; i < array.GetLength(0); i++){
		int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++){
			sum = sum + array[i,j];
	 	}
        rowSum[i] = sum;
    }
    return rowSum;
}

//найти строку с наименьшей суммой элементов   
int Min(int[] rowSum,int m){
    int min = rowSum[0];
    int rowMin = 0;
    for (int i = 1; i < m; i++){
        if (rowSum[i] < min){
            min = rowSum[i];
            rowMin = i;
        }
    }
    return rowMin;
}

Console.WriteLine("Задайте размер двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = FillMatrix(m, n);
PrintArray(array);
Console.WriteLine();

int[] rowSum = RowSum(array, m);
int rowMin = Min(rowSum, m);
Console.WriteLine($"Строка c наименьшей суммой элементов: {rowMin}");

