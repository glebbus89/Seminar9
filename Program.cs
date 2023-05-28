/*void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
}

ShowNums(5);   
*/

// Task. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int SumOfDigits(int num)
// {
//     if(num != 0) return SumOfDigits(num / 10) + num % 10;
//     return 0;
// }

// Console.WriteLine(SumOfDigits(123));

// Task2. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// void ShowNums2(int m, int n)
// {
//     if(n > m) 
//     {
//         ShowNums2(m, n - 1);
//         Console.Write(n + " ");
//     }
//     if(m > n)
//     {
//         ShowNums2(m, n + 1);
//         Console.Write(n + " ");
//     }
//     if(m == n)
//     {
//         Console.Write(m + " ");
//     }
// }

// // ShowNums2(1, 5);  
// // Решение задачи в три строки
// void ShowNums(int n, int m)
// {
//     Console.Write(n +" ");
//     if(n > m) ShowNums(n - 1, m);
//     if(n < m) ShowNums(n + 1, m);
// }

// ShowNums(2,5);

// Task3. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

// int VozvedStepeni(int a, int b)
// {
// if(b != 0) return VozvedStepeni(a, b - 1) * a;
// return 1;
// }

// Console.WriteLine(VozvedStepeni(2,6));

// Homework.
// Task64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите натуральное число > 1:");
// int num = Convert.ToInt32(Console.ReadLine());

// void ShowNums (int num)
// {
//     if (num < 0) Console.Write($"{num} не натуральное число");
//     if (num == 0) return;
//     Console.Write("{0,4}", num);
//     ShowNums (num - 1);
// }

// ShowNums(num);

// Task66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNums(m, n);

// void ShowNums(int m, int n)
// {
//  Console.Write(summMN(m - 1, n));
// }

// int summMN(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + summMN(m, n);
//         return res;
//     }
// }
// Task68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m,n);

// void AkkermanFunction(int m, int n)
// {
//  Console.Write(Akkerman(m, n)); 
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }






