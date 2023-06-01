// See https://aka.ms/new-console-template for more information
int delta (int first, int second)
{
    return (second-first);
}

Console.WriteLine("Введите X первой точки: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y первой точки: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z первой точки: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X второй точки: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y второй точки: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z второй точки: ");
int bz = Convert.ToInt32(Console.ReadLine());
int dx=delta(ax,bx);
int dy=delta(ay,by);
int dz=delta(az,bz);
double distance = Math.Sqrt(Math.Pow(dx,2)+Math.Pow(dy,2)+Math.Pow(dz,2));
Console.WriteLine("Расстояние: "+ distance);