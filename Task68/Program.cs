// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int CheckValueM()
{
    while (true)
    {
        try
        {
            Console.Write($"Введите целое положительное число m: ");
            int mTmp = int.Parse(Console.ReadLine());

            if (mTmp < 0)
            {
                Console.WriteLine("Пожалуйста, введите неотрицательное число!");
                Console.WriteLine();
                continue;
            }
            else return mTmp;
        }
        catch
        {
            Console.WriteLine("Ошибка! Некорректный формат! Повторите попытку!");
            Console.WriteLine();
            continue;
        }
    }
}

int CheckValueN()
{
    while (true)
    {
        try
        {
            Console.Write($"Введите целое положительное число n: ");
            int mTmp = int.Parse(Console.ReadLine());

            if (mTmp < 0)
            {
                Console.WriteLine("Пожалуйста, введите неотрицательное число!");
                Console.WriteLine();
                continue;
            }
            else return mTmp;
        }
        catch
        {
            Console.WriteLine("Ошибка! Некорректный формат! Повторите попытку!");
            Console.WriteLine();
            continue;
        }
    }
}

int A(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return A(m - 1, 1);
    if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
    return A(m, n);
}

int m;
int n;

while (true)
{
    m = CheckValueM();

    while (m > 4)
    {
        Console.WriteLine("Пожалуйста введите m < 5 !!!");
        m = CheckValueM();
    }
    
    n = CheckValueN();

    if (m == 0 || n == 0) break;
    
    while (m == 4 && n != 0)
    {
        Console.WriteLine("Пожалуйста введите n = 0 !!!");
        n = CheckValueN();
    }
    while (m == 3 && n > 10)
    {
        Console.WriteLine("Пожалуйста введите n < 11 !!!");
        n = CheckValueN();
    }
    while (m == 2 && n > 8028)
    {
        Console.WriteLine("Пожалуйста введите n < 8029 !!!");
        n = CheckValueN();
    }
    while (m == 1 && n > 16067)
    {
        Console.WriteLine("Пожалуйста введите n < 16068 !!!");
        n = CheckValueN();
    }
    break;

}

int akerman = A(m, n);

Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {akerman}");
