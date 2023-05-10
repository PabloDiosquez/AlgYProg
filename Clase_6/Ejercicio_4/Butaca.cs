using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class Butaca
    {
        // Atributos

        private int numero;

        // Constructor

        public Butaca(int numero)
        {
            this.numero = numero;
        }

        public int NumeroDeButaca 
        {
            get { return numero; }
        }
    }
}
