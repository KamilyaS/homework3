/* Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N 
3-> 1,8,27
5-> 1,8,27,64,125 */

System.Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i<= number)
{
    System.Console.WriteLine(Math.Pow(i, 3));
    i++;
} 