using System;
namespace CSharpExamples
{
    public interface ICLienteRepository
    {
        void guardar(Cliente cliente);

        void eliminar(int id);
    }
}
