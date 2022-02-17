// 9.	Показать четные числа от 1 до N

int Num, Flag = 0;
Console.WriteLine("Введите любое число :");
Num = Int32.Parse(Console.ReadLine());
while (Num <= 1)
{
    Console.WriteLine("Введеное число {0} меньше 2.Повторите ввод", Num);
    Flag++;
    if (Flag >= 5)
    {
        Console.WriteLine("Вы использовали 5 попыток. Выход из программы");
        return;
    }
    Num = Int32.Parse(Console.ReadLine());
}
Console.Write("Четные числа от 1 до {0} :", Num);
for (int i = 2; i <= Num; i = i + 2)
{
    Console.Write("{0} ", i);
}