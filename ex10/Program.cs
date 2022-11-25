// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using static System.Console;

WriteLine("введи трехзначное число: ");
int N = int.Parse(ReadLine());
int A = N%100 / 10;

WriteLine(A);

