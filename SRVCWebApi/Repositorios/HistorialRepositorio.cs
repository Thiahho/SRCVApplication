using Microsoft.EntityFrameworkCore;
using SRVCWebApi.Modelos;

namespace SRVCWebApi.Repositorios
{
    public class HistorialRepositorio
    {
        private readonly ApplicationDbContext _context;
    
        public HistorialRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Registro>GetRegistroById(int id)
        {
            return await _context.Registro.FindAsync(id);
        }

        public async Task<List<Registro>> BuscarRegistros(string condicion, DateTime desde, DateTime hasta)
        {
            var query= _context.Registro.AsQueryable();
            if (!string.IsNullOrEmpty(condicion))
            {
                query = query.Where(r => EF.Functions.Like(r.Departamento, $"{condicion}"));
            }
            query= query.Where(r=>r.HoraDeIngreso >= desde && r.HoraDeSalida <= hasta);

            return await query.ToListAsync();    
        }




    }
}
