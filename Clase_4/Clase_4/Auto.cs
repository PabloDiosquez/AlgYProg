using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4
{
    internal class Auto
    {
        private string marca;

        private int modelo;

        // Constructor
        public Auto()
        {

        }

        // Métodos Getters y Setters 👌🏼
        public void SetMarca(string marca) 
        {
            this.marca = marca;
        }

        public string GetMarca()
        {
            return marca;
        }

        public void SetModelo(int modelo)
        {
            this.modelo = modelo;
        }

        public int GetModelo()
        {
            return modelo;
        }

        // Otros métodos...

        public string ImprimirDatos()
        {
            return $"Marca: {marca} -- Modelo: {modelo}";
        }
    }
}
