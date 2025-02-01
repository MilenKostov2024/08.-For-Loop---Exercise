int n = int.Parse(Console.ReadLine());

// Променливи за броя на катерачите за всеки връх
double musala = 0;
double montblan = 0;
double kilimanjaro = 0;
double k2 = 0;
double everest = 0;

// Променлива за общия брой катерачи
double totalClimbers = 0;

// Четем броя на хората в групите и разпределяме по върховете
for (int i = 0; i < n; i++)
{
    int groupSize = int.Parse(Console.ReadLine());
    totalClimbers += groupSize;

    if (groupSize <= 5)
        musala += groupSize;
    else if (groupSize <= 12)
        montblan += groupSize;
    else if (groupSize <= 25)
        kilimanjaro += groupSize;
    else if (groupSize <= 40)
        k2 += groupSize;
    else
        everest += groupSize;
}

// Изчисляваме процентите
Console.WriteLine($"{(musala / totalClimbers) * 100:F2}%");
Console.WriteLine($"{(montblan / totalClimbers) * 100:F2}%");
Console.WriteLine($"{(kilimanjaro / totalClimbers) * 100:F2}%");
Console.WriteLine($"{(k2 / totalClimbers) * 100:F2}%");
Console.WriteLine($"{(everest / totalClimbers) * 100:F2}%");