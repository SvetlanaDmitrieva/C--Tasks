// 29.	Написать программу вычисления произведения чисел от 1 до N
int numberA = 0, flag = 0, multiplyNumbers = 1;
while (numberA <= 0)
{
    Console.WriteLine("Введите любое положительное число А:");
    numberA = Int32.Parse(Console.ReadLine());
    flag++;
    if (flag == 5) { Console.WriteLine("Вы использовали 5 возможных попыток"); return; }
}
for (int i = 1; i <= numberA; i++) { multiplyNumbers = multiplyNumbers * i; }
Console.WriteLine("Произведение чисел от 1 до {0} равно {1}", numberA, multiplyNumbers);
