// Даны два числа. Показать большее и меньшее число
int number1, number2;
Console.WriteLine("Введите первое число :");
number1=Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число :");
number2=Int32.Parse(Console.ReadLine());
if(number1>number2)
    Console.WriteLine("Первое число {0,5} больше второго {1,5}", number1 ,number2 );
    else
    if(number2>number1)
    Console.WriteLine("Второе число {0,5} больше первого {1,5}", number2 ,number1 );
        else
        Console.WriteLine("Второе число {0,5} равно первому {1,5}", number2 ,number1 );
