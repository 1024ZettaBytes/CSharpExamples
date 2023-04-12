using System;
namespace CSharpExamples
{
    public class ClienteRepositoryMongo: ICLienteRepository
    {
        public ClienteRepositoryMongo()
        {
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void guardar(Cliente cliente)
        {
            System.Console.WriteLine("Cliente " + cliente.nombre + " guardado en Mongo DB");
        }
    }
}
