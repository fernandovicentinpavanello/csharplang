using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Filme
    {
        // ############ VARIÁVEIS ############
        public string? nome;
        public string? desc;
        public int ano;
        public string? studio;
        public List<string> atores = new List<string>();

        static public string plataforma = "Prime";

        public Filme(string nome, string desc, int ano, string studio)
        {
            this.nome = nome;
            this.desc = desc;
            this.ano = ano;
            this.studio = studio;
        }


        // ############ MÉTODOS ############
        public void Executar()
        {
            Console.WriteLine("Rodando filme: " + nome);
            Console.WriteLine("Descrição do filme: " + desc);
            Console.WriteLine("Ano do filme: " + ano);
            Console.WriteLine("Estudio: " + studio);
            Console.WriteLine("--------------------");
        }

        public void Pausar()
        {
            Console.WriteLine("||");
        }
    }
}