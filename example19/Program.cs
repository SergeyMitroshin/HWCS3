/* 
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Введите число");
string str = Console.ReadLine();
int i=0;
int j= str.Length-1;
bool result = false;
while (i<j)
    {
    if (str[i] != str[j])
        { result = false;
        break;}
    result=true;
    i++;
    j--; }
if (result == false) Console.WriteLine ("нет");
    else Console.WriteLine("да");



