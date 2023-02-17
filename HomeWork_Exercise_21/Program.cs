int getCoord()
{
    int number;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Требуется числовое значение!");
            continue;
        }
    }
}

Console.WriteLine("Поиск расстояния между двумя точками А и В в 3D пространстве");

Console.Write("Введите координату A(x): ");
int ax = getCoord();
Console.Write("Введите координату A(y): ");
int ay = getCoord();
Console.Write("Введите координату A(z): ");
int az = getCoord();

Console.Write("Введите координату B(x): ");
int bx = getCoord();
Console.Write("Введите координату B(y): ");
int by = getCoord();
Console.Write("Введите координату B(z): ");
int bz = getCoord();

var result = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));

Console.WriteLine($"result = {result:f2}");