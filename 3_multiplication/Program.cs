// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите N = ");
int N = int.Parse(Console.ReadLine()??"0");
Console.WriteLine();
int i = 1;
int Multiplication = 1;
while (i <= N)
{
    Multiplication = Multiplication * i;
    i++;
}
Console.WriteLine("Произведение чисел от 1 до " + N + " равно " + Multiplication);