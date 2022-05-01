string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora 4 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        CalcularSoma();
        break;

    case "-":
        CalcularSubtracao();
        break;

    case "*":
        CalcularMultipicacao();
        break;
    case "/":
        CalcularDivisao();
        break;
    default:
    Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Opção inválida.");
        break;
}

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nObrigado por utilizar nosso programa <3 .");
Console.ResetColor();

void CalcularSoma()
{
     int n1, n2, resultado;
        Console.WriteLine("--- Soma ---");

        Console.Write("Digite o primeiro número: ");
        n1 = Convert.ToInt32(Console.ReadLine()!); 

        Console.Write("Digite o segundo número: ");
        n2 = Convert.ToInt32(Console.ReadLine()!);

        resultado = n1 + n2;
         Console.WriteLine($"{n1} somado por {n2} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
    return;
}

void CalcularSubtracao()
{
    int n1, n2, resultado;
        Console.WriteLine("--- Subtração ---");

        Console.Write("Digite o primeiro número: ");
        n1 = Convert.ToInt32(Console.ReadLine()!); 

        Console.Write("Digite o segundo número: ");
        n2 = Convert.ToInt32(Console.ReadLine()!);

        resultado = n1 - n2;
         Console.WriteLine($"{n1} subtraido por {n2} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
    return;
}

void CalcularMultipicacao()
{
    double a, b, resultado;

        Console.WriteLine("--- Multiplicação A*B ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = a * b; 
        Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
    return;
} 

void CalcularDivisao()
{
    double a, b, resultado;

        Console.WriteLine("--- Divisão ---\n");
        Console.WriteLine("Digite os valores.");

        Console.Write("A = ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("B = ");
        b = Convert.ToDouble(Console.ReadLine());

        resultado = a / b; 
        Console.WriteLine($"{a} dividido por {b} é {resultado}");

        Console.WriteLine("\nPressione uma tecla para continuar...");
        Console.ReadKey();
    return;
}