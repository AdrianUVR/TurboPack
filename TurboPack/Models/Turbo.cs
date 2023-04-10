namespace TurboPack.Models
{
    public class Turbo
    {

        public int Id { get; set; }

        public string Imagen { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Ciudad { get; set; }


        public string sexo { get; set; }    

        public string Correo { get; set; }

        public List<object> Turbos { get; set; }
    }
}
