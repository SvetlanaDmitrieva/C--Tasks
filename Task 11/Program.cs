//11.	Показать вторую цифру трёхзначного числа

int Num, Num1, Flag = 0;
Console.WriteLine("Введите любое положительное трехзначное число :");
Num = Int32.Parse(Console.ReadLine());
while (Num < 100 || Num > 999)
{
    Flag++;
    Console.WriteLine("Введеное число должно быть положительным трехзначным .Попытка {0} из 5-ти", Flag + 1);
    if (Flag >= 5)
    {
        Console.WriteLine("Вы использовали 5 попыток. Выход из программы");
        return;
    }
    Num = Int32.Parse(Console.ReadLine());
}
Num1 = Num / 10;
Console.Write("Вторая цифра введенного трехзначного числа {0} - {1}", Num, (Num1 % 10));
