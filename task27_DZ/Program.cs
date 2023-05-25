// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int InPutNum(string str)
{
    int num =0;
    System.Console.Write(str);
    try
    {
        num = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Что-то пошло не так!");
    }
    Console.WriteLine($"Сумма цифр числа {num}");
    return num;
}
void SumNum (int num)
{
    int sum=0;
    while(num!=0)
    {
        sum += num % 10;
        num /= 10;
    }
    Console.WriteLine($" равна {sum} ");
}
int u_num = InPutNum($"Введите число:");
SumNum(u_num);


















