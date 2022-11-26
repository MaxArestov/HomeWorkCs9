// Задача 68: Напишите метод вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
Console.WriteLine("Введите число m:");
int m = GetNumber();
if (m > 3)
{
    Console.WriteLine("Слишком большое значение m, риск вызова Stack Overflow! Попробуйте значение менее 4.");
    Console.ReadKey();
    return;
}
Console.WriteLine("Введите число n:");
int n = GetNumber();
if (n > 11)
{
    Console.WriteLine("Слишком большое значение n, риск вызова Stack Overflow! Попробуйте значение менее 11.");
    Console.ReadKey();
    return;
}
int ackerman = AckermanFunc(m, n);
Console.WriteLine($"Функция Аккермана чисел {m} и {n} равна {ackerman}");



int AckermanFunc(int x, int y)
{
    if (x == 0)
    {
        return (y + 1);
    }
    else if ((x > 0) && (y == 0))
    {
        return AckermanFunc(x - 1, 1);
    }
    else
    {
        return AckermanFunc(x - 1, AckermanFunc(x, y - 1));
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