//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("Задайте размер массива, заполненного случайными положительными трёхзначными числами: ");
int arrLen = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[arrLen];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(100, 1000);
}
int res = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        res++;
    }
}
Console.WriteLine(" ");
Console.WriteLine("***Ответ***");
Console.WriteLine($"Количество четных чисел в массиве [{string.Join((", "), arr)}] равно {res}.");
