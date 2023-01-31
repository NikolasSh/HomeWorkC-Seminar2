/*
Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int GetThirddDigit(int number)
{
    while (number >= 1000)
    number = number / 10; 
    return number;
}

int result = GetThirddDigit(number);

if (result >= 100)
{
    Console.WriteLine($"Третьей цифрой числа {number} является цифра {result % 10}");
}
else Console.WriteLine($"У числа {number} нет третьей цифры");



