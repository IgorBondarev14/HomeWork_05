// Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
//элементами массива

Console.WriteLine("Задайте размер массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
double max;
double min;
for (int j = 0; j < n; j++)
    array[j] = new Random().Next(0, 1000);
Console.WriteLine("[" + string.Join(", ", array) + "]");
if (array[0] > array[1])
{
    max = array[0];
    min = array[1];
}
else
{
    max = array[1];
    min = array[0];  
}
for (int i = 0; i < n; i++)
{    
    if (array[i] > max)
        max = array[i];
    else
    {
        if (array[i] < min)
            min = array[i];          
    }
}
Console.WriteLine("Минимальное значение массива - " + min + "; Максимальное значение массива - " + max);
double var = max - min;
Console.WriteLine("Разница между минимальным и максимальным значение составляет " + var);
