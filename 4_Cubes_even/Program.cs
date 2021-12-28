// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите N = ");
int N = int.Parse(Console.ReadLine()??"0");
Console.WriteLine();
int i = 0;
Console.WriteLine( "Кубы чисел, заканчивающихся на четную цифру: ");
Console.WriteLine();
while (i <= N)
{
    if (i % 2 ==0)
    {
        int cube = i * i * i;
        Console.WriteLine( "Куб числа " + i + " = " + cube);
    }
    
    i++;
}