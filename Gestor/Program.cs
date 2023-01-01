using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace Gestor
{
    class Program
    {

        static List<IEstoque> produtos = new List<IEstoque>();

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
                            Cadastro();
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
                Console.Clear();
            }
        }

        static void Cadastro()
        {
            Console.WriteLine("Cadastro de Produto");
            Console.WriteLine("1 - Produto Físico\n2 - Ebook\n3 - Curso");
            string? opStr = Console.ReadLine();
            int escolhaInt = int.Parse(opStr);
            switch (escolhaInt)
            {
                case 1:
                    CadastrarPFisico();
                    break;
                case 2:
                    CadastrarEbook();
                    break;
                case 3:
                    CadastrarCurso();
                    break;
            }
        }

        
        static void CadastrarPFisico()
        {
            Console.WriteLine("Cadastrando produto físico: ");
            Console.WriteLine("Nome: ");
            string? nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Frete: ");
            float frete = float.Parse(Console.ReadLine());
            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
            produtos.Add(pf);
        }


        static void CadastrarEbook()
        {
            Console.WriteLine("Cadastrando Ebook: ");
            Console.WriteLine("Nome: ");
            string? nome = Console.ReadLine();
            Console.WriteLine("Autor: ");
            string? autor = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());

            Ebook eb = new Ebook(nome, autor, preco);
            produtos.Add(eb);
        }


        static void CadastrarCurso()
        {
            Console.WriteLine("Cadastrando Curso: ");
            Console.WriteLine("Nome: ");
            string? nome = Console.ReadLine();
            Console.WriteLine("Autor: ");
            string? autor = Console.ReadLine();
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());

            Curso cs = new Curso(nome, autor, preco);
            produtos.Add(cs);
            Salvar();
        }


        static void Salvar()
        {
               FileStream stream = new FileStream("produtos.dat", FileMode.OpenOrCreate);
               BinaryFormatter encoder = new BinaryFormatter();

               encoder.Serialize(stream, produtos);

               stream.Close();
        }
    }
}