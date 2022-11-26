// Задача 66: Задайте значения M и N. 
// Напишите метод, который найдёт сумму натуральных элементов в промежутке от M до N. 
// Через рекурсию!
Console.Clear();
Console.WriteLine("Введите число M (откуда начинается отсчет):");
int M = GetNumber();
Console.WriteLine("Введите число N (до какого числа отсчет):");
int N = GetNumber();
int sum = SumOfElements(M, N);
Console.WriteLine($"Сумма элементов от {M} до {N} равна {sum}");



int SumOfElements(int x, int y)
{
    int sum = 0;
    if (x > y)
    {
        return sum;
    }
    sum += x;
    sum += SumOfElements(x + 1, y);
    return sum;
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