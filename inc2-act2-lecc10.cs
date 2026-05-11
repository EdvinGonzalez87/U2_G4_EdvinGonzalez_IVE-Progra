internal class Program
{
    private static void Main(string[] args)
    {
        int num;

        Console.Write("Ingrese un número mayor que 2: ");
        num = int.Parse(Console.ReadLine());

        for (int i = 2; i <= num; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}