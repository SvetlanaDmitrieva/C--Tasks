// 17.	По двум заданным числам проверять является ли одно квадратом другого

int [] Number= new int [2];
for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Введите {0}-е число :",(i+1));
    Number[i]=Int32.Parse(Console.ReadLine());
}
if(Number[0]==(Number[1]*Number[1]))
    {
    Console.WriteLine("Квадрат второго числа {0,5} равен первому числу {1,5}", Number[1] ,Number[0]);
    return;}
    else
        {if(Number[1]==(Number[0]*Number[0])){
        Console.WriteLine("Квадрат первого числа {0,5} равен второму числу {1,5}", Number[0] ,Number[1]);
        return;} }
if(Number[1]< Number[0]) {Console.WriteLine("Квадрат второго числа {0,5} не равен первому числу {1,5}", Number[1] ,Number[0]);}
    else
    {
        if (Number[0]<Number[1]) {
            Console.WriteLine("Квадрат первого числа {0,5} не равен второму числу {1,5}", Number[0] ,Number[1] ); }
            else
        {
            Console.WriteLine("Первое число {0,5} равно второму {1,5}", Number[0] ,Number[1] );
        }
    }
    