using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public interface IEstudiosRepository
    {
        Task<Estudio> CrearEstudiosAsync(Estudio Estudios);
        Task<bool> EliminarEstudiosAsync(Estudio Estudios);
        Estudio GetEstudiosByNum(int num);
        IEnumerable<Estudio> GetEstudioss();
        Task<bool> ActualizarEstudiosAsync(Estudio Estudios);

    }
}
