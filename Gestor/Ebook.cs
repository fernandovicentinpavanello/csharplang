using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestor
{
    class Ebook : Produto, IEstoque
    {
        public string? autor;
        private int vendas;

        public Ebook(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            throw new NotImplementedException();
        }

        public void AdicionarSaida()
        {
            throw new NotImplementedException();
        }

        public void Exibir()
        {
            throw new NotImplementedException();
        }
    }
}