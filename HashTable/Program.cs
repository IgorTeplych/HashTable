using HashTable;
using System.Diagnostics;

static class Programm
{
    static Random rnd = new Random();
    public static void Main()
    {
        RandomNumbersPerformTest();
        Console.WriteLine();
        OrderedNumbersPerformTest();
        Console.ReadLine();
    }
    static void RandomNumbersPerformTest()
    {
        int N = 10000;
        int[] rndNum = GetRandomNumbers(N);

        Table table = new Table();
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < N; i++)
        {
            table.Add(rndNum[i]);
        }
        sw.Stop();
        Console.WriteLine($"Добавление в [HashTable] неупорядоченных чисел от 1 до {N} занимает: {sw.ElapsedTicks * 100} нс.");

        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < (N / 10); i++)
        {
            Node searh = table.Search(rndNum[random.Next(0, rndNum.Length - 1)]);
        }
        sw.Stop();
        Console.WriteLine($"Поиск в [HashTable] {N / 10} случайных чисел занимает: {sw.ElapsedTicks * 100} нс.");

        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < (N / 10); i++)
        {
            table.Delete(rndNum[random.Next(0, rndNum.Length - 1)]);
        }
        sw.Stop();
        Console.WriteLine($"Удаление в [HashTable] {N / 10} случайных чисел занимает: {sw.ElapsedTicks * 100} нс.");
    }
    static void OrderedNumbersPerformTest()
    {
        int N = 10000;
        int[] orderNum = GetOrderNumbers(N);

        Table table = new Table();
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < N; i++)
        {
            table.Add(orderNum[i]);
        }
        sw.Stop();
        Console.WriteLine($"Добавление в [HashTable] упорядоченных чисел от 1 до {N} занимает: {sw.ElapsedTicks * 100} нс.");

        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < (N / 10); i++)
        {
            Node searh = table.Search(orderNum[random.Next(0, orderNum.Length - 1)]);
        }
        sw.Stop();
        Console.WriteLine($"Поиск в [HashTable] {N / 10} случайных чисел занимает: {sw.ElapsedTicks * 100} нс.");

        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < (N / 10); i++)
        {
            table.Delete(orderNum[random.Next(0, orderNum.Length - 1)]);
        }
        sw.Stop();
        Console.WriteLine($"Удаление в [HashTable] {N / 10} случайных чисел занимает: {sw.ElapsedTicks * 100} нс.");
    }

    static Random random = new Random();
    static int[] GetRandomNumbers(int N)
    {
        int[] mass = new int[N];
        for (int i = 0; i < N; i++)
        {
            if (i != N)
                mass[i] = random.Next(1, int.MaxValue);
        }
        return mass;
    }

    static int[] GetOrderNumbers(int N)
    {
        int[] mass = new int[N];
        for (int i = 1; i < N; i++)
        {
            if (i != N)
                mass[i] = i;
        }
        return mass;
    }
}