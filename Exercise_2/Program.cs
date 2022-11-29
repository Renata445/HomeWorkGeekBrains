Console.Clear();
Console.Write("Введите 3 числа: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = Convert.ToInt32(Console.ReadLine());
int number_3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (number_1 > max)
{
    max = number_1;
}
if (number_2 > max)
{
    max = number_2;
}
if (number_3 > max)
{
    max = number_3;
}
Console.Write("max = ");
Console.WriteLine(max);