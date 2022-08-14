// Напиштте программу, которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом
Console.WriteLine("Введите пятизначное число");
String N = Console.ReadLine();
Console.WriteLine($"Введенное число {Polindrom(N)}");
String Polindrom (String Number)
{
    int L = Number.Length; // Узнали длину введенной строки или число символов
    if (L != 5)
    {
        string otvet = "не является пятизначным";
        return otvet;
    }
    else
    {
        string Nnaooborot = "";
        for (int i = L; i > 0 ; i--)
        {
           Nnaooborot = Nnaooborot + Number[L]; 
        }
        for (int j = 1; j <= L; j++)
        {
            if (N[j] != Nnaooborot[j])
            {
                string otvet1 = "не является полиндромом";
                return otvet1;
            }
            else
            {
                string otvet2 = "является полиндромом";
                return otvet2;
            }
        }
    }
} 
