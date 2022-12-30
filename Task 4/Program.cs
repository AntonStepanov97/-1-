Console.Clear();
Console.WriteLine("Введите 1-е число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число ");
int x = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (n > max)
{
    max = n; 
}
if (m > max);
{
    max = m;
}
if (x > max);
{
    max = x;
}
Console.Write($"Маcксимальное {max}");
