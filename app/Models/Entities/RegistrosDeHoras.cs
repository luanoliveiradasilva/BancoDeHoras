
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    [Table("RegistrosDeHoras")]
    public class RegistrosDeHoras
    {
        [Key]
        [Column("id")]
        public int IdFuncionarios { get; set; }
        [Column("FuncionarioId")]
        public int FuncionarioId { get; set; }
        [Column("HoraInicio")]
        public DateTime HoraInicio { get; set; }
        [Column("HoraPausaAlmoco")]
        public DateTime HoraPausaAlmoco { get; set; }
        [Column("HoraRetornoAlmoco")]
        public DateTime HoraRetornoAlmoco { get; set; }
        [Column("HoraTerminoAlmoco")]
        public DateTime HoraTerminoAlmoco { get; set; }
        [Column("TotalHoras")]
        public DateTime TotalHoras { get; set; }
    }
}