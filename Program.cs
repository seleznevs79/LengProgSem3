// Console.Write("Введите день недели: ");
// int number = int.Parse(Console.ReadLine()!);


// switch (number)
// {
// case 6:{
// Console.WriteLine("Это суббота!");
// break;
// }
// case 7:{
// Console.WriteLine("Это воскресенье!");
// break;
// }
// default:{
// Console.WriteLine("Это будний день!");
// break;
// }
// }

// Задача 1: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


// Console.Write("Введите номер координатной четверти: ");
// int number = int.Parse(Console.ReadLine()!);

// switch (number)
// {
// case 1:
// Console.WriteLine("х>0 and y>0");
// break;
// case 2:
// Console.WriteLine("х<0 and y>0");
// break;
// case 3:
// Console.WriteLine("х<0 and y<0");
// break;
// case 4:
// Console.WriteLine("х>0 and y<0");
// break;
// default:
// Console.WriteLine("Такой четверти не существует");
// break;
// }



// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите x точки A: ");
// int xa = int.Parse(Console.ReadLine()!);

// Console.Write("Введите y точки A: ");
// int ya = int.Parse(Console.ReadLine()!);

// Console.Write("Введите x точки B: ");
// int xb = int.Parse(Console.ReadLine()!);

// Console.Write("Введите y точки B: ");
// int yb = int.Parse(Console.ReadLine()!);


// double s = Math.Sqrt(Math.Pow((xb-xa), 2)+Math.Pow((yb-ya), 2));
// Console.WriteLine($"Расстояние между A и B равно {s:f2}");


// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()!);

int index = 1;

while (index <= num)
{
Console.Write(Math.Pow(index, 2));

index++;
}
