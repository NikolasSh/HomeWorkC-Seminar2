/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */


Console.WriteLine("Введите день недели от 1 до 7 :");
int DayOfWeeks = Convert.ToInt32(Console.ReadLine());

if (DayOfWeeks == 6 || DayOfWeeks == 7)
{
    Console.WriteLine("Сегодня выходной!");
}
else if (DayOfWeeks > 7)
{
    Console.WriteLine("Вы ввели неверное число!");
}
else Console.WriteLine("Сегодня рабочий день!");