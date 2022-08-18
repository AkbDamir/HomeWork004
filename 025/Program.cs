/* Задача 25: Напишите цикл, 
который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 
*/

Console.WriteLine("Введите ваше число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень в которую хотите возвести ваше число: ");
int B = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < B; i++)
{
    A *= A;
}
Console.WriteLine("ваше число в степени " + B + " равно: " + A);
