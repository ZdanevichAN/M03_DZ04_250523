// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.Write("Введите первое число: ");
int num_A = int.Parse(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int num_B = int.Parse(Console.ReadLine());
int pow = num_A;
for(int i=2;i<=num_B;i++)
{
    pow = pow*num_A;
}
System.Console.WriteLine($"Число {num_A} в степени {num_B} равно: {pow}");