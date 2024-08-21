using System;

namespace CalculadoraGeo
{
    class Program
    {

        static void Main(string[] args)
        {
           Console.WriteLine("Escolha a figura geométrica:");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Quadrado");
            Console.WriteLine("3. Retângulo");
            Console.WriteLine("4. Triângulo");
            Console.Write("Digite o número da opção: ");
            
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CalcularCirculo();
                    break;
                case 2:
                    CalcularQuadrado();
                    break;
                case 3:
                    CalcularRetangulo();
                    break;
                case 4:
                    CalcularTriangulo();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static void CalcularCirculo()
        {
            const double pi = 3.141592653589793;
            Console.Write("Digite o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine());

            double area = pi * raio * raio;
            double perimetro = 2 * pi * raio;

            Console.WriteLine($"Área do círculo: {area}");
            Console.WriteLine($"Perímetro do círculo: {perimetro}");
            Console.ReadKey();
        }

        static void CalcularQuadrado()
        {
            Console.Write("Digite o comprimento do lado do quadrado: ");
            double lado = double.Parse(Console.ReadLine());

            double area = lado * lado;
            double perimetro = 4 * lado;

            Console.WriteLine($"Área do quadrado: {area}");
            Console.WriteLine($"Perímetro do quadrado: {perimetro}");
            Console.ReadKey();
        }

        static void CalcularRetangulo()
        {
            Console.Write("Digite a largura do retângulo: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Digite o comprimento do retângulo: ");
            double comprimento = double.Parse(Console.ReadLine());

            double area = largura * comprimento;
            double perimetro = 2 * (largura + comprimento);

            Console.WriteLine($"Área do retângulo: {area}");
            Console.WriteLine($"Perímetro do retângulo: {perimetro}");
            Console.ReadKey();
        }

        static void CalcularTriangulo()
        {
            Console.Write("Digite a base do triângulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do triângulo: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Digite o comprimento do lado A do triângulo: ");
            double ladoA = double.Parse(Console.ReadLine());

            Console.Write("Digite o comprimento do lado B do triângulo: ");
            double ladoB = double.Parse(Console.ReadLine());

            Console.Write("Digite o comprimento do lado C do triângulo: ");
            double ladoC = double.Parse(Console.ReadLine());

            double area = (baseTriangulo * altura) / 2;
            double perimetro = ladoA + ladoB + ladoC;

            Console.WriteLine($"Área do triângulo: {area}");
            Console.WriteLine($"Perímetro do triângulo: {perimetro}");
            Console.ReadKey();
        }
    }
}



        

    

