Console.Write("Введите значение x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кличество членов ряда n: ");
int n = Convert.ToInt32(Console.ReadLine());
double S = 0;
int sign = 1;
for (int i = 0; i < n; i++)
{
    double term = Math.Pow(x, 2 * i + 1) / Factorial(2 * i + 1);
    S += sign * term;
}
Console.WriteLine($"Сумма первых {n} членов ряда: S={S}");
static double Factorial(int num)
{
    double result = 1;
    for (int i = 2; i <= num; i++)
    {
        result *= i;
    }
    return result;
}
