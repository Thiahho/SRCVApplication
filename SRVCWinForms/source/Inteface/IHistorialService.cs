using Microsoft.AspNetCore.Mvc;
using SRVCWebApi.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRVCWinForms.source.Inteface
{
    public interface IHistorialService
    {
        Task<ActionResult<Registro>> GetRegistroById(int id);
        Task<ActionResult<List<Registro>>> BuscarRegistro([FromQuery] string condicion, DateTime desde, DateTime hasta);
    }
}
