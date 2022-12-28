using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor
{
    class Program
    {

        enum Menu { Listar = 1, Adicionar, Remover, Entrada, Saída, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while(escolheuSair == false)
            {
                Console.WriteLine("Sistema de estoque:\n");
                Console.WriteLine("1 - Listar\n2 - Adicionar\n3 - Remover\n4 - Entrada\n5 - Saída\n6 - Sair");
                string? opStr = Console.ReadLine();
                int opInt = int.Parse(opStr);
                
                if(opInt > 0 && opInt < 7)
                {
                    Menu escolha = (Menu)opInt;
                    switch (escolha)
                    {
                        case Menu.Listar:
                            break;
                        case Menu.Adicionar:
                            break;
                        case Menu.Remover:
                            break;
                        case Menu.Entrada:
                            break;
                        case Menu.Saída:
                            break;
                        case Menu.Sair:
                            break;
                    }
                }
                else
                {
                    escolheuSair = true;
                }
                
            }
        }
    }
}