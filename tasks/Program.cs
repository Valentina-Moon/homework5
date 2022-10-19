Master master = new Master();

class Master
{
    static Master()
    {
        int lengh = 0;
        Console.WriteLine("Введите длину массива: ");
        lengh = int.Parse(Console.ReadLine());
        double[] array = new double[lengh];
        Random random = new Random();
        for (int i = 0; i < lengh; i++)
            array[i] = (double)random.Next() % (lengh * 2) - lengh;

        Console.WriteLine("Сгенерированный массив: ");
        Print(array);
        Console.WriteLine($"Минимум: {Min(array)}");
        Console.WriteLine($"Максимум: {Max(array)}");
        Console.WriteLine($"Поиск суммы элементов массива: {Sum(array)}");
        Console.WriteLine($"Поиск произведения элементов массива: {Prod(array)}");

        Console.WriteLine("Введите число для поиска в массиве: ");
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine($"Поиск индекса заданного элемента в массиве: {Find(array, number)}");

        Console.WriteLine("Введите число для проверки на наличие в массиве: ");
        number = double.Parse(Console.ReadLine());
        Console.WriteLine($"Проверка наличия элемента в массиве: {Contains(array, number)}");

        Console.WriteLine($"Среднее арифметическое элеметов массива: {Average(array)}");
        Console.WriteLine($"Подсчёт количества отрицательных элементов массива: {NegativeCount(array)}");

        Console.WriteLine("Введите число для подсчета элементов в массиве: ");
        number = double.Parse(Console.ReadLine());
        Console.WriteLine($" Подсчёт количества вхождений элемента в массив: {Count(array, number)}");

        Console.WriteLine($"Подсчёт количества чётных элементов в массив: {EvenCount(array)}");
        Console.WriteLine($"Подсчёт количества положительных элементов в массиве: {PositiveCount(array)}");
        Console.WriteLine($"Подсчёт количества нечётных элементов в массив: {UnevenCount(array)}");
        Console.WriteLine($"Проверка является ли массив отсортированным по возрастанию: {IsSorted(array)}");

        Console.WriteLine("Введите число для возведения в степень: ");
        number = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите степень: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Возвдение числа {number} в степень {num}: {Pow(number, num)}");
        Console.WriteLine("Введите число для получения факториала: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Факториал числа {num}: {Factorial(num)}");

        Console.WriteLine("Введите число для получения суммы его цифр: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Сумма цифр числа {num}: {SumOfDigits(num)}");

        Console.WriteLine("Введите число для проверки на полиндромность: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Является ли число {num} полиндромом: {IsPolindrom(num)}");

        Console.WriteLine("Введите первое число для сложения: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число для сложения: ");
        var sec = int.Parse(Console.ReadLine());
        Console.WriteLine($"Сумма чисел {num} и {sec}: {Sum(num, sec)}");

        Console.WriteLine("Введите число для проверки на простоту: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Является ли число {num} простым: {IsSimple(num)}");

        Console.WriteLine("Введите число для проверки на четность: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Является ли число {num} четным: {IsEven(num)}");


    }
    public static double Min(double[] array)
    {
        var res = array[0];
        foreach (var num in array)
            if (res > num)
                res = num;
        return res;
    }
    public static double Max(double[] array)
    {
        var res = 0.0;
        foreach (var num in array)
            if (res < num)
                res = num;
        return res;
    }
    public static double Sum(double[] array)
    {
        var res = 0.0;
        foreach (var num in array)
            res += num;
        return res;
    }
    public static double Prod(double[] array)
    {
        var res = 0.0;
        foreach (var num in array)
            res *= num;
        return res;
    }
    public static int Find(double[] array, double number)
    {
        int res = -1;
        for (int i = 0; i < array.Length; i++)
            if (array[i] == number)
            {
                res = i;
                return res;
            }
        return res;
    }
    public static bool Contains(double[] array, double number)
    {
        for (int i = 0; i < array.Length; i++)
            if (array[i] == number)
                return true;
        return false;
    }
    public static void Print(double[] array)
    {
        foreach (var num in array)
            Console.Write(num + "\t");
        Console.WriteLine();
    }

    public static double Average(double[] array)
    {
        return Sum(array) / array.Length;
    }
    public static int NegativeCount(double[] array)
    {
        int res = 0;
        foreach (var num in array)
            if (num < 0)
                res++;
        return res;
    }
    public static int PositiveCount(double[] array)
    {
        int res = 0;
        foreach (var num in array)
            if (num >= 0)
                res++;
        return res;
    }
    public static int Count(double[] array, double number)
    {
        int res = 0;
        foreach (var num in array)
            if (num == number)
                res++;
        return res;
    }
    public static int EvenCount(double[] array)
    {
        int res = 0;
        foreach (var num in array)
            if (num % 2 == 0)
                res++;
        return res;
    }
    public static int UnevenCount(double[] array)
    {
        int res = 0;
        foreach (var num in array)
            if (num % 2 == 1)
                res++;
        return res;
    }
    public static bool IsSorted(double[] array)
    {
        double number = 0.0;
        foreach (var num in array)
        {
            if (num < number)
                return false;
            number = num;
        }
        return true;
    }

    public static double Pow(double number, int power)
    {
        var res = 1.0;
        for (int i = 0; i < power; i++)
            res *= number;
        return res;
    }
    public static int Factorial(int number)
    {
        if (number != 0)
            return number * Factorial(number - 1);
        else
            return 1;
    }
    public static int SumOfDigits(int number)
    {
        int res = 0;
        foreach (var digit in number.ToString().ToCharArray())
            res += int.Parse(digit.ToString());
        return res;
    }
    public static bool IsPolindrom(int number)
    {
        bool res = true;
        var digits = number.ToString().ToCharArray();
        for (int i = 0; i <= digits.Length / 2; i++)
            if (digits[i] != digits[digits.Length - 1 - i])
                res = false;
        return res;
    }
    public static int Sum(int first, int second)
    {
        return first + second;
    }
    public static bool IsSimple(int number)
    {
        bool res = true;
        for (int i = 2; i <= number / 2; i++)
            if ((double)number / i == number / i)
                res = false;
        return res;
    }
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}