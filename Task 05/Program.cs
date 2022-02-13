// 5.	Найти максимальное из трех чисел
int [] arrayNumber= new int [3];
int maxNumber=0, Flag=0;

for (int i = 0; i < arrayNumber.Length; i++)
{
    Console.WriteLine("Введите {0}-е число :",(i+1));
    arrayNumber[i]=Int32.Parse(Console.ReadLine());
    if(i==0) {maxNumber= arrayNumber[i];
        Flag=i+1;
    } 
    else
    {
        if( maxNumber < arrayNumber[i]) {
            maxNumber= arrayNumber[i];
           Flag=i+1;
            } 
    };   
    
    }
Console.WriteLine("{0}-е число {1} является максимальным из введенных", Flag, maxNumber );
    

