using System;
namespace CSharpExamples
{
    public class Cliente
    {
        public String nombre { get; set; }
        public int edad { get; set; } 
        public Cliente()
        {
        }
        public Cliente(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}
