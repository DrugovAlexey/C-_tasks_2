Console.Write("Введите цифру, обозначающую день недели: ");
string a = Console.ReadLine();
int a1 = Convert.ToInt32(a);

if (a1 > 7 || a1 < 1)
{
    
    Console.Write($"Неверно введено значение");
}

if (a1 == 6 || a1 == 7)
{
    
    Console.Write($"Да");
}
if (a1 < 6 & a1 > 0)
{
    
    Console.Write($"Нет");
}
