// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int ReadInt(string msg) //объявляем функцию readint и строковый параметр msg
{
    System.Console.Write(msg);
    string a = Console.ReadLine(); // Ввод данных в консоли
    int value = int.Parse(a);
    return value; //возврат из функции значения value
}
int a = ReadInt("Введите число A: ");
int b = ReadInt("Введите число B: ");
int degree = 1; //начальная степень

if (b >0)
{
    while (b != 0)//Цикл до тех пор пока b не станет равно 0
    {
        degree = a * degree; 
        b = b - 1;
    }
    Console.Write("Число A в натуральной степени B равно " +degree);
}
else  
{
    Console.Write("Число B должно не является натуральным числом");
}