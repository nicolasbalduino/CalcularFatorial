int num, fatorial = 1;

Console.Write("Digite um numero para calcular seu fatorial: ");
num = int.Parse(Console.ReadLine());

for (int i = num; i > 0; i--)
{
    if (i == 1)
        Console.WriteLine("1! = 1");
    else
        Console.WriteLine($"{i}! = {i} x {i - 1}!");

    fatorial *= i;
}

Console.WriteLine($"\n{num}! = {fatorial}");
