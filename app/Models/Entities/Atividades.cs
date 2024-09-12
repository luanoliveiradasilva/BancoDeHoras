
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    [Table("Atividades")]
    public class Atividades
    {
        public int FuncionarioId { get; set; }
        public int RegistroDeHoraId { get; init; }
        public string Descricao { get; set; }
    }
}