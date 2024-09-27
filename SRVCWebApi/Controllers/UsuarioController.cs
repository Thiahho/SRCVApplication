using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using SRVCWebApi.Modelos;
using SRVCWebApi.Repositorios;

namespace SRVCWebApi.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        //[HttpPost("login")]
        //public async Task<IActionResult> Login([FromBody]Usuario usuario)
        //{
        //    if (usuario == null || string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Password))
        //    {
        //        return BadRequest("Datos inválidos.");

        //    }
        //    try
        //    {
        //        var user = await _usuarioRepositorio.Login(usuario.Nombre, usuario.Password);
        //        return Ok(user);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Unauthorized(ex.Message);
        //    }
        //}

        [HttpPost]
        public async Task<ActionResult<Usuario>> Login([FromBody]Usuario usuario)
        {
            try
            {
                var user = await _usuarioRepositorio.GetByUsernamePass(usuario.Nombre, usuario.Password);
                return user == null ? NotFound() : user;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsuarios()
        {
            try
            {
                var usuarios = await _usuarioRepositorio.GetAllUsuario();
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetUsuarioById(int id)
        {
            try
            {
                var usuario = await _usuarioRepositorio.GetUsuarioByIdAsync(id);
                if (usuario == null)
                {
                    return NotFound();
                }
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }




    }
}
