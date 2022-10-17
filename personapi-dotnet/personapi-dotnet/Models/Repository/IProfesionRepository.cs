using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface IProfesionRepository
    {
        Task<Profesion> CrearProfesionAsync(Profesion profesion);
        Task<bool> EliminarProfesionAsync(Profesion profesion);
        Profesion GetProfesionByNum(int num);
        IEnumerable<Profesion> GetProfesions();
        Task<bool> ActualizarProfesionAsync(Profesion profesion);
    }
}
