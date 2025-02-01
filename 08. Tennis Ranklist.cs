// Четене на входа
int n = int.Parse(Console.ReadLine());  // Брой турнири
int initialPoints = int.Parse(Console.ReadLine());  // Начален брой точки

// Променливи за резултати
int totalPoints = initialPoints;
int wonTournaments = 0;
int totalPointsFromTournaments = 0;

// Четене на резултатите от турнирите и изчисляване на точките
for (int i = 0; i < n; i++)
{
    string stage = Console.ReadLine();  // Резултат от турнира ("W", "F", "SF")

    if (stage == "W")
    {
        totalPoints += 2000;
        wonTournaments++;
        totalPointsFromTournaments += 2000;
    }
    else if (stage == "F")
    {
        totalPoints += 1200;
        totalPointsFromTournaments += 1200;
    }
    else if (stage == "SF")
    {
        totalPoints += 720;
        totalPointsFromTournaments += 720;
    }
}

// Изчисляваме средните точки и процента спечелени турнири
double averagePoints = totalPointsFromTournaments / (double)n;
double winPercentage = (double)wonTournaments / n * 100;

// Отпечатваме резултата с подходящото форматиране
Console.WriteLine($"Final points: {totalPoints}");
Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
Console.WriteLine($"{winPercentage:F2}%");