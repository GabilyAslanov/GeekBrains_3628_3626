// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2


var random = new Random();

int randomNum = 33;//random.Next(10, 100);

System.Console.WriteLine(randomNum);

int num1 = randomNum / 10;

int num2 = randomNum % 10;

if (num1 > num2)
{
    System.Console.WriteLine(num1);
}
else if (num1 < num2)
{
    System.Console.WriteLine(num2);
}
else
{
    System.Console.WriteLine($"Они рaвны оба рaвны {num1}");
}







//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Enter number : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int secondNumber = (num / 10) % 10; //789/10= 78 %10=8

    Console.WriteLine($"Вторая цифра в числе {num} -> {secondNumber}");
}
else
    Console.WriteLine($"Число {num} не трёхзначное");




//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//То что дала GeekBrains
//645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Enter number : ");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter index : ");
int index = Convert.ToInt32(Console.ReadLine());

double pow = Math.Pow(10, index);



if (num < 1000)
{
    Console.WriteLine($"Цифра меньше индекса");
  
}
else   {

int tmp = num;

while (tmp > 1000)
{
    tmp /= 10;
}

int result = tmp % 10;

Console.WriteLine($"Цифра под индексом {index} числа {num} -> {result}");
}


//Задача 15: Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Enter dayWeek : ");
string dayWeek = Console.ReadLine();

switch (dayWeek)
{
    case "1":
        Console.WriteLine("Понедельник- НЕТ");
        break;
    case "2":
        Console.WriteLine("Вторник- НЕТ");
        break;
    case "3":
        Console.WriteLine("Среда- НЕТ");
        break;
    case "4":
        Console.WriteLine("Четверг- НЕТ");
        break;
    case "5":
        Console.WriteLine("Пятница- Да");
        break;
    case "6":
        Console.WriteLine("Суббота- Нет");
        break;
    case "7":
        Console.WriteLine("Воскресенье- Нет");
        break;
    case "8":
        Console.WriteLine("Воскресенье- Нет");
        break;
          case "954595aeeg":
        Console.WriteLine("Воскресенье- Нет");
        break;
}

if(dayWeek=="1"){
 Console.WriteLine("Понедельник- НЕТ");
}
else if(dayWeek=="2")
{
   Console.WriteLine("Вторник- НЕТ");  
}
else if(dayWeek=="3")
{
   Console.WriteLine("Среда- НЕТ"); 
}
else 
{
     Console.WriteLine("Некорректный номер дня недели");
}