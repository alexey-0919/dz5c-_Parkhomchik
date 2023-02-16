
/* 
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.WriteLine("Input Length array");
int size = Convert.ToInt32(Console.ReadLine());
int [] Arr = new int [size];
Random rnd = new Random();
for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = rnd.Next(0, 20);
    Console.Write(Arr[i] + "    ");
}
Console.WriteLine();

int sum = 0;

for (int i = 0; i < Arr.Length; i = i + 2 )
{
    sum = sum + Arr[i];
}

Console.WriteLine("Сумма = " + sum);