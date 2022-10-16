// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//     Console.Clear();
//     int[] RandomArr(int start, int end, int LenghtArr)
//     {
//         int[] arr = new int[LenghtArr];
//         for(int i = 0; i < LenghtArr; i++)
//         {
//             arr[i] = new Random().Next(start, end);
//         }
//         return arr;
//     }
//     int[] array = RandomArr(100, 999, 4);
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }

//     int EvenNumber = 0;    
// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] % 2 == 0) {EvenNumber +=1;}
// }

//  Console.WriteLine();
//  Console.WriteLine($"Четных чисел в массиве:  {EvenNumber}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//     int[] RandomArr(int start, int end, int LenghtArr)
//     {
//         int[] arr = new int[LenghtArr];
//         for(int i = 0; i < LenghtArr; i++)
//         {
//             arr[i] = new Random().Next(start, end);
//         }
//         return arr;
//     }
//     int[] array = RandomArr(10, 100, 10);
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }

//     int oddNamber = 0;    
// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i] % 2 != 0) oddNamber += array[i];
// }

//  Console.WriteLine();
//  Console.WriteLine($"Сумма нечетных чисел:  {oddNamber}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//         double[] arrayInputDouble()
//         {       
//         Console.WriteLine("Массив из какого количества элементов задать?");
//         int count = Convert.ToInt32(Console.ReadLine());
//         double[] array = new double[count];
//         for(int i = 0; i < array.Length; i++)
//         {
//             array[i] = new Random().Next(-100, 100);
//         }
//         return array;
//         }
//     void arrayOutput(double[] array)
//     {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
//     }
// double difMinMax(double[] array)
// {
//     double min = array[0];
//     double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min) min = array[i];
//         else if (array[i] > max) max = array[i];
//     }
//     Console.WriteLine($" Максимальное число массива:  {max}");
//     Console.WriteLine($" Минимальное число массива:  {min}");
//     double diff = max - min;
//     return diff;
// }
//     double[] array = arrayInputDouble();
//     arrayOutput(array);
//     Console.WriteLine($" Разница MAX и MIN: {difMinMax(array)} ");
