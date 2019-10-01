using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            EchoCliente.Echo echo = new EchoCliente.EchoClient();

            Console.Write("Digite sua Frase: ");

            var body = new EchoCliente.echoRequestBody(Console.ReadLine());
            var request = new EchoCliente.echoRequest(body);
            var response = echo.echo(request);

            Console.WriteLine(response.Body.@return);
            Console.ReadLine();

        }
    }
}
