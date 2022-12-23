
namespace POO 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Filme filme = new Filme();
            filme.nome = "Scarface";
            filme.Executar();

            Console.ReadLine();
        }
    } 

    class Filme
    {
        public string nome;
        public string desc;
        public int ano;
        public string studio;
        public List<string> atores = new List<string>();


        public void Executar()
        {
            Console.WriteLine("Rodando filme: " + nome);
        }

        public void Pausar()
        {
            Console.WriteLine("||");
        }
    }

}