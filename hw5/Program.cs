// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите число которое будет соответвовать количеству элеметов в массиве ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = GetArray(size);



// int[] GetArray(int size)
// {
//     int[] rndArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         rndArray[i] = new Random().Next(100, 1000);
//     }
//     return rndArray;  
// }
// int countArray(int[] array)
// {
//     int sizeArray = array.Length;
//     int count = 0;
//     for (int i = 0; i < sizeArray; i++)
//     {
//         if (array[i]%2==0)
//         {
//             count++;
//         }
//     }
//     return count;
// }
// Console.WriteLine($"исходный массив: [{string.Join(";", array)}]\n\n");
// Console.WriteLine($"Количество элементов : {countArray(array)}");


// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите число которое будет соответвовать количеству элеметов в массиве ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = GetArray(size);



// int[] GetArray(int size)
// {
//     int[] rndArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         rndArray[i] = new Random().Next(9999999);
//     }
//     return rndArray;  
// }

//     int sizeArray = array.Length;
//     int sum = 0;
//     for (int i = 0; i < sizeArray; i++)
//     {
//         GetArray(size);
//         if (i%2!=0)
//         {
//             sum+= array[i];
//         }
//     }

// Console.WriteLine($"исходный массив: [{string.Join(";", array)}]\n\n");
// Console.WriteLine($"Количество элементов : {sum}");



// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Используйте NextDouble().



// Console.WriteLine("Введите число которое будет соответвовать количеству элеметов в массиве ");
// int size = Convert.ToInt32(Console.ReadLine());
// Double[] array = GetArray(size);



// Double[] GetArray(int size)
// {
//     double[] rndArray = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         rndArray[i] = new Random().NextDouble()*100;
//         rndArray[i]= Math.Round(rndArray[i]);


//     }
//     return rndArray;
// }


// double countArray(double[] array)
// {   
//     double sizeArray = array.Length;
//     double min = array[0];
//     double max = array[0];

//     for (int i = 0; i < sizeArray; i++)
//    {    
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//         else if (array[i] > max)
//         {
//             max = array[i];
//         }

//     }
//     var diff = max - min;
//     return diff;
// }
// Console.WriteLine($"исходный массив: [{string.Join(";", array)}]\n\n");
// Console.WriteLine($"Разница между максимальным и минимальным значением в массиве : {countArray(array)}");
