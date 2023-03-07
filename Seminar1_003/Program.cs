// 1/ Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} равен = {sqr1}");

/* Решение с помощью библиотеки
int sqr1 = Convert.ToInt32(Math.Pow(number,2)); - обращение к библиотеке и конвертация к целочисленному 
*/
