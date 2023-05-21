double I = 0;
Console.WriteLine("Введите x:");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y:");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите n:");
double n = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите кол-во элементов:");
double a = Convert.ToDouble(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    I += ((0.8 + 0.2 * Math.Pow(x, 0 + i)) + Math.Sqrt(2 + i + 10 * y)) / (1.6 + 0.6 * Math.Pow(x, 2 + i) + Math.Sin(Math.Pow(x, 0 + i)));
}
Console.WriteLine("Ответ: ");
Console.WriteLine(Convert.ToString(I));