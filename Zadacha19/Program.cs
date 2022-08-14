// Напишbте программу, которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом
Console.WriteLine("Введите пятизначное число");
String N = Console.ReadLine();
Console.WriteLine($"Введенное число {Polindrom(N)}");
String Polindrom (String Number)
{
    int L = Number.Length; // Узнали длину введенной строки или число символов
    int marker = 0;
    string Nnaooborot = "";
    if (L != 5)
    {
        string otvet = "не является пятизначным";
        return otvet;
    }
    else
    {
        for (int i = L; i > 0 ; i--)
        {
           Nnaooborot = Nnaooborot + Number[i-1]; 
        }
        for (int j = 1; j < L; j++)
        {
            if (N[j] != Nnaooborot[j])
            {
                marker = 1;
                
            }
            else
            {
                if (j == L) 
                {
                marker = 2;
                }
                else marker = 3;

                
            }
        }
    }
    if (marker == 1) 
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





