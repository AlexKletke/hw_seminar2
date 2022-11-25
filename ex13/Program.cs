// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

using static System.Console;

WriteLine("введи трехзначное число: ");
int N = int.Parse(ReadLine());
int A = N%10;

if (N/100 == 0)
{
    WriteLine("третьей цифры нет");
}
else
{
    WriteLine(A);
}
