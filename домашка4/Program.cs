// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16

//метод возведение числа в степень
/*
int Av ( int a, int b)
{ 
    int s = 1;
    for (int i=1; i <=b; i ++)
    {
        s = s*a;
    }
    return s ;
}
Console.WriteLine("Введите  число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число B");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"число {A} в степени {B} равно {Av(A,B)} ");
*/
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

// метод суммирования цифр в числе
/*
int Av (int n)
{
    int S =0;

    while (n>0)
    {
        S =S+n%10;
        n = n/10;
    }
    return S;
}
Console.WriteLine("Введите  число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма цифр числа {N} равна {Av(N)} ");
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


void PrintArray(int[] array)
{
int count = array.Length;
Console.Write("[");
for (int i = 0; i < count; i++)
{
Console.Write($"{array[i]}, ");
}
Console.WriteLine("\b\b]");
}


Console.WriteLine("Введите 1 число массива ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число массива ");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число массива ");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 4 число массива ");
int a4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 5 число массива ");
int a5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 6 число массива ");
int a6 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 7 число массива ");
int a7 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 8 число массива ");
int a8 = Convert.ToInt32(Console.ReadLine());

int[] arr = {a1, a2, a3, a4, a5, a6, a7, a8};
 PrintArray(arr);
 