
Console.WriteLine("Задание №1");
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int f = 1;
for (int i = 1; i <= n; i++)
{
    f *= i;
}
Console.WriteLine($"Факториал числа {n} равен {f}");



Console.WriteLine("Задание №2");
Console.Write("Введите число x: ");

double x = double.Parse(Console.ReadLine());
if (x == 5)
{
    Console.WriteLine("Ошибка: Деление на ноль");
    return;
}

double A = Math.Sqrt(Math.Log(x / (x - 5))) + (x + Math.Pow(Math.E, x - 1)) - Math.Pow(Math.Tan(x / 2),2);

Console.WriteLine("Ответ на выражение: " + A);



Console.WriteLine("Задание №3");
Console.Write("Введите число n: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("0");
Console.WriteLine("1");

int odin = 0;
int dva = 1;
int next = odin + dva;

while (next <= n1)
{
    Console.WriteLine(next);
    odin = dva;
    dva = next;
    next = odin + dva;
}
Console.WriteLine("Конец последовательности");




Console.WriteLine("Задание №4");
Console.WriteLine("Вычисление e^(x-1) с помощью ряда Тейлора");

Console.Write("Введите x: ");
double x1 = double.Parse(Console.ReadLine());

Console.Write("Введите количество членов ряда m: ");
int m = int.Parse(Console.ReadLine());

double sum = 0;
double x11 = 1; 

for (int k = 1; k < m; k++)
{
    x11 *= x / k; 
    sum += x11;
}

sum *= Math.Exp(-1);


Console.WriteLine($"Ответ: e^x = {sum}");

