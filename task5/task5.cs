Console.Write("vvedite A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("vvedite B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int Degree(int a, int b)
{
    if (b == 0) return 1;
    else return a * Degree(a, b - 1);
}
int help = Degree(num1, num2);
Console.WriteLine(help);
