using System.Runtime.CompilerServices;

Console.WriteLine("Indtast et tal: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Factorial af {0} er {1}", num, Factorial(num));


static int Factorial(int num)
{
    if (num == 0)
        return 1;
    else
        return num * Factorial(num - 1);
}