// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Введите целое число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int numberA = 0;
while(numberA < numberB - 1)
{
    numberA += 2;
    System.Console.Write(numberA + ", ");
}