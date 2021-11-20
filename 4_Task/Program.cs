// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1, a = 1; (i <= 20) && (a <= 400); i++, a++)
{
    a =( 2 * i - 1)+a-1;
    if (i == n + 1)
    {
        break;
    }
    Console.WriteLine("Квадрат числа {0} равен {1}", i, a);
}