namespace SRVCWebApi.Conexion
{
    public class Conexion
    {
        //EJEMPLO: SOLAMENTE HACER ESTOS PASOS PARA LLAMAR A LACONEXINO
        //{
        private readonly ApplicationDbContext _context;

        public Conexion(ApplicationDbContext context)
        {
            _context = context;
        }
        //}
    }
}
