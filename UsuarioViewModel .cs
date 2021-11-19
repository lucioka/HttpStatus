namespace Novit.HttpStatus.Controllers.V1.ViewModels
{
    public class UsuarioViewModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int estado { get; set; }
    }
}
