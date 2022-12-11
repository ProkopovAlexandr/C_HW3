int[] Input(string point)
{
Console.WriteLine($"Введите координаты точки {point}:");
int[] coord = new int[3];
Console.WriteLine("X:");
coord[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y:");
coord[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z:");
coord[2] = Convert.ToInt32(Console.ReadLine());
return coord;
}

void Distance(int[] point1, int[] point2)
{
double dist = Math.Pow(Math.Pow(point1[0] - point2[0], 2) + Math.Pow(point1[1] - point2[1], 2) + Math.Pow(point1[2] - point2[2], 2), 0.5);
Console.WriteLine(dist);
}

Distance(Input("A"), Input("B"));