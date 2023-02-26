// Задача 2: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// рандомный массив случайных чисел с выводом в печать
void Main()
{
int[] array = new int[4]; // длина массива 4 
Random random = new Random(); // наполняем массив 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 9); // ограничила от -9 до 9 числа 
    }
// Выводим массив в печать  
    Console.Write("Массив: ");
    foreach (int item in array) // перебор по элементам массива в порядке возрастания индекса 
    {
        Console.Write(item + " "); // выводим элементы массива 
    }
Console.WriteLine(); // пустая строка 
Console.WriteLine("Новый массив: " + Replacement(array) + " ");
}

// Замена значений в массиве
int Replacement(int[] array)
{
    int placement = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        placement = -array[i];
        i++;
    }
    return placement;
}
Main();