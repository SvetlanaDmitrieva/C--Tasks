// 26.	Возведите число А в натуральную степень B используя цикл

double numberA, numberDegreeB = 1;
int degreeNumberB = 0;
int flag = 0;
Console.WriteLine("Введите любое число А:");
numberA = Convert.ToDouble(Console.ReadLine());
while (degreeNumberB <= 0)
{
    Console.WriteLine("Введите натуральную степень В для возведения числа:");
    degreeNumberB = Int32.Parse(Console.ReadLine());
    flag++;
    if (flag == 5) { Console.WriteLine("Вы использовали 5 попыток ввода степени В "); return; }
}
for (int i = 1; i <= degreeNumberB; i++)
{
    numberDegreeB = numberDegreeB * numberA;
}
Console.WriteLine("Число {0} в степени {1} равно {2}", numberA, degreeNumberB, numberDegreeB);
