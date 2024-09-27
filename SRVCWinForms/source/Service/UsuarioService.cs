using SRVCWebApi.Controllers;
using SRVCWebApi.Modelos;
using SRVCWebApi.Repositorios;
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
        private readonly UsuarioRepositorio _usuarioRepositorio;


        public UsuarioService()
        {
        }

        public UsuarioService(HttpClient httpClient )
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
                var response = await httpClient.PostAsJsonAsync($"{API}/Login", usuario);
                if (response.IsSuccessStatusCode)
                {
                    var user=  await response.Content.ReadFromJsonAsync<Usuario>();
                    if (user != null)
                    {
                        return user;
                    }
                    else
                    {
                        throw new Exception("La respuesta de la API no contiene un usuario.");    
                    }
                }
                else
                {
                    throw new Exception("La respuesta de la API es nula.");
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
