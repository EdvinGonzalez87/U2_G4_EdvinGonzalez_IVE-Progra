internal class Program
{
    private static void Main(string[] args)
    {
        int numero;

        Console.Write("Ingrese un número: ");
        numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 20; i++)
        {
            int multiplo = numero * i;
            Console.WriteLine(multiplo);
        }
    }
}