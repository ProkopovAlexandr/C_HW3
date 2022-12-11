Console.WriteLine("Введите пятизначное число:");
string num = Console.ReadLine();

void Pol(string inpute)
{
   
    if (inpute[0] == inpute[4] && inpute[1] == inpute[3])
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }

}

Pol(num);