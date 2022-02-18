// 15-2	Дано число. Проверить кратно ли оно 7 и 23

int Num;
Console.WriteLine("Введите любое число :");
Num = Int32.Parse(Console.ReadLine());
if (Num % 7 == 0) { Console.Write("Введеное число {0} кратно 7", Num); }
else
{
    Console.Write("Введеное число {0} не кратно 7", Num);
}
if (Num % 23 == 0) { Console.Write(" и кратно 23"); }
else
{
    Console.Write(" и не кратно 23");
}
