internal class Program
{
    private static void Main(string[] args)
    {
        int billete;
        int cantidad100 = 0;
        int totalDinero = 0;

        do
        {
            Console.Write("Ingrese un billete (20, 50, 100) o 0 para salir: ");
            billete = int.Parse(Console.ReadLine());

            if (billete == 100)
            {
                cantidad100++;
                totalDinero += billete;
            }

        } while (billete != 0);

        Console.WriteLine("Cantidad de billetes de 100: " + cantidad100);
        Console.WriteLine("Total de dinero: " + totalDinero);
    }
}