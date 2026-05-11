internal class Program
{
    private static void Main(string[] args)
    {
        int suma = 0;

        for (int num = 1; num <= 50; num++)
        {
            int contador = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
            {
                suma += num;
            }
        }

        Console.WriteLine("La suma de los números primos es: " + suma);
    }
}