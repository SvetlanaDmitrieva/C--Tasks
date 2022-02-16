// 20.	Задать номер четверти, показать диапазоны для возможных координат
int numberQuarter, flag=0;
String [] coordinates = new string [4]{"X > 0 и Y > 0","X < 0 и Y > 0", "X < 0 и Y < 0", "X > 0 и Y < 0 "};
Console.WriteLine("Укажите номер четверти плоскости (от 1 до 4 включительно):");
    numberQuarter=Int32.Parse(Console.ReadLine());
for(int i =0; i< coordinates.Length; i++){
    if(numberQuarter==i+1) {
        Console.WriteLine("Четверти плоскости {0} соответствует следующий диапазон координат: {1}",numberQuarter ,coordinates[i]);
       flag=1;
       return; 
    }

}
if(flag==0) System.Console.WriteLine("Введен неверный номер четверти.");


 //   coordinateY=Double.Parse(sole.ReadLine());


/*Console.WriteLine("Hello, World!");

double coordinateX, coordinateY;плоскости
Console.WriteLine("Введите координату Х:");
    coordinateX=Double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
    coordinateY=Double.Parse(Console.ReadLine());
Console.Write("Номер четверти координатной плоскости : ");
if ((coordinateX > 0) && (coordinateY>0)) {Console.WriteLine("I");return;}
if ((coordinateX < 0) && (coordinateY>0)) {Console.WriteLine("II");return;}
if ((coordinateX < 0) && (coordinateY<0)) {Console.WriteLine("III");return;}
if ((coordinateX > 0) && (coordinateY<0)) {Console.WriteLine("IV");}
    else
        {Console.WriteLine("Точка лежит на оси."); }
*/