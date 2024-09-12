
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    [Table("RegistrosDeHoras")]
    public class RegistrosDeHoras
    {
        public int IdFuncionarios { get; set; }
        public int FuncionarioId { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraPausaAlmoco { get; set; }
        public DateTime HoraRetornoAlmoco { get; set; }
        public DateTime HoraTerminoAlmoco { get; set; }
        public DateTime TotalHoras { get; set; }
    }
}