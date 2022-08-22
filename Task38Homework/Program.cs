//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("Задайте размер массива со случайными числами: ");
int arrLen = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива: ");
double minArrValue = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива: ");
double maxArrValue = Convert.ToDouble(Console.ReadLine());
double[] arr = new double[arrLen];
Random rand = new Random();
int i = 0;
arr[i] = rand.NextDouble() * (maxArrValue - minArrValue) + minArrValue;
double maxValue = arr[0];
double minValue = arr[0];
for (i = 1; i < arr.Length; i++)
{
    arr[i] = rand.NextDouble() * (maxArrValue - minArrValue) + minArrValue;
    if (arr[i] > maxValue)
    {
        maxValue = arr[i];
    }
    else if (arr[i] < minValue)
        {
            minValue = arr[i];
        }
}
double diff = maxValue - minValue;
Console.WriteLine(" ");
Console.WriteLine("***Ответ***");
Console.WriteLine($"Разница между максимальным ({maxValue}) и минимальным ({minValue}) элементом массива [{string.Join((" "), arr)}] составляет {diff}");



// Console.WriteLine("Задайте размер массива со случайными числами: "); //(Воспринимается приятнее:) С Math.Round для указанием количества знаков после запятой)
// int len = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Обозначте количество знаков после запятой для случайных чисел: ");
// int decimalPlaces = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива: ");
// double minArrValue = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива: ");
// double maxArrValue = Convert.ToDouble(Console.ReadLine());
// double[] arr = new double[len];
// Random rand = new Random();
// int i = 0;
// arr[i] = Math.Round(rand.NextDouble() * (maxArrValue - minArrValue) + minArrValue, decimalPlaces, MidpointRounding.AwayFromZero);
// double maxValue = arr[0];
// double minValue = arr[0];
// for (i = 1; i < arr.Length; i++)
// {
//     arr[i] = Math.Round(rand.NextDouble() * (maxArrValue - minArrValue) + minArrValue, decimalPlaces, MidpointRounding.AwayFromZero);
//     if (arr[i] > maxValue)
//     {
//         maxValue = arr[i];
//     }
//     else if (arr[i] < minValue)
//         {
//             minValue = arr[i];
//         }
// }
// double diff = maxValue - minValue;
// Console.WriteLine(" ");
// Console.WriteLine("***Ответ***");
// Console.WriteLine($"Разница между максимальным ({maxValue}) и минимальным ({minValue}) элементом массива [{string.Join((" "), arr)}] составляет {diff}");
