Console.WriteLine("Hello, User! Введите первое число");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int num3 = int.Parse(Console.ReadLine()!);
int max = num1;
if (num1>max) max = num1;
if (num2>max) max = num2;
if (num3>max) max = num3;

Console.WriteLine("максимальное");
Console.WriteLine(max); 
 
   