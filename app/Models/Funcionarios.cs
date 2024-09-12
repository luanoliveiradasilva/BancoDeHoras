using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class Funcionarios
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
    }
}