// 25.	Найти сумму чисел от 1 до А
int numberA = 0, flag = 0, sumNumber = 0;
while (numberA <= 0)
{
    Console.WriteLine("Введите любое положительное число А:");
    numberA = Int32.Parse(Console.ReadLine());
    flag++;
    if (flag == 5) { Console.WriteLine("Вы тспользовали 5 возможных попыток"); return; }
}
for (int i = 1; i <= numberA; i++)
{
    sumNumber = sumNumber + i;
}
Console.WriteLine("Сумма чисел от 1 до {0} равна {1}", numberA, sumNumber);
