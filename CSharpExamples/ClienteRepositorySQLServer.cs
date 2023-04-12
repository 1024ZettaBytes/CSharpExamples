using System;
namespace CSharpExamples
{
    public class ClienteRepositorySQLServer : ICLienteRepository
    {
        public ClienteRepositorySQLServer()
        {
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void guardar(Cliente cliente)
        {
            System.Console.WriteLine("Cliente " + cliente.nombre + " guardado en SQL Server DB");
        }
    }
}
