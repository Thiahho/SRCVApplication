using SRVCWebApi.Modelos;
using SRVCWinForms.source.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SRVCWinForms.source.Service
{
    internal class UsuarioService : IUsuarioService
    {
        private const string API = "api/Usuario";
        private readonly HttpClient httpClient;

        public UsuarioService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Usuario>> GetAllUsuarios()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Usuario>>(API);

        }

        public async Task<Usuario> GetUsuarioById(int id)
        {
            return await httpClient.GetFromJsonAsync<Usuario>($"{API}/{id}");
        }

        public async Task<Usuario> Login(Usuario usuario)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync($"{API}/login", usuario);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<Usuario>();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el login: {ex.Message}");
                throw;  

            }
            //return await httpClient.PostAsJsonAsync<Usuario>($"{API}/{usuario}/{password}");
        }
    }
}
