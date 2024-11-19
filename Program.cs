namespace Calculadora;

class Program
{
    public enum EOperation : int
    {
        Sum = 1,
        Substraction = 2,
        Multiplication = 3,
        Division = 4,
        Exit = 5
    }

    public static void Main(string[] args)
    {
        Console.Clear();
        Menu();
    }

    public static void Menu()
    {
        int operation = 0;

        Console.WriteLine("Qual operação deseja fazer? Digite o valor correspondente");
        Console.WriteLine("Soma - 1\nSubtração - 2\nMultiplicação - 3\nDivisão - 4\nFechar - 5\n");

        operation = int.Parse(Console.ReadLine());

        Operation(operation);
    }

    public static void Operation(int operation)
    {
        if ((EOperation)operation == EOperation.Exit)
        {
            Console.WriteLine("Aplicação Finalizada");
            return;
        }

        switch ((EOperation)operation)
        {
            case EOperation.Sum:
                Sum();
                break;
            case EOperation.Substraction:
                Substraction();
                break;
            case EOperation.Multiplication:
                Multiplication();
                break;
            case EOperation.Division:
                Division();
                break;
            default:
                Menu();
                break;
        }
    }
    public static void Sum()
    {
        Console.Write("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.Write("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine($"O resultado é: {v1 + v2}\n\n");
        Menu();
    }

    public static void Substraction()
    {
        Console.Write("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.Write("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine($"O resultado é: {v1 - v2}\n\n");
        Menu();
    }

    public static void Multiplication()
    {
        Console.Write("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.Write("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine($"O resultado é: {v1 * v2}\n\n");
        Menu();
    }

    public static void Division()
    {
        Console.Write("Primeiro Valor: ");
        float v1 = float.Parse(Console.ReadLine());
        Console.Write("Segundo Valor: ");
        float v2 = float.Parse(Console.ReadLine());
        Console.WriteLine($"O resultado é: {v1 / v2}\n\n");
        Menu();
    }
}