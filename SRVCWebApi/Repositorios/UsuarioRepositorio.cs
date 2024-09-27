using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SRVCWebApi.Modelos;

namespace SRVCWebApi.Repositorios
{
    public class UsuarioRepositorio 
    {
        private readonly ApplicationDbContext _context;

        public UsuarioRepositorio(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario> Login(string usuario, string password)
        {
            Usuario user = null;
            try
            {
                var query = "SELECT * FROM usu WHERE usu = @usuario and pass=@password";
                user= await _context.Usuarios.FromSqlRaw(query,
                    new SqlParameter("@usuario", usuario),
                    new SqlParameter("@password", password)
                    ).FirstOrDefaultAsync();

                if (user == null)
                {
                    throw new Exception("Usuario o Contraseña inválida.");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Error, no se ha podido obtener el usuario. {ex.Message}");
            }
            return user;
        }


        public async Task<Usuario> GetUsuarioByIdAsync(int id)
        {
            try
            {
                var query = "SELECT * FROM usu WHERE Id = @id";
                return await _context.Usuarios.FromSqlRaw(query, new SqlParameter("@id", id)).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Error, no se ha podido obtener el usuario con Id. {ex.Message}");
            }
        }

        public async Task<IEnumerable<Usuario>> GetAllUsuario()
        {
            try
            {
                var query = "select * from usu";
                return await _context.Usuarios.FromSqlRaw(query).ToListAsync();

            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
                return new List<Usuario>(); 
            }
        }

        
    }
}
