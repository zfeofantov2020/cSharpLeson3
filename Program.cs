// Задача 19

// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821-> да

// 23432 -> да
//////////////////////////////////////////////////////////////////////////////////////////////////
// Console.Clear();
// Console.WriteLine("Task19");
// Console.WriteLine("Insert 5 digit number");
// int num = Convert.ToInt32(Console.ReadLine());
// int num1 , num2 ,num3 ,num4 ,num5 ,num6 = 1;
// if (num < 9999 || num > 99999)
//     {
//         Console.WriteLine("Inserted wrong number , try again");
//     }
// num1 = num / 1000;
// num2 = num % 100;
// num3 = num1 / 10;
// num4 = num1 % 10; 
// num5 = num2 / 10;
// num6 = num2 % 10; 

// if(num3 == num6 || num4 == num5)

//     {
//         Console.WriteLine("TRUE");
//     }
// else 
//     {
//         Console.WriteLine("FALSE");
//     }
//////////////////////////////////////////////////////////////////////////////////////////////////
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

///////////
///(21 / 1)
// Console.Clear();
// Console.WriteLine("Task21");
// Console.WriteLine("Insert X1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert Y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert Z1");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert X2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert Y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert Z2");
// int z2 = Convert.ToInt32(Console.ReadLine());
// double d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
// Console.WriteLine(d);

//////////////////////////////////////////////////////////////////////////////////////////////////

// Напишите программу, которая принимает на вход число
// (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Clear();
// Console.WriteLine("Task23");
// Console.WriteLine("Insert Number");

// int num = Convert.ToInt32(Console.ReadLine());

// for(int i = 1; i < num +1  ; i++)
//     {
//         double cub = Math.Pow(i,3);
//         if(i==1)
//             {
//                 Console.Write($"->"); 
//             }
//         else
//         Console.Write($"{cub},"); 
//     }