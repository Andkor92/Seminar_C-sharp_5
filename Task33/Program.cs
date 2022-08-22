// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[20];
int result = 0;
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    {
        array[i] = rand.Next(-19, 20);
        if (array[i] == number | array[i] == -number)
        {
            result = 1;
        }
    }
}
Console.WriteLine(string.Join(", ", array));
if (result == 0)
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("да");
}
