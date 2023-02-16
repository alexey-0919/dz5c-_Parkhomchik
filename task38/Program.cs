/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

/* Решил сам */

/* Console.WriteLine("Input Length array");
int size = Convert.ToInt32(Console.ReadLine());
double [] Arr = new double [size];
Random rnd = new Random();
for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = Convert.ToDouble(rnd.Next(100, 1000)) / 100;
    Console.Write(Arr[i] + "    ");
}
Console.WriteLine();

double min = 1000;
double max = 0;

for (int i = 0; i < Arr.Length; i++)
{
    if (Arr[i] > max)
        max = Arr[i];
    
    if (Arr[i]< min)
        min = Arr[i];
    
}
Console.WriteLine($"всего {Arr.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}"); */


/* Применил из интернета */

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] Arr = new double[size];
FillArrayRandomNumbers(Arr);
Console.WriteLine("массив: ");
PrintArray(Arr);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < Arr.Length; i++)
{
    if (Arr[i] > max)
        {
            max = Arr[i];
        }
    if (Arr[i] < min)
        {
            min = Arr[i];
        }
}

Console.WriteLine($"всего {Arr.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] Arr)
{
    for(int i = 0; i < Arr.Length; i++)
        {
            Arr[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] Arr)
{
    Console.Write("[ ");
    for(int i = 0; i < Arr.Length; i++)
        {
            Console.Write(Arr[i] + "  ");
        }
    Console.Write("]");
    Console.WriteLine();
}