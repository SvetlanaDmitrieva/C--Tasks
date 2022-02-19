// 19.	Определить номер четверти плоскости, в которой находится точка 
//   с координатами Х и У, причем X ≠ 0 и Y ≠ 0
double coordinateX, coordinateY;
Console.WriteLine("Введите координату Х:");
coordinateX = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
coordinateY = Double.Parse(Console.ReadLine());
Console.Write("Номер четверти координатной плоскости : ");
if ((coordinateX > 0) && (coordinateY > 0)) { Console.WriteLine("I"); return; }
if ((coordinateX < 0) && (coordinateY > 0)) { Console.WriteLine("II"); return; }
if ((coordinateX < 0) && (coordinateY < 0)) { Console.WriteLine("III"); return; }
if ((coordinateX > 0) && (coordinateY < 0)) { Console.WriteLine("IV"); }
else
{ Console.WriteLine("Точка лежит на оси."); }
