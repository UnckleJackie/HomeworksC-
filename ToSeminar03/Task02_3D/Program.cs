// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Method()
{
System.Console.WriteLine("Input xa coord: ");
double xa = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input ya coord: ");
double ya = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input za coord: ");
double za = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input xb coord: ");
double xb = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input yb coord: ");
double yb = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input zb coord: ");
double zb = Convert.ToInt32(Console.ReadLine());

double num = Math.Round(Math.Sqrt(Math.Pow(xa - xb ,2) + Math.Pow(ya - yb ,2) + Math.Pow(za - zb ,2)), 2);
System.Console.WriteLine($"A ({xa}, {ya}, {za}), B ({xb}, {yb}, {zb} Расстояние между точками = {num}");
//Math.Round - ограничение кол-ва знаков после запятой
}
Method();
