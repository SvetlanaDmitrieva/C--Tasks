// 27.	Определить количество цифр в числе
int numberAny, rest, counterDigits = 0;
Console.WriteLine("Введите любое целое число :");
numberAny = (Int32.Parse(Console.ReadLine()));
rest = Math.Abs(numberAny);
while (rest > 0)
{
    rest = rest / 10;
    counterDigits++;
}
rest = counterDigits % 10;
if (rest == 1)
{
    Console.WriteLine("В числе {0} - {1} цифра.", numberAny, counterDigits);
    return;
}
if (rest > 1 && rest < 5)
{
    Console.WriteLine("В числе {0} - {1} цифры.", numberAny, counterDigits);
}
else Console.WriteLine("В числе {0} - {1} цифр.", numberAny, counterDigits);
