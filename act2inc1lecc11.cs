internal class act2inc1lecc11
{
    private static void Main(string[] args)
    {
        int num;
        int factorial = 1;

        Console.Write("Ingrese un número: ");
        num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("El factorial es: " + factorial);
    }
}