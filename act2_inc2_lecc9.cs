internal class Program
{
    private static void Main(string[] args)
    {
        int num;

        Console.Write("Ingrese un número mayor que 20: ");
        num = int.Parse(Console.ReadLine());

        for (int i = 21; i <= num; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}