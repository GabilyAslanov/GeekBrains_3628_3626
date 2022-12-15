void LetsGo()
{
    while (true)
    {
        Console.WriteLine("Press Enter to continue... \n");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("№ 64: Задайте значения M и N. Напишите программу, \nкоторая выведет все натуральные числа в промежутке от M до N. \n");
        Console.WriteLine("№ 66: Задайте значения M и N. Напишите программу, \nкоторая найдёт сумму натуральных элементов в промежутке от M до N. \n");
        Console.WriteLine("№ 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. \nДаны два неотрицательных числа m и n. \n");



        Console.WriteLine("Введите номер задачи выбранной для проверки, \n  или введите 0 для завершения... \n");
        int taskNumber = enterNumber();

        switch (taskNumber)
        {
            case 64: Console.WriteLine($"Числа по порядку в указанном диапазоне: {NaturalNumbers(enterNumber(), enterNumber())}"); break;
            case 66: Console.WriteLine($"Сумма равна: {SumNaturalNums(enterNumber(), enterNumber())}"); break;
            case 68: Console.WriteLine($"\nЗначение при вычислении функции Аккермана \nдля введённых вами цифр, будет следующим: {Akkerman(enterNumber(), enterNumber())}; "); break;
            case 0: Console.WriteLine("\nАнекдот напоследок: \n\nНичто не помогает так по хозяйству, как вырубленный интернет!\n\n"); return; break;
            default: Console.WriteLine("Необходимо ввести номер задачи или 0 для выхода. \n Попробуйте еще раз..."); break;

        }
  
    }
}

int enterNumber()
{
    Console.WriteLine("Enter number: ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}


// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

string NaturalNumbers(int n, int m)
{
    if (n <= m) return $"{n} " + NaturalNumbers(n + 1, m);
    else return String.Empty;
}



// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNums(int n, int m)
{
    if (n > m) return 0;
    else return n + SumNaturalNums(n + 1, m);
}


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29


int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}

LetsGo();