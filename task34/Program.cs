/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.WriteLine("Input Length array");
int size = Convert.ToInt32(Console.ReadLine());
int [] Arr = new int [size];
Random rnd = new Random();
for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = rnd.Next(100, 1000);
    Console.Write(Arr[i] + "    ");
}
Console.WriteLine();

int count = 0;

for (int i = 0; i < Arr.Length; i++)
{
    if (Arr[i] % 2 == 0)
    count = count + 1;
}
Console.WriteLine("Количество = " + count);
