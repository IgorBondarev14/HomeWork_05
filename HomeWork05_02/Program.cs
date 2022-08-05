// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.

Console.WriteLine("Задайте размер массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int sum = 0;
for (int i = 0; i < n; i++)
    {
    array[i] = new Random().Next(100, 1000);
    if (i % 2 != 0)
        sum = sum + array[i];
    }
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Сумма элементов стоящих на нечетных позициях равна " + sum);
