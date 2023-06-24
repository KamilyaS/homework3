/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
А(3,6,8); В(2,1,-7) -> 15.84
A(7,-5,0); B(1,-1,9) -> 11.53 */

int[] aCoordinate = new int[3];
Console.WriteLine("Enter the first point of X: ");
aCoordinate[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the first point of Y: ");
aCoordinate[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the first point of Z: ");
aCoordinate[2] = Convert.ToInt32(Console.ReadLine());
int[] bCoordinate = new int[3];
Console.WriteLine("Enter the first point of X: ");
bCoordinate[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the first point of Y: ");
bCoordinate[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the first point of Z: ");
aCoordinate[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((bCoordinate[0] - aCoordinate[0]), 2) + Math.Pow((bCoordinate[1] - aCoordinate[1]), 2) + Math.Pow((bCoordinate[2] - aCoordinate[2]), 2)),2));
