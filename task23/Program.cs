// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count=1;

if(number>0)
    while(count<=number)
    {
        double res = Math.Pow(count,3);
        Console.Write(""+res+" ");
        count++;
    }
else
    Console.WriteLine("Число меньше или равно нулю");