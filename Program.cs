void task1()
{
    //Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

    // M = 1; N = 5 -> 2, 4
    // M = 4; N = 8 -> 4, 6, 8

    Console.Clear();

    Console.WriteLine("Введите число M");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N");
    int n = Convert.ToInt32(Console.ReadLine());

    FindEvenNatural(n, m);

    void FindEvenNatural(int n, int m)
    {
        if (m <= n)
        {
            if (m % 2 == 0)
            {
                Console.Write(m + " ");
                m++;
            }
            else
            {
                m++;
            }
            FindEvenNatural(n, m);
            return;
        }
    }
    Console.ReadKey();
}


void task2()
{
    // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
    // элементов в промежутке от M до N с помощью рекурсии.
    // M = 1; N = 15 -> 120
    // M = 4; N = 8 -> 30

    Console.Clear();
    Console.WriteLine("Введите число M");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N");
    int n = Convert.ToInt32(Console.ReadLine());

    int SumNatural(int n, int m, int sum = 0)
    {
        if (m > n)
        {
            return sum;
        }
        sum = sum + m;
        m++;
        return SumNatural(n, m, sum);
    }

    Console.WriteLine(SumNatural(n, m));

    Console.ReadKey();

}


void task3()
{
    // Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий 
    // делитель (НОД) этих чисел с помощью рекурсии.
    // M = 28; N = 7 -> 7

    Console.Clear();
    Console.WriteLine("Введите число M");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N");
    int n = Convert.ToInt32(Console.ReadLine());

    int Nod(int m, int n)
    {
        if (n == 0)
        {
            return m;
        }
        else
        {
            return Nod(n, m % n);
        }
    }
    Console.WriteLine(Nod(m, n));

    Console.ReadKey();
}



void Main()
{
    Console.Clear();
    Console.WriteLine("\n Выберите задачу:\n\t1 - Задача 64 \n\t2 - Задача 66 \n\t3 - Задача 68 \n\t4 - Выйти");
    int num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 1:
            task1();
            Main();
            break;
        case 2:
            task2();
            Main();
            break;
        case 3:
            task3();
            Main();
            break;
        case 4:
            break;
    }
}
Main();