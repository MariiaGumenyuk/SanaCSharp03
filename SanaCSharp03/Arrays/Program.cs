﻿using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
int n;
Console.Write("Введіть N кількість чисел: ");
n = int.Parse(Console.ReadLine());
double[] array = new double[n];
double sum_dec = 0, max_elem = 0, i_max_elem = 0, max_abc = 0, sum = 0, int_count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write("[{0}]: ", i);
    array[i] = double.Parse(Console.ReadLine());

}
for (int i = 0; i < n; i++)
{

    if (max_elem < array[i])
    {
        max_elem = array[i];
        i_max_elem = i;
    }

    if (Math.Abs(max_abc) < Math.Abs(array[i]))
    {
        max_abc = array[i];
    }

    if (array[i] % 1 == 0)
    {
        int_count++;
    }
    if (array[i] < 0)
    {
        sum_dec += array[i];
    }
    if (array[i] > 0)
    {
        sum += i;
    }

}

for (int i = 0; i < n; i++)
{

    Console.WriteLine("[{0}]{1}", i, array[i]);
}
Console.WriteLine("Cума від’ємних елементів масиву: {0}\n" +
    "Максимальний елемент масиву: {1}\n" +
    "Номер (індекс) максимального елемента масиву: {2}\n" +
    "Максимальний за модулем елемент масиву: {3}\n" +
    "Сума індексів додатних елементів: {4}\n" +
    "Кількість цілих чисел у масиві:{5}\n", sum_dec, max_elem, i_max_elem, max_abc, sum, int_count);