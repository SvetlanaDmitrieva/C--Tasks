//12.	Дано число из отрезка [10, 99]. Показать наибольшую цифру числа


int Num,Num1,Num2,Flag=0;
Console.WriteLine("Введите любое положительное двузначное число :");
Num=Int32.Parse(Console.ReadLine());
while(Num < 10 || Num > 99) {
    Flag++;
    Console.WriteLine("Введеное число должно быть положительным двузначным .Попытка {0} из 5-ти", Flag+1);
    if(Flag>=5) {
        Console.WriteLine("Вы использовали 5 попыток. Выход из программы");
        return;
    }
    Num=Int32.Parse(Console.ReadLine());
}
Num2=Num%10;
Num1=Num/10;
if(Num1>Num2) Console.Write("Первая цифра введенного числа {0} наибольшая - {1}",Num,Num1); 
    else
    {
        if(Num2>Num1) Console.Write("Вторая цифра введенного числа {0} наибольшая - {1}",Num,Num2 );
        else
        {
            {Console.Write("Обе цифры введенного числа {0} равны - {1}",Num,Num2 );
        }
    }
}