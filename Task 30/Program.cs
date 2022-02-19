//30.	Показать кубы чисел, заканчивающихся на четную цифру
int number1;
Console.WriteLine("Введите любое число :");
number1 = Int32.Parse(Console.ReadLine());
if (number1 % 2 == 0)
    Console.WriteLine("Куб числа {0} равен {1} и заканчивается на четную цифру"
                    , number1, number1 * number1 * number1);
else Console.WriteLine("Куб введенного числа {0} равен {1}, заканчивается на нечетную цифру"
                    , number1, number1 * number1 * number1);
