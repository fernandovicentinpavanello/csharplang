using System;

namespace Calculadora
{
    class Program
    {

        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }
        
        static void Main(string[] args)
        {   
            bool escolherSair = false;
            while (!escolherSair)
            {
                Console.WriteLine("Seja bem vindo, selecione uma das opções: ");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Soma();
                        break;
                    case Menu.Divisao:
                        Soma();
                        break;
                    case Menu.Multiplicacao:
                        Soma();
                        break;
                    case Menu.Potencia:
                        Soma();
                        break;
                    case Menu.Raiz:
                        Soma();
                        break;                
                    case Menu.Sair:
                        escolherSair = true;
                        break;
                }

                Console.Clear();
            }        
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"O resultao é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }


        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"O resultao é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }


        static void Divisao()
        {
            Console.WriteLine("Divisão de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine($"O resultao é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }


        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois números: ");
            Console.WriteLine("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine($"O resultao é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }


        static void Potencia()
        {
            Console.WriteLine("Potência de um número: ");
            Console.WriteLine("Digite a base: ");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine($"O resultao é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }


        static void Raiz()
        {
            Console.WriteLine("Raiz quadrada de um número: ");
            Console.WriteLine("Digite o número: ");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine($"O resultao é: {resultado}");
            Console.WriteLine("Aperte ENTER para voltar para o menu");
            Console.ReadLine();
        }       

    }
}
