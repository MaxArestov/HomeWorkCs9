// Задача 64: Задайте значение N. 
// Напишите метод, который выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
Console.Clear();
Console.WriteLine("Введите число N:");
int N = GetNumber();
Console.Write("[");
FromNTo1(N);


void FromNTo1(int x)
{
    if (x > 0)
    {
        if (x != 1)
        {
            Console.Write($"{x}, ");
            FromNTo1(x - 1);
        }
        else
        {
            Console.Write($"{x}]");
        }
    }
}

int GetNumber()
{
    int num = new int();
    bool check = true;
    while (check)
    {
        bool parsed = int.TryParse(Console.ReadLine(), out num);
        if (!parsed)
        {
            Console.WriteLine("Введены некорректные данные. Введите натуральное число:");
        }
        else
        {
            if (num < 0)
            {
                num *= -1;
            }
            check = false;
        }
    }
    return num;
}