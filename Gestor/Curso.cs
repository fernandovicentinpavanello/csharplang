using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor
{
    [System.Serializable]
    class Curso : Produto, IEstoque
    {
        public string? autor;
        private int vagas;

        public Curso(string nome, string autor, float preco)
        {
            this.nome = nome;
            this.autor = autor;
            this.preco = preco;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar vagas no curso {nome}");
            Console.WriteLine("Digite a Qtd. de vagas que você quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            vagas += entrada;
            Console.WriteLine("Entrada registrada.");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Remover vagas no curso {nome}");
            Console.WriteLine("Digite a Qtd. de vagas que você quer remover: ");
            int entrada = int.Parse(Console.ReadLine());
            vagas -= entrada;
            Console.WriteLine("Saída registrada.");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vagas restantes: {vagas}");
            Console.WriteLine("==============================");
        }
    }
}