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
            Carregar();
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
                            Listagem();
                            break;
                        case Menu.Adicionar:
                            Cadastro();
                            break;
                        case Menu.Remover:
                            Remover();
                            break;
                        case Menu.Entrada:
                            Entrada();
                            break;
                        case Menu.Saída:
                            Saida();
                            break;
                        case Menu.Sair:
                            escolheuSair = true;
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


        static void Listagem()
        {
            Console.WriteLine("Lista de produtos");
            int i = 0;
            foreach (IEstoque produto in produtos)
            {
                Console.WriteLine("ID: " + i);
                produto.Exibir();
                i++;
            }
            Console.ReadLine();
        }


        static void Remover()
        {   
            Listagem();
            Console.WriteLine("Digite o ID do elemento que você quer remover:");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < produtos.Count)
            {   
                produtos.RemoveAt(id);
                Salvar();
            }
        }


        static void Entrada()
        {
            Listagem();
            Console.WriteLine("Digite o ID do elemento que você quer dar entrada: ");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < produtos.Count)
            {   
                produtos[id].AdicionarEntrada();
                Salvar();
            }
        }


        static void Saida()
        {
            Listagem();
            Console.WriteLine("Digite o ID do produto que você quer dar saída: ");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < produtos.Count)
            {
                produtos[id].AdicionarSaida();
                Salvar();
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


        static void Carregar()
        {
            FileStream stream = new FileStream("produtos.dat", FileMode.OpenOrCreate);
            BinaryFormatter encoder = new BinaryFormatter();

            try
            {
                produtos = (List<IEstoque>)encoder.Deserialize(stream);

                if (produtos == null)
                {
                    produtos = new List<IEstoque>();
                }
            }
            catch (System.Exception)
            {
                produtos = new List<IEstoque>();

                throw;
            }


            stream.Close();
        }
    }
}