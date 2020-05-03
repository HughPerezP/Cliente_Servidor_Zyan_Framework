using Compartida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor
{
    class ServicioOperacion : IOperaciones
    {
        public int sumar(int a, int b)
        {
            return a + b;
        }
    }
}
