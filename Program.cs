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
        Calculadora.CalcularSoma();
        break;
    case "-":
        Calculadora.CalcularSubtracao();
        break;
    case "*":
        Calculadora.CalcularMultiplicacao();
        break;
    case "/":
        Calculadora.CalcularDivisao();
        break;
    default:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Opção inválida.");
        break;
}

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nObrigado por utilizar nosso programa <3 .");
Console.ResetColor();