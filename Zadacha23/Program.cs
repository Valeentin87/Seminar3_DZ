// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ниже представлена таблица кубов от 1 до {N}: {Kub(N)}");
string Kub(int Number)
{
    string tablisaKubov = "";
    for(int i = 1; i <= N; i++)
    {
        tablisaKubov = tablisaKubov + "\n" + Convert.ToString(Math.Pow(i,3));
    }
    return tablisaKubov;
}
