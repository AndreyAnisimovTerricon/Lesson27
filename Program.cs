Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
while (n>0)
{sum = sum + n % 10;
n /= 10;}
int result = sum;
Console.WriteLine ( result);
