﻿// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
// равна 29, сумма отрицательных равна -20.

// Создание массива со случайными числами от [-9 , 9] 
// Нахождение суммы положительных чисел массива
// Нахождение суммы отрицательных чисел

// рандомный массив случайных положительных трёхзначных чисел с выводом в печать 
void Main()
{
int[] array = new int[12]; // длина массива 10 
Random random = new Random(); // наполняем массив 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 9); // ограничила трёхзначные числа 
    }
// Выводим массива в печать  
    Console.Write("Массив: ");
    foreach (int item in array) // перебор по элементам массива в порядке возрастания индекса 
    {
        Console.Write(item + " "); // выводим элементы массива 
    }
Console.WriteLine(); // пустая строка 
Console.WriteLine("Сумма положительных чисел в массиве: " + SumP(array)); 
// пишу count, полученный в Even полностю названием метода 
Console.WriteLine("Сумма отрицательных чисел в массиве: " + SumN(array));
// (если вынести строку вывода результата метода Even из метода Main, теряет связь с array) проверить на другой задаче!
}

// Метод, который возвращает сумму положительных элементов массива
int SumP(int[] array)
{
    int sum = 0;
         for (int i = 0; i < array.Length; i++) // перебираем массив по значениям выше 0, считаем сумму таких чисел 
        {
            if (array[i] > 0)
            {
                sum += array[i];
            }   
        }
        return sum;
}

// Метод, который возвращает сумму отрицательных элементов массива
int SumN(int[] array)
{
    int sum = 0;
         for (int i = 0; i < array.Length; i++) // перебираем массив по значениям ниже 0, считаем сумму таких чисел 
        {
            if (array[i] < 0)
            sum += array[i];
        }
        return sum;
}

Main();