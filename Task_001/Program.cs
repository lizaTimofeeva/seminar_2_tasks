//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

System.Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (99<number && number<1000)
{
    int numberTwo =number/10;
    int numberOne =numberTwo%10;
    System.Console.WriteLine(numberOne);
}
else 
{
    System.Console.Write("Число не трёхзначное");
}