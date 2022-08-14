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
