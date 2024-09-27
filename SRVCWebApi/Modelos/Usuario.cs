namespace SRVCWebApi.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Tipo { get; set; }
        public Usuario(int id, string nombre, string password, string tipo)
        {
            Id = id;
            Nombre = nombre;
            Password = password;
            Tipo = tipo;
        }
        //protected string Apellido { get; set; }
        //protected string Dni { get; set; }

        public Usuario() { }
    }
}
