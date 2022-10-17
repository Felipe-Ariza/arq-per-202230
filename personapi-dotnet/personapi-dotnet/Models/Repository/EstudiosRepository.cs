using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public class EstudiosRepository : IEstudiosRepository
    {

        protected readonly persona_dbContext _context;
        public EstudiosRepository(persona_dbContext context) => _context = context;

        public async Task<bool> ActualizarEstudiosAsync(Estudio Estudios)
        {
            _context.Entry(Estudios).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Estudio> CrearEstudiosAsync(Estudio Estudios)
        {
            await _context.Set<Estudio>().AddAsync(Estudios);
            await _context.SaveChangesAsync();
            return Estudios;
        }

        public async Task<bool> EliminarEstudiosAsync(Estudio Estudios)
        {
            //var entity = await GetByIdAsync(id);
            if (Estudios is null)
            {
                return false;
            }
            _context.Set<Estudio>().Remove(Estudios);
            await _context.SaveChangesAsync();

            return true;
        }

        public Estudio GetEstudiosByNum(int num)
        {
            return _context.Estudios.Find(num);
        }

        public IEnumerable<Estudio> GetEstudioss()
        {
            return _context.Estudios.ToList();
        }
    }
}
