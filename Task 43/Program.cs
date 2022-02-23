// 43.Написать программу преобразования десятичного числа в двоичное
int numberDecimalToBinary, rest, remainder;
Console.WriteLine("Введите десятичное целое число для преобразования в двоичное:");
numberDecimalToBinary = Math.Abs(Int32.Parse(Console.ReadLine()));
rest = numberDecimalToBinary;
string stringBinary = String.Empty;
while (rest > 0)
{
    remainder = rest % 2;
    rest = rest / 2;
    stringBinary = Convert.ToString(remainder) + stringBinary;
}
Console.WriteLine("Десятичное число {0} преобразовано в двоичное {1}", numberDecimalToBinary, stringBinary);
