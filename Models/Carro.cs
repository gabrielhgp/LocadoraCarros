using System.ComponentModel.DataAnnotations;

namespace LocadoraCarros.Models
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Modelo { get; set; }

        public string Marca { get; set; }

        public int Ano { get; set; }

        public string Cor { get; set; }


    }
}
