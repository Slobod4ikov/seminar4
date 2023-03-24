/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int a;
int b;
Console.WriteLine("Введите первое число");
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine("Введите второе число");
int.TryParse(Console.ReadLine(), out b);
int stepen (int a, int b){
    int result=1;
    if(b<0){b=b*-1;}
    for (int i = 1; i <= b; i++)
    {result=a*a;}
    return result;
}
Console.WriteLine($"Итог = {stepen(a,b)}");