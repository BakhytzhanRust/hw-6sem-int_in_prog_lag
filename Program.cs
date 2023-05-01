// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// // 0, 7, 8, -2, -2 -> 2

// // 1, -7, 567, 89, 223-> 3

// int Prompt(string message)
// {
//   Console.Write(message);
//   string value = Console.ReadLine();
//   int result = Convert.ToInt32(value);
//   return result;
// }

// int[] InputArray(int length)
// {
//   int[] array = new int[length];
//   for (int i = 0; i < array.Length; i++)
//   {
//     array[i] = Prompt($"Please, write №{i + 1}  number ");
//   }
//   return array;
// }

// void PrintArray(int[] array)
// {
//   for (int i = 0; i < array.Length - 1; i++)
//   {
//     Console.Write($"array[{i}] -> {array[i]}, ");
//   }
//   Console.WriteLine($"array[{array.Length - 1}] -> {array[array.Length - 1]}");
// }

// int CountPositiveNumber(int[] array)
// {
//   int count = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] > 0)
//     {
//       count++;
//     }
//   }
//   return count;
// }
// int length = Prompt("Enter amount of numbers ");
// int[] array;
// array = InputArray(length);
// PrintArray(array);
// Console.WriteLine($"Amount of numbers > 0 -> {CountPositiveNumber(array)}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Если обращаться к формулах, путём вычисления пришёл, что x точки пересечения = (b2 - b1)/(k2 - k1), y - k1(b2 - b1)/(k1-k2) + b1;
// int Prompt(string message)
// {
//   Console.Write(message);
//   string value = Console.ReadLine();
//   int result = Convert.ToInt32(value);
//   return result;
// }

// double FindX(double k1, double k2, double b1, double b2)
// {
//   double x = 1;
//   x = (b2 - b1) / (k1 - k2);
//   return x;
// }

// double FindY(double k1, double k2, double b1, double b2)
// {
//   double y = 1;
//   y = k1 * (b2 - b1) / (k1 - k2) + b1;
//   return y;
// }

// void PrintArray(double k1, double k2, double b1, double b2, double x, double y)
// {
//   Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");
// }

// int b1 = Prompt("Write b1 ");
// int k1 = Prompt("Write k1 ");
// int b2 = Prompt("Write b2 ");
// int k2 = Prompt("Write k2 ");
// if (k1 == k2 && b1 != b2)
// { Console.WriteLine("straight parallel");
// }
// else if (k1 == k2 && b1 == b2)
// { Console.WriteLine("straight lines match"); }
// else
// {double x = Math.Round(FindX(k1, k2, b1, b2),2);
// double y = Math.Round(FindY(k1, k2, b1, b2),2);
// PrintArray(k1, k2, b1, b2, x, y);}

