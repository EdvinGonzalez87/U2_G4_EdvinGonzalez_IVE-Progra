internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        int suma = 0;

        do
        {
            Console.Write("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            suma += num;

        } while (num != 9);

        Console.WriteLine("La suma total es: " + suma);
    }
}