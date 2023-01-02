using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor
{
    [System.Serializable]
    class Ebook : Produto, IEstoque
    {
        public string? autor;
        private int vendas;

        public Ebook(string? nome, string? autor, float preco)
        {
            this.nome = nome;
            this.autor = autor;
            this.preco = preco;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Não é possível dar entrada no estoque de um E-book, pois é um Produto Digital.");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            throw new NotImplementedException();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vendas: {vendas}");
            Console.WriteLine("==============================");
        }
    }
}