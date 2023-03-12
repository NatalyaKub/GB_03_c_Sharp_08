// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Не усмела додумать как по-другому написать, и как сделать универсальный (для других значении m) :/ . 

int[,] FillMatrix(int m){
    int [,] array = new int[m, m];
    int numb = 0;

    // Первая строка (слева направа)
    for(int i = 0, j = 0; j < m; j++){
        numb++;
        array[i, j] = numb;;
    }
    // Последний столбец (кроме первой и последней строки) (сверху вниз)
    for(int i = 1, j = m-1; i < m-1; i++){
        numb++;
        array[i, j] = numb;;
    }

    // Последняя строка (справа налево)
    for(int i = m-1, j = m-1; j >= 0; j--){
        numb++;
        array[i, j] = numb;;
    }

    // Первый столбец (кроме первой и последней строки) (снизу вверх)
    for(int i = m-2, j = 0; i > 0; i--){
        numb++;
        array[i, j] = numb;
    }

    // Вторая строка (кроме первой и последней строки)(слева направа)
    for (int i = 1, j = 1; j < m-1; j++){
            numb++;
            array[i, j] = numb;;
    }

    // Третья строка (кроме первой и последней строки) (справа налево)
    for (int i = 2, j = m-2; j >= 1; j--){
            numb++;
            array[i, j] = numb;;
    }
    return array;
}

void PrintArray(int[,] arr){
    // Method code.
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            if(arr[i,j] >= 0 && arr[i,j] <= 9){
                Console.Write($"0{arr[i,j]} ");
            }else{
                Console.Write($"{arr[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}

// Console.WriteLine("Задайте размер двумерного массива m x m:");
// int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Размер двумерного массива m x m: 4 x 4");
int m = 4;
Console.WriteLine();

int[,] array = FillMatrix(m);
PrintArray(array);
Console.WriteLine();
