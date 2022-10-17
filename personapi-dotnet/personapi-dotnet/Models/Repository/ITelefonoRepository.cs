using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface ItelefonoRepository
    {
        Task<Telefono> CrearTelefonoAsync(Telefono telefono);
        Task<bool> EliminarTelefonoAsync(Telefono telefono);
        Telefono GetTelefonoByNum(int num);
        IEnumerable<Telefono> GetTelefonos();
        Task<bool> ActualizarTelefonoAsync(Telefono telefono);
    }
}
