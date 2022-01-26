using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ErrordeDatosException : Exception
    {
        /// <summary>
        /// Constructor con parametros.
        /// </summary>
        /// <param name="message"></param>
        public ErrordeDatosException(string message) : base(message)
        {
        }
    }
}
