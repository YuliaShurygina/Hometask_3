// Подсчитать сумму цифр в числе
Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()??"0");

int count = 0;
int sum = 0;

while (A >= 1)
{
     int unity = A % 10;
     A =  A / 10;
     sum = sum + unity;
     count++;
}
Console.WriteLine("Сумма цифр в числе = " + sum);
