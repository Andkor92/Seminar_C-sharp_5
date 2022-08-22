//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Задайте размер массива со случайными числами: ");
int arrLen = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива: ");
int minArrValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива: ");
int maxArrValue = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[arrLen];
Random rand = new Random();
int i = 0;
for (i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(minArrValue, maxArrValue + 1);
}
int sum = 0;
for (i = 1; i < arr.Length; i += 2)
{
    sum += arr[i];
}
Console.WriteLine(" ");
Console.WriteLine("***Ответ***");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, массива [{string.Join((", "), arr)}] составляет {sum}.");
