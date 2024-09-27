using Microsoft.AspNetCore.Mvc;
using SRVCWebApi.Modelos;
using SRVCWebApi.Repositorios;

namespace SRVCWebApi.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class HistorialController : ControllerBase
    {
        private readonly HistorialRepositorio _historialRepositorio;

        public HistorialController(HistorialRepositorio historialRepositorio)
        {
            _historialRepositorio = historialRepositorio;
        }

        [HttpGet("id")]
        public async Task<ActionResult<Registro>> GetRegistroById(int id)
        {
            var registro = await _historialRepositorio.GetRegistroById(id);
            if (registro == null)
            {
                return NotFound();
            }
            return Ok(registro);

        }

        [HttpGet("buscar")]
        public async Task<ActionResult<List<Registro>>> BuscarRegistro([FromQuery]string condicion,DateTime desde,DateTime hasta)
        {
            var registros= await _historialRepositorio.BuscarRegistros(condicion, desde, hasta);
            if (registros == null || registros.Count == 0)
            {
                return NotFound("No se han encontrado registros en el historial.");
            }
            return Ok(registros);
        }



    }
}
