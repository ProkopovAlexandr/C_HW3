Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int[] Cub(int num)
{
    int[] arr = new int[n];
    int i = 1;
    while(i <= n)
    {
        arr[i-1] = i*i*i;
        i++;
    }
    return arr;
}

void Array(int[] ar)
{
    int i = 0;
    Console.Write("[");

    while(i < n)
    {
        if (i < n - 1)
        {
        Console.Write($"{ar[i]},");
        }
        else
        {
            Console.Write($"{ar[i]}");
        }
        i++;
    }
        Console.Write("]");

}

Array(Cub(n));