// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = {6, 7, 3, 6};
int[] resArray = new int[(array.Length + 1) / 2];
for (int i = 0; i < resArray.Length; i++)
{
    resArray[i] = array[i] * array[array.Length - 1 - i];
}
if (array.Length % 2 == 1)
{
    resArray[resArray.Length - 1] = array[array.Length / 2];
}
Console.WriteLine(string.Join(", ", resArray));



// int[] array = new int[10];
// Random rand = new Random();
// int i = 0;
// for (i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-9, 10);
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine(" ");

// for (i = 0; i < array.Length / 2; i++)
// {
//     int N = array[i] * array[array.Length - 1 - i];
//     Console.Write(N + " ");
// }
// if (array.Length % 2 == 1)
// {
//     if (array[i] == array[(array.Length - 1) / 2])
//     {
//         Console.Write(string.Join(" ", array[i]));
//     }
// }
