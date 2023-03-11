// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillMatrix(int m, int n, int p){
    int [,,] array = new int[m, n, p];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            for (int k = 0; k < p; k++){
                array[i, j, k] = new Random().Next(10,100);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] arr){
    // Method code.
    for (int k = 0; k < arr.GetLength(2); k++){
        for (int i = 0; i < arr.GetLength(0); i++){
            for (int j = 0; j < arr.GetLength(1); j++){
                Console.Write($"{arr[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        //Console.WriteLine();
    }
}

Console.WriteLine("Задайте размер 3-мерного массива m x n x p:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] array = FillMatrix(m, n, p);
Console.Write($"Массив размером {n} x {m} x {p}");
Console.WriteLine();
PrintArray(array);
Console.WriteLine();

