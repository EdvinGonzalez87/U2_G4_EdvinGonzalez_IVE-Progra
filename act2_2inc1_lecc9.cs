internal class Program
{
    private static void Main(string[] args)
    {
        int monedas;

        Console.Write("Ingrese la cantidad de monedas del jugador: ");
        monedas = int.Parse(Console.ReadLine());

        if (monedas < 350)
        {
            Console.WriteLine("Nivel 5 bloqueado. Necesitas al menos 350 monedas.");
        }
        else
        {
            Console.WriteLine("¡Nivel 5 desbloqueado! Puedes ingresar al nuevo nivel.");
        }
    }
}