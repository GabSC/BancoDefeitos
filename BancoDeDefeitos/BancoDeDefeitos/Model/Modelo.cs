using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Model
{
    class Modelo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;     
        }

    }
}
