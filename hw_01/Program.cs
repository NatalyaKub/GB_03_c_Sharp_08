// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

//упорядочить по убыванию элементы каждой строки
int[,] SortElementRowDescendingOder(int[,] array, int m, int n){
    
    for (int i = 0; i < array.GetLength(0); i++){
	    for (int j = 0; j < array.GetLength(1)-1; j++){
		    //int k = 0;
            int max = array[i,j];
            int jn = j;
		    // While (k < n){
			//     if(array[i,j + k] >= max){
	        //         max = array[i,k];
	        //         jn = k;
		    //     }
		    //     k++;
	        // }
            for (int k = 0; j + k < n; k++){
			    if(array[i,j + k] >= max){
	                max = array[i,j + k];
	                jn = j + k;
		        }
	        }
	    int temp = array[i,j];
        array[i,j] = max;
        array[i,jn] = temp;
	    }
    }
    return array;
}

Console.WriteLine("Задайте размер двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = FillMatrix(m, n);
PrintArray(array);
Console.WriteLine();

int [,] arraySort = SortElementRowDescendingOder(array, m, n);
PrintArray(arraySort);
