// 28.	Подсчитать сумму цифр в числе
int numberAny, rest, sumDigits = 0;
Console.WriteLine("Введите любое целое число :");
numberAny = (Int32.Parse(Console.ReadLine()));
rest = Math.Abs(numberAny);
while (rest > 0)
{
    sumDigits = sumDigits + rest % 10;
    rest = rest / 10;
}
Console.WriteLine("Сумма цифр в  числ {0} - {1}", numberAny, sumDigits);
