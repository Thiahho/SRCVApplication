using Microsoft.AspNetCore.Mvc;
using SRVCWebApi.Modelos;
using SRVCWinForms.source.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SRVCWinForms.source.Service
{
    internal class HistorialService : IHistorialService
    {
        private const string API = "api/Historial";
        private readonly HttpClient httpClient;

        public HistorialService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    
        public async Task<ActionResult<List<Registro>>> BuscarRegistro([FromQuery] string condicion, DateTime desde, DateTime hasta)
        {
            try
            {
                var parametros = $"?condicion={condicion}$desde={desde.ToString("yyyy-MM-dd")}&hasta={hasta.ToString("yyyy-MM-dd")}";
                return await httpClient.GetFromJsonAsync<List<Registro>>($"{API}/buscar/{parametros}");
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public async Task<Registro> GetRegistroById(int id)
        {
            try
            {
                return await httpClient.GetFromJsonAsync<Registro>($"{API}/{id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el registro con ID {id}: {ex.Message}");
                throw new Exception(ex.Message);
            }
        }

    }
}
