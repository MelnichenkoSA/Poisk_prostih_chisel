using System;
using System.Diagnostics;
using System.Threading;

//По определению
while(true)
{
    Console.WriteLine("Введите число");
    int n = Convert.ToInt32(Console.ReadLine());
    bool flag = true;
    for (int i = 2; i < n-1; i++)
    {
        if (n%i == 0)
        {
            flag = false;
        }
    }
    if (flag)
    {
        Console.WriteLine("Простое число");
    }
    else
    {
        Console.WriteLine("Не простое число");
    }
    Console.WriteLine("Перейти к Решету Эратосфена? (Y/N)");
    if (Console.ReadKey().Key == ConsoleKey.Y )
    {
        break;
    }
}




//Решето Эратосфена
Stopwatch stopwatch = new Stopwatch();
while (true)
{
    Console.WriteLine();
    Console.WriteLine("Решето Эратосфена");
    Console.WriteLine("ВВедите число");
    int x = Convert.ToInt32(Console.ReadLine());
    bool[] A = new bool[x];
    
    stopwatch.Start();
    for (int i = 2; i < Math.Sqrt(x)+1; i++)
    {
        if (!A[i])
        {
            for (int j = i * i; j < x; j += i)
            {
                A[j] = true;
            }
        }
    }
    for (int i = 2; i < x; i++)
    {
        if (!A[i])
        {
            Console.WriteLine("{0}", i);
        }
    }
    stopwatch.Stop();
    Console.WriteLine("Время:" + stopwatch.ElapsedMilliseconds);
}