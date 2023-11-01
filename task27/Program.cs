// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int ReadInt(string msg) //объявляем функцию readint и строковый параметр msg
{
    System.Console.Write(msg);
    string a = Console.ReadLine(); // Ввод данных в консоли
    int value = int.Parse(a);
    return value; //возврат из функции значения value
}
int a = ReadInt("Введите число: ");
int sum = 0; //начальная сумма

while (a > 0)//Цикл до тех пор пока b не станет равно 0
{
    int num = a%10;
    a = a/10;
    sum= num +sum;
}
Console.Write("Сумма цифр в числе равна " +sum);
