// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int n = Convert.ToInt32(Console.ReadLine());
int k = 0;
int m = 0;
do
{
    if (n!=0)
    {
        n = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        break;
    }
    if (n>0)
    {
        k++;
    }
   if (n<0)
    {
        m++;
    }
}
while (n != 0);
if (k++>m++)
{
    Console.WriteLine("Количество положительных чисел больше, чем отрицательных и равно {0}", +k);
}
else
{
    Console.WriteLine("Количество отрицательных чисел больше, чем положительных и равно {0}", +m-1);
}
    


