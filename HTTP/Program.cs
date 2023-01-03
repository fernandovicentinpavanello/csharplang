using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HTTP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var requisicao = WebRequest.Create("https://jsonplaceholder.typicode.com/todos");
            requisicao.Method = "GET";
            var resposta = requisicao.GetResponse();

            using (resposta)
            {
                var stream = resposta.GetResponseStream();
                StreamReader leitor = new StreamReader(stream);
                object dados = leitor.ReadToEnd();

                Console.WriteLine(dados.ToString());

                stream.Close();
                resposta.Close();
            }


        }
    }
}