using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    [Table("Funcionarios")]
    public class Funcionarios
    {
        [Key]
        [Column("id")]
        public required int IdFuncionarios { get; set; }

        [Column("Nome")]
        public required string Nome { get; set; }

        [Column("Email")]
        public required string Email { get; set; }

        [Column("SenhaHash")]
        public required string SenhaHash { get; set; }
    }
}