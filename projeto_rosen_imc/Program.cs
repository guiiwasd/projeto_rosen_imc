using projeto_rosen_imc;
using System.Globalization;

class Program
{
    private static void Main(string[] args)
    {
        ShowMenu();
    }
    static void ShowMenu()
    {
        Console.WriteLine("Seja bem-vindo ao programa do Guilherme e do Kaick!");
        Console.WriteLine("Para consultar SOMADOR: Digite 1.");
        Console.WriteLine("Para consultar CONVERSOR: Digite 2.");
        Console.WriteLine("Para consultar IMC: Digite 6.");
        Console.WriteLine("Para SAIR: Digite 0.");
        int menu = int.Parse(Console.ReadLine());
        ProcessMenu(menu);
    }
    static void ProcessMenu(int menu)
    {
        switch (menu)
        {
            case 0:
                Console.WriteLine("Você desejou sair do programa. Até mais!");
                break;

            case 1:
                Console.WriteLine("Você escolheu SOMADOR!");
                Console.WriteLine("Insira o valor do primeiro número: ");
                double num1 = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
                Console.WriteLine("Insira o valor do segundo número: ");
                double num2 = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
                Console.WriteLine($"A soma dos números {num1} e {num2} é {Somador.Soma(num1, num2)}.");
                break;

            case 2:
                Console.WriteLine("Você escolheu CONVERSOR!");
                Console.WriteLine("Insira o valor em metros: ");
                double metros = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
                Console.WriteLine("A medida {0} metros corresponde a {1}", metros, Conversor.MetrosMilimetros(metros));
                break;

            case 6:
                Console.WriteLine("Desnutrição = IMC Abaixo de 16");
                Console.WriteLine("Abaixo do peso = IMC Entre 16 e 18.5");
                Console.WriteLine("Peso ideal = IMC Entre 18.5 e 24.9");
                Console.WriteLine("Acima do peso = IMC Entre 25.0 e 29.9");
                Console.WriteLine("Obesidade de grau I = IMC Entre 30.0 e 34.9");
                Console.WriteLine("Obesidade de grau II (SEVERA) = IMC Entre 35.0 e 39.9");
                Console.WriteLine("Obesidade de grau III (MÓRBIDA) = IMC Acima de 40.0");
                Console.WriteLine("Insira o valor do peso (em kg): ");
                double pesoIMC = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
                Console.WriteLine("Insira o valor da altura (em metros): ");
                double alturaIMC = Convert.ToDouble(Console.ReadLine(), new CultureInfo("en-US"));

                if (CalculoIMC.IMCTotal(alturaIMC, pesoIMC) > 16.0 && CalculoIMC.IMCTotal(alturaIMC, pesoIMC) <= 18.5)
                {
                    Console.WriteLine($"Usuário(a) com peso e altura equivalentes a {pesoIMC} e {alturaIMC} se encontra abaixo do peso. \nIMC: {CalculoIMC.IMCTotal(alturaIMC, pesoIMC):F2}");
                }
                else if (CalculoIMC.IMCTotal(alturaIMC, pesoIMC) > 18.5 && CalculoIMC.IMCTotal(alturaIMC, pesoIMC) <= 24.9)
                {
                    Console.WriteLine($"Usuário(a) com peso e altura equivalentes a {pesoIMC} e {alturaIMC} se encontra no peso ideal. \nIMC: {CalculoIMC.IMCTotal(alturaIMC, pesoIMC):F2}");
                }
                else if (CalculoIMC.IMCTotal(alturaIMC, pesoIMC) >= 25.0 && CalculoIMC.IMCTotal(alturaIMC, pesoIMC) <= 29.9)
                {
                    Console.WriteLine($"Usuário(a) com peso e altura equivalentes a {pesoIMC} e {alturaIMC} se encontra levemente acima do peso. \nIMC: {CalculoIMC.IMCTotal(alturaIMC, pesoIMC):F2}");
                }
                else if (CalculoIMC.IMCTotal(alturaIMC, pesoIMC) >= 30.0 && CalculoIMC.IMCTotal(alturaIMC, pesoIMC) <= 34.9)
                {
                    Console.WriteLine($"Usuário(a) com peso e altura equivalentes a {pesoIMC} e {alturaIMC} se encontra com obesidade de grau I.\nIMC: {CalculoIMC.IMCTotal(alturaIMC, pesoIMC):F2}");
                }
                else if (CalculoIMC.IMCTotal(alturaIMC, pesoIMC) >= 35.0 && CalculoIMC.IMCTotal(alturaIMC, pesoIMC) <= 39.9)
                {
                    Console.WriteLine($"Usuário(a) com peso e altura equivalentes a {pesoIMC} e {alturaIMC} se encontra com obesidade de grau II: SEVERA. \nIMC: {CalculoIMC.IMCTotal(alturaIMC, pesoIMC):F2}");
                }
                else if (CalculoIMC.IMCTotal(alturaIMC, pesoIMC) >= 40)
                {
                    Console.WriteLine($"Usuário(a) com peso e altura equivalentes a {pesoIMC} e {alturaIMC} se encontra com obesidade de grau III: MÓRBIDA. \nIMC: {CalculoIMC.IMCTotal(alturaIMC, pesoIMC):F2}");
                }
                else
                {
                    Console.WriteLine($"Usuário(a) com peso e altura equivalentes a {pesoIMC} e {alturaIMC} se encontra com desnutrição grave a depender da idade. \nIMC: {CalculoIMC.IMCTotal(alturaIMC, pesoIMC):F2}");
                }
                break;

            default:
                Console.WriteLine("Valor inválido. Por favor, tente novamente.");
                break;  
        }
    }
}