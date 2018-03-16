using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Model
{
    class Equipamento
    {

        public int Id { get; set; }
        [Required]
        public Tipo tipo { get; set; }
        [Required]
        public Marca marca { get; set; }
        [Required]
        public Modelo modelo { get; set; }

    }
}
