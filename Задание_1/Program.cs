Console.Write("Введите 2 числа: ");
int number_1 = Convert.ToInt32( Console.ReadLine());
int number_2 = Convert.ToInt32( Console.ReadLine());
int max = 0;
if(number_1 > number_2)
{
max = number_1;
}
else
{
max = number_2;
}
Console.Write("max = ");
Console.WriteLine(max);
