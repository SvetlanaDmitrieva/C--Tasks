// 13.	Удалить вторую цифру трёхзначного числа

int Num,Num1,Num2,Num3,Flag=0;
Console.WriteLine("Введите любое положительное трехзначное число :");
Num=Int32.Parse(Console.ReadLine());
while(Num < 100 || Num > 999) {
    Flag++;
    Console.WriteLine("Введеное число должно быть положительным трехзначным .Попытка {0} из 5-ти", Flag+1);
    if(Flag>=5) {
        Console.WriteLine("Вы использовали 5 попыток. Выход из программы");
        return;
    }
    Num=Int32.Parse(Console.ReadLine());
}
Num3=Num%10;
Num2=(Num/10)%10;
Num1=Num/100;
Console.Write("Удалив вторую цифру введенного трехзначного числа {0} - {1}, получим двузначное число {2}",Num,Num2,(Num1*10+Num3) );
 