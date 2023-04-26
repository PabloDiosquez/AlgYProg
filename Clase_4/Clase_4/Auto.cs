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

        private double velocidad;

        // Constructor
        public Auto(string marca, int modelo) : this()
        {
            this.marca = marca;

            this.modelo = modelo;
        }

        // Sobrecarga de constructores

        public Auto(string marca, string modelo) : this(marca, int.Parse(modelo))
        {

        }

        public Auto()
        {
            velocidad = 0;
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

        public double GetVelocidad()
        {
            return velocidad;
        }

        // Otros métodos...

        public string ImprimirDatos()
        {
            return $"Marca: {marca} -- Modelo: {modelo}";
        }

        // Sobrecarga de métodos.
        public void Acelerar()
        {
            velocidad += 10;
        }

        public void Acelerar(int valor)
        {
            velocidad += valor;
        }

        public void Acelerar(double coeficiente) 
        {
            velocidad *= coeficiente;   
        }
    }
}
