//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.


Console.Write("Введите number 1 : ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите number 2: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
    Console.WriteLine("number 1 больше number 2");
else if (number1 < number2)
    Console.WriteLine("number 2 больше number 1");
else
    Console.WriteLine("number 1 равно number 2");


// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.


Console.Write("Введите первое чило: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;

if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}

Console.WriteLine($"максимальное число = {max}");


//Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}


//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

//Первое решение
int i = 1;

int numI = i++;
//префексный ++i
//numI =2
//i=2 

//посфексный i++
// numI = 1
// i = 2 


while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
   
}
Console.WriteLine();
//Второе решение
int k = 2;
while (k <= N)
{
    Console.Write($"{k} ");
    k += 2;

}