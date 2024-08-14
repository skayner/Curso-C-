internal class Program
{
    private static void Main(string[] args)
    {

        int op = 6;

        switch (op)
        {
            case 1:
                Console.WriteLine("Seleccionaste el 1");
                break;
            case 2:
                Console.WriteLine("Seleccionaste el 2");
                break;
            case 3:
            case 4:
                Console.WriteLine("Seleccionaste 3 o 4");
                break;
            case < 0:
            case > 100:
                Console.WriteLine("Fuera de rango");
                break;
            case > 4 and < 10:
                Console.WriteLine("Seleccionaste entre 4 y 10");
                break;
            default:
                Console.WriteLine("invalido");
                break;
        }

    }
}