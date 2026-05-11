internal class Program
{
    private static void Main(string[] args)
    {
        int numero;

        Console.Write("Ingrese un número: ");
        numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine(numero + " por " + i + " es igual a " + resultado);
        }
    }
}