using System.ComponentModel.DataAnnotations;

namespace LocadoraCarros.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string DataNascimento     { get; set; }
        public string Telefone { get; set; }

    }
}
