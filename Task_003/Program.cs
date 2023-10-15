//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

System.Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32 (Console.ReadLine());
if (number>0 && number<8)
{
    if (number == 6 || number == 7)
    {
        System.Console.Write("Да");
    }
    else 
    {
        System.Console.Write("Нет");
    }
}
else 
{
    System.Console.Write("Такого дня недели не существует");
}