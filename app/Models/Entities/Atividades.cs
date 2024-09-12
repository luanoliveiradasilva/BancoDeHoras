
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    [Table("Atividades")]
    public class Atividades
    {
        [Key]
        [Column("id")]
        public int IdAtividade { get; set; }
        [Column("FuncionarioId")]
        public int FuncionarioId { get; set; }
        [Column("RegistroDeHoraId")]
        public int RegistroDeHoraId { get; init; }
        [Column("Descricao")]
        public required string Descricao { get; set; }
    }
}