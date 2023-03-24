/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int a;
Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out a);
int Znach (int a){
    int sum = 0;
    for (int i = a; i>0; i--)
    {   sum = sum + a%10;
        a/=10; 
    }
    return sum;
}

Console.WriteLine($"Итоговое число {Znach(a)}");