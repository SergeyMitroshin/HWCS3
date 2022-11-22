/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число");
int arg = int.Parse(Console.ReadLine());
string result = "";
int i=1;
while (i<=arg)
{
    result=result+ Math.Pow(i,3) + " ";
    i++;
}

 Console.WriteLine(result);