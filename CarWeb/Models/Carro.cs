using System.ComponentModel.DataAnnotations;

namespace CarWeb.Models
{
    public class Carro
    {
        [Key]
        public int Codigo { get; set; }

        public string Modelo { get; set; }

        public int  Ano { get; set; }
        
        public string Tipo { get; set; }

    }
}
