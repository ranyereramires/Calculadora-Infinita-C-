using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace CalculadoraInfinita
{
    class CalculadoraInfinita
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            int operacao = 0;
            double resultado;

            Console.WriteLine("Seja bem-vindo(a) a calculadora do console");
            Console.WriteLine("lembre-se de que para utilizar números com casas decimais, use ponto no lugar da vírgula");
            Console.WriteLine();

            Console.Write("Informe o primeiro número da operação: ");
            number1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            while (operacao != null)
            {
                Console.WriteLine("Informe a operação desejada");
                Console.Write("1 para somar, 2 para diminuir, 3 para multiplicar, 4 para dividir: ");
                operacao = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Digite o próximo número: ");
                number2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                if (operacao != null)
                {

                    if (operacao == 1)
                    {
                        resultado = number1 + number2;
                        Console.WriteLine("O resultado atual da sua operação é {0}", resultado);
                        Console.WriteLine();
                        number1 = resultado;


                    }

                    if (operacao == 2)
                    {
                        resultado = number1 - number2;
                        Console.WriteLine("O resultado atual da sua operação é {0}", resultado);
                        Console.WriteLine();
                        number1 = resultado;

                    }

                    if (operacao == 3)
                    {
                        resultado = number1 * number2;
                        Console.WriteLine("O resultado atual da sua operação é {0}", resultado);
                        Console.WriteLine();
                        number1 = resultado;

                    }

                    if (operacao == 4)
                    {
                        resultado = number1 / number2;
                        Console.WriteLine("O resultado atual da sua operação é {0}", resultado);
                        Console.WriteLine();
                        number1 = resultado;

                    }

                    else
                    {
                        Console.WriteLine("O número informado não corresponde a nenhuma operação, informe novamente a operação e o número desejado");
                        Console.WriteLine();

                        
                    }


                }

            }

        }

    }
}