using System;

namespace CSharpExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            ICLienteRepository clientesFunciones = null;
            if(opcion==1)
                clientesFunciones = new ClienteRepositorySQLServer();
            if (opcion == 2) clientesFunciones = new ClienteRepositoryMongo();

            Cliente clienteNuevo = new Cliente("Jesús Eduardo Ramírez Cota", 24);
            
            clientesFunciones.guardar(clienteNuevo);
        }
    }
}
