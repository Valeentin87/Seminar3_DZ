// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3Д пространстве
Console.WriteLine("Введите координаты первой точки");
double [] A = new double[3];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Введите координату номер {(i+1)} первой точки");
    A[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("Введите координаты второй точки");
double [] B = new double[3];
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Введите координату номер {(i+1)} второй точки");
    B[i] = Convert.ToDouble(Console.ReadLine());
}

double result = Prostranstvo(A[0], A[1], A[2], B[0], B[1], B[2]);
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {result}");
double Prostranstvo(double x1, double y1, double z1, double x2, double y2, double z2);
{
double rasst = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
return rasst;
}
