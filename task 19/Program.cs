/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
14212 -> no
23432 -> yes
12821 -> yes */

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[5];

if (array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine($"{number} - palindrome");
}
else
{
    Console.WriteLine($"{number} - not palindrome");
}

