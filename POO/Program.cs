
namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Filme filme = new Filme("Desordem e Regresso!", "Fim", 2023, "Societ Travel Films");
            filme.Executar();

            Filme filme1 = new Filme("Roubo e Retrocesso!", "Depois do Fim", 2023, "Societ Travel Films");
            filme1.Executar();
                                   
            Console.ReadLine();
        }

    }

}