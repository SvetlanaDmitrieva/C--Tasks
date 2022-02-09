// По двум заданным числам проверить, является ли первое квадратом второго
//Console.WriteLine("Hello, World!");
string str;
int number1, number2;
Console.WriteLine("Введите первое число :");
str = Console.ReadLine();
number1=Int32.Parse(str);
Console.WriteLine("Введите второе число :");
str = Console.ReadLine();
number2=Int32.Parse(str);
if(number1==(number2*number2))
    Console.WriteLine("Квадрат второго числа {0,5} равен первому числу {1,5}", number2 ,number1 );
    else
    System.Console.WriteLine("Квадрат второго числа {0,5} не равен первому числу {1,5}", number2 ,number1 );