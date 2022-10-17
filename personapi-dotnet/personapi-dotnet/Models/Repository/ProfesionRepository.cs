using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public class ProfesionRepository : IProfesionRepository
    {
        protected readonly persona_dbContext _context;
        public ProfesionRepository(persona_dbContext context) => _context = context;
        public async Task<bool> ActualizarProfesionAsync(Profesion profesion)
        {
            _context.Entry(profesion).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Profesion> CrearProfesionAsync(Profesion profesion)
        {
            await _context.Set<Profesion>().AddAsync(profesion);
            await _context.SaveChangesAsync();
            return profesion;
        }

        public async Task<bool> EliminarProfesionAsync(Profesion profesion)
        {
            //var entity = await GetByIdAsync(id);
            if (profesion is null)
            {
                return false;
            }
            _context.Set<Profesion>().Remove(profesion);
            await _context.SaveChangesAsync();

            return true;
        }

        public Profesion GetProfesionByNum(int num)
        {
            return _context.Profesions.Find(num);
        }

        public IEnumerable<Profesion> GetProfesions()
        {
            return _context.Profesions.ToList();
        }
    }
}
