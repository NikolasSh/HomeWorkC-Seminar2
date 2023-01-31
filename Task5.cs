/*
Напишите программу, которая принимает на вход трёхзначное число и на 
выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetNumber()
{
    Random rnd = new Random();
    int result = rnd.Next(100, 1000); 
    return result;
}

// получить максимальную цифру числа 
int FindingTheSecondDigit(int number)
{   // 145                
    int firstDigit = number / 10; // 14,5 -> без остатка 1 
    int SecondDigit = firstDigit % 10; // 1,4 -> остаток 4
    return SecondDigit;   
}

int number = GetNumber();
int result = FindingTheSecondDigit(number);

Console.WriteLine($"Вторая цифра в числе {number} это: {result}");
