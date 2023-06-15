Console.Write("Введите трехзначное число - ");
string a = Console.ReadLine();
int a1 = Convert.ToInt32(a);

int b = a1 / 10;
int c = b % 10;

Console.Write($"Искомое число {c}");
