// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
// https://t.me/VladVin2314


System.Console.WriteLine("Напишите число: ");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("задайте степень вкоторую нужно возвести: ");
int b = int.Parse(Console.ReadLine());

int Work (int a, int b)
{
    if (b == 0) return 1;
    else return Work(a, b-1) * a;
}
int sum = Work(a,b);
System.Console.WriteLine(sum);