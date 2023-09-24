Console.WriteLine("Ведите число N ");
int num_N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i<num_N; i++)
{
    if (i % 2 == 0)
    Console.WriteLine(i);
}