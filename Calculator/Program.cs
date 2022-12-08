Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("Operações disponíveis:");
    Console.WriteLine();

    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Potenciação");
    Console.WriteLine("6 - Radiciação");
    System.Console.WriteLine();
    System.Console.WriteLine("7 - Sair");

    Console.WriteLine();
    Console.Write("Digite uma opção: ");
    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: Potenciacao(); break;
        case 6: Radiciacao(); break;
        case 7: Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Soma()
{
    Console.Clear();
    Console.WriteLine("Soma");

    Console.WriteLine();
    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();
    float resultado = v1 + v2;
    Console.WriteLine($"O resultado da soma é: {resultado}");
    Console.WriteLine();
    Console.WriteLine("----------");
    Console.WriteLine();
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    Menu();

}

static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Subtração");

    Console.WriteLine();
    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();
    float resultado = v1 - v2;
    Console.WriteLine($"O resultado da subtração é: {resultado}");
    Console.WriteLine();
    Console.WriteLine("----------");
    Console.WriteLine();
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Divisão");

    Console.WriteLine();
    Console.Write("Dividendo: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Divisor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();
    float resultado = v1 / v2;
    Console.WriteLine($"O resultado da divisão é: {resultado}");
    Console.WriteLine();
    Console.WriteLine("----------");
    Console.WriteLine();
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    Menu();
}

static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Multiplicação");

    Console.WriteLine();
    Console.Write("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.Write("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine();
    float resultado = v1 * v2;
    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    Console.WriteLine();
    Console.WriteLine("----------");
    Console.WriteLine();
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    Menu();
}

static void Potenciacao()
{
    Console.Clear();
    Console.WriteLine("Potenciação");

    Console.WriteLine();
    Console.Write("Base: ");
    double x = double.Parse(Console.ReadLine());

    Console.Write("Expoente: ");
    double y = double.Parse(Console.ReadLine());

    Console.WriteLine();
    double resultado = Math.Pow(x, y);
    Console.WriteLine($"O resultado da potenciação é: {resultado}");
    Console.WriteLine();
    Console.WriteLine("----------");
    Console.WriteLine();
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    Menu();
}

static void Radiciacao()
{
    Console.Clear();
    Console.WriteLine("Radiciação");

    Console.WriteLine();
    Console.Write("Índice: ");
    double n = double.Parse(Console.ReadLine());

    Console.Write("Radicando: ");
    double x = double.Parse(Console.ReadLine());

    Console.WriteLine();
    double resultado = Math.Pow(x, (1 / n));
    Console.WriteLine($"O resultado da radiciação é: {resultado}");
    Console.WriteLine();
    Console.WriteLine("----------");
    Console.WriteLine();
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    Menu();
}
