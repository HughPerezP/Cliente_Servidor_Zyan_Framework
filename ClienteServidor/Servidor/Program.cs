using Compartida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zyan.Communication;

namespace Servidor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create component host named "ZyanDemo" and bind to TCP port 8080
            var host = new ZyanComponentHost("ZyanDemo", 8080);

            // Register component type and interface
            host.RegisterComponent<IOperaciones, ServicioOperacion>();
            System.Console.WriteLine("Servidor iniciado");
            System.Console.ReadLine();
        }
    }
}
