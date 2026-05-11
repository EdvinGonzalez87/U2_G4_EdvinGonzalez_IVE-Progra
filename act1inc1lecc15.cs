internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        int totalBoletos = 0;
        int totalCobrado = 0;

        do
        {
            Console.WriteLine("Presione 1 si es niño");
            Console.WriteLine("Presione 2 si es adulto");
            Console.WriteLine("Presione 0 para finalizar");

            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                totalBoletos++;
                totalCobrado += 10;
            }
            else if (opcion == 2)
            {
                totalBoletos++;
                totalCobrado += 15;
            }

        } while (opcion != 0);

        Console.WriteLine("Número de boletos vendidos: " + totalBoletos);
        Console.WriteLine("Total cobrado: " + totalCobrado + " soles");
    }
}