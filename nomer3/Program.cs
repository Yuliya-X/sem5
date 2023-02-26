// Задача 3: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// рандомный массив случайных чисел с выводом в печать
void Main()
{
int[] array = new int[5]; // длина массива 5 
Random random = new Random(); // наполняем массив 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 999); // ограничила от -9 до 9 числа 
    }
// Выводим массив в печать  
    Console.Write("Массив: ");
    foreach (int item in array) // перебор по элементам массива в порядке возрастания индекса 
    {
        Console.Write(item + " "); // выводим элементы массива 
    }
Console.WriteLine(); // пустая строка 
// Console.WriteLine("Новый массив: " + Replacement(array) + " ");
}

int Find(int[] array);
{
    for (int i = 0; i < array.Length; i++)
}
Main();