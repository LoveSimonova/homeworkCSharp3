// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if((number/10000)==(number%10))
    if(((number/1000)%10)==(number%100)/10)
        Console.WriteLine("Число - палиндром");
    else
        Console.WriteLine("Число - не палиндром");
else
    Console.WriteLine("Число - не палиндром");