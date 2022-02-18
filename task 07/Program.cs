/// 7.	Выяснить является ли число чётным
Console.WriteLine("Введите любое число :");
int number1;
number1 = Int32.Parse(Console.ReadLine());
if (number1 % 2 == 0)
{
    Console.WriteLine("Число {0} является четным", number1);
}
else
{
    Console.WriteLine("Число {0} является нечетным", number1);
}
