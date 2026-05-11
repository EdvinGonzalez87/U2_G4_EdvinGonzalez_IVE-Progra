internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;
        int cantidadPares = 0;

        for (int i = 1; i <= 20; i++)
        {
            int multiplo = i * 7;

            suma += multiplo;

            if (multiplo % 2 == 0)
            {
                cantidadPares++;
            }
        }

        Console.WriteLine("La suma de los múltiplos es: " + suma);
        Console.WriteLine("Cantidad de múltiplos pares: " + cantidadPares);
    }
}