Console.Clear();
Console.Write("Введите координату x первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x1-x2,2)) + (Math.Pow(y1-y2,2))));

