// Входни данни
int age = int.Parse(Console.ReadLine());
double washingMachinePrice = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

// Променливи за събиране на парите и играчките
double moneySaved = 0;
int toyCount = 0;
int moneyFromBirthdays = 0;

for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0) // Четен рожден ден
    {
        moneyFromBirthdays += 10;
        moneySaved += moneyFromBirthdays - 1; // Отнема 1 лев от брат й
    }
    else // Нечетен рожден ден
    {
        toyCount++;
    }
}

// Добавяне на парите от продадените играчки
moneySaved += toyCount * toyPrice;

// Проверка дали парите са достатъчни
if (moneySaved >= washingMachinePrice)
{
    Console.WriteLine($"Yes! {moneySaved - washingMachinePrice:F2}");
}
else
{
    Console.WriteLine($"No! {washingMachinePrice - moneySaved:F2}");
}