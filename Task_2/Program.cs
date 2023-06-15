Console.WriteLine(" Введите число");
string a = Console.ReadLine();
int a1 = Convert.ToInt32(a);

if (a1 < 100)
{
     Console.Write($"Третьей цифры нет");
    
}

if (a1 >= 100 & a1 < 1000)
{
     int x = a1 % 10;
           Console.Write($"Искомое число {x}");
}
if (a1 > 999)
    { while (a1 > 999)
        {
           a1 /= 10;
        }
        int n = a1 % 10;
        Console.Write($"Искомое число {n}");
    }

