// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int Input(string msg) // метод ввода данных
{
    System.Console.Write(msg);
    string a = Console.ReadLine();
    int value = int.Parse(a);
    return value;
}
int[] GenArray(int Length, int min, int max) //метод создания массива случайных чисел
{
    int[] array = new int[Length]; // объявление массива
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(min, max + 1); // случайные числа массива
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.Write("["); // начало вывода массива
    for(int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write($"{array[i]},");
    }
    System.Console.Write($"{array[array.Length-1]}");
    System.Console.WriteLine("]"); // конец вывода массива
}
int length = Input("Длинна массива: ");
int min = Input("Минимально значение в массиве: ");
int max = Input("Максимальное значение в массиве: ");
int [] array = GenArray(length, min, max);
PrintArray(array);