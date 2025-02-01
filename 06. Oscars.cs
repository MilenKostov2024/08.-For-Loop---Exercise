string actorName = Console.ReadLine(); // Име на актьора
double actorPoints = double.Parse(Console.ReadLine()); // Първоначални точки на актьора
int n = int.Parse(Console.ReadLine()); // Брой оценяващи

// Променлива за общите точки
double totalPoints = actorPoints;

// Обработка на точките от оценяващите
for (int i = 0; i < n; i++)
{
    string evaluatorName = Console.ReadLine(); // Име на оценяващия
    double evaluatorPoints = double.Parse(Console.ReadLine()); // Точки от оценяващия

    // Пресмятане на новите точки за актьора
    totalPoints += (evaluatorName.Length * evaluatorPoints) / 2.0;

    // Ако точките надхвърлят 1250.5, актьорът получава номинация
    if (totalPoints > 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:F1}!");
        return; // Прекратяваме програмата, защото актьорът вече има номинация
    }
}

// Ако не е достигнат необходимият брой точки
double neededPoints = 1250.5 - totalPoints;
Console.WriteLine($"Sorry, {actorName} you need {neededPoints:F1} more!");
