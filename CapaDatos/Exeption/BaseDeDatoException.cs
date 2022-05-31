using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Exeption
{
    public class BaseDeDatoException : Exception
    {
        public BaseDeDatoException(string mensaje):base(mensaje)
        {
        }

        public BaseDeDatoException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
    }
}
