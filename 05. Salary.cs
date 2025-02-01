int n = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

// Цикъл за проверка на табовете
for (int i = 0; i < n; i++)
{
    string website = Console.ReadLine();

    if (website == "Facebook")
    {
        salary -= 150;
    }
    else if (website == "Instagram")
    {
        salary -= 100;
    }
    else if (website == "Reddit")
    {
        salary -= 50;
    }

    // Проверка дали заплатата е изчерпана
    if (salary <= 0)
    {
        Console.WriteLine("You have lost your salary.");
        return;
    }
}

// Извеждане на остатъка от заплатата
Console.WriteLine(salary);