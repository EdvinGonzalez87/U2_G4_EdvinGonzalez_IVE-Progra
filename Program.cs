internal class Program
{
    private static void Main(string[] args)
    {
        const int TOTAL_SELLOS = 8;

        Console.WriteLine("Bienvenido a la barberia PRESI");
        for (int i = 1; i < TOTAL_SELLOS; i++) 
        { 
            Console.WriteLine("\nSellos actuales: {0} de {1}", i, TOTAL_SELLOS);
            Console.WriteLine("Presiones cualquier tecla para registrar esta visita");
            Console.ReadKey();  
            Console.WriteLine(">>>Sellos, #{0}registrado correctamente",i);
        }
        Console.WriteLine("\n**************************************************");
        Console.WriteLine("Cupon completado");
        Console.WriteLine("Edvin, te has ganado un corte de caballero GARTIS...");
        Console.WriteLine("**************************************************");
    }
}