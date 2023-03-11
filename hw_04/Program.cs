// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillMatrix(int m){
    int mult = m * m * m;
    //Console.WriteLine($"размер одномерного массива: {mult}");
    double[] arr = new double[mult];
    int [,,] array = new int[m, m, m];
    int e = 0;

    for (int i = 0; i < m; i++){
        for (int j = 0; j < m; j++){
            int kReturn = 0;
            for (int k = 0; k < m; k++){
                array[i, j, k] = new Random().Next(10,100);
                
                int c = 0;
                kReturn = 0;
                //Console.WriteLine($"while: {e}  - {i}, {j}, {k} - {array[i, j, k]}");
                while (c < e + 1){
                        if (array[i, j, k] == arr[c]){
                        kReturn = 1;
                        //Console.WriteLine($"Проверка была: {i}, {j}, {k}  - {c}, {e}");
                        break;
                    }
                    c++;   
                }

                if (kReturn == 1){
                    //Console.WriteLine($"k было: {k} ");
                    k = k - 1;
                }else{
                    arr[e] = array[i, j, k];
                    e++;
                }   
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

Console.WriteLine("Задайте размер 3-мерного массива m x m x m (1 < m < 5):");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] array = FillMatrix(m);
Console.Write($"Массив размером {m} x {m} x {m}");
Console.WriteLine();

PrintArray(array);

