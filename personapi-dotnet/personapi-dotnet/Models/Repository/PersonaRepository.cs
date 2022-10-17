using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;

namespace personapi_dotnet.Models.Repository
{
    public class PersonaRepository : IPersonaRepository
    {
        protected readonly persona_dbContext _context;
        public PersonaRepository(persona_dbContext context) => _context = context;

        public IEnumerable<Persona> GetPersonas()
        {
            return _context.Personas.ToList();
        }

        public Persona GetPersonabyCc(int cc)
        {
            return _context.Personas.Find(cc);
        }
        public async Task<Persona> CrearPersonaAsync(Persona persona)
        {
            await _context.Set<Persona>().AddAsync(persona);
            await _context.SaveChangesAsync();
            return persona;
        }

        public async Task<bool> ActualizarPersonaAsync(Persona persona)
        {
            _context.Entry(persona).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> EliminarPersonaAsync(Persona persona)
        {
            //var entity = await GetByIdAsync(id);
            if (persona is null)
            {
                return false;
            }
            _context.Set<Persona>().Remove(persona);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
