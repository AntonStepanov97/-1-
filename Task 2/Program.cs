Console.Clear();
Console.WriteLine("Введите 1-е число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число ");
int m = Convert.ToInt32(Console.ReadLine());
if (m < n)
    Console.Write(n);
else
    Console.Write(m);
