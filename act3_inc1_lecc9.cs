internal class Program
{
    private static void Main(string[] args)
    {
        int num, contador = 0;

        Console.Write("Ingrese un número entero: ");
        num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                contador++;
            }
        }

        if (contador == 2)
        {
            Console.WriteLine("El número es primo");
        }
        else
        {
            Console.WriteLine("El número no es primo");
        }
    }
}