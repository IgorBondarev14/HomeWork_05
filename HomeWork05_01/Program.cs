// Задайте массив, заполненный случайными положительными трехзначными числами. Напишите программу, 
// которая покажет количество четных чисел в массиве.

Console.WriteLine("Задайте размер массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int count = 0;
for (int i = 0; i < n; i++)
    {
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0)
        count++;
    }
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Данный массив содержит " + count + "четных чисел.");
