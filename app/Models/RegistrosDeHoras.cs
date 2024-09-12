using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class RegistrosDeHoras
    {
        public DateTime HoraInicio { get; set; }
        public DateTime HoraPausaAlmoco { get; set; }
        public DateTime HoraRetornoAlmoco { get; set; }
        public DateTime HoraTerminoAlmoco { get; set; }
        public DateTime TotalHoras { get; set; }
    }
}