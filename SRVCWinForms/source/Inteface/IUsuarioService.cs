using SRVCWebApi.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRVCWinForms.source.Inteface
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetAllUsuarios();
        Task<Usuario> GetUsuarioById(int id);
        Task<Usuario> Login(Usuario usuario);
    }
}
