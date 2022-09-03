// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

int CheckValue()
{
    while (true)
    {
        try
        {
            Console.Write("Введите целое положительное число: ");
            int mTmp = int.Parse(Console.ReadLine());

            if (mTmp <= 0)
            {
                Console.WriteLine("Пожалуйста, введите значение больше нуля!");
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

int SumNumbersRange(int numFIrst, int numSecond)
{
    int sum = 0;
    if (numFIrst > numSecond)
    {
        int tmp = numFIrst;
        numFIrst = numSecond;
        numSecond = tmp;
    }
    if (numFIrst == numSecond) return sum += numSecond;
    return sum += numFIrst + SumNumbersRange(numFIrst + 1, numSecond);
}

int m = CheckValue();

int n = CheckValue();

int sumNumbersRange = SumNumbersRange(m, n);

Console.WriteLine($"M = {m}; N = {n} -> {sumNumbersRange}");