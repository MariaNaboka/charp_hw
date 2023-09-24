Console.WriteLine("Ведите число a ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число b ");
int num_b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число c ");
int num_c = Convert.ToInt32(Console.ReadLine());
int max=num_a;
if (num_b>max)
{
    max=num_b;
}
if (num_c>max)
{
    max=num_c;
}
Console.WriteLine("Максимальное число: " + max);