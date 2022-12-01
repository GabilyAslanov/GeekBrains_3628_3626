
// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

Console.WriteLine("Enter number : ");
double Num = Convert.ToDouble(Console.ReadLine());


Console.WriteLine($"Sqr = {Num*Num} ");



        static void Main(string[] args)
        
        {


int count = 0;
int distance = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;



while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (FirstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (SecondFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count++;
}

Console.WriteLine($"Количество раз, за которое собака пробежит, равно - {count}");
        }




//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

int N=int.Parse(Console.ReadLine());
int B=-N;
while (B<=N)
{
    Console.WriteLine($"{B} ");
    B++;
}


//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.

Console.Clear();
Console.Write("Введите трехзначное число: ");
int num=int.Parse(Console.ReadLine());
int y=num%10;

Console.WriteLine($"{y}");