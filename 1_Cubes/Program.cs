// Найти кубы чисел от 1 до N
Console.Write("Введите N = ");
int N = int.Parse(Console.ReadLine()??"0");
Console.WriteLine();
int i = 1;
while (i<=N)
{
    int cube = i * i * i;
    Console.WriteLine( "Куб числа " + i + " = " + cube);
    i++;
}

