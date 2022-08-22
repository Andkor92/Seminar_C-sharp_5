// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = new int[12];
Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
    Console.Write(array[i] + " ");
    array[i] *= -1;
}
Console.WriteLine(" ");
Console.WriteLine(string.Join(" ", array));
