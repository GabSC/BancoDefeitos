using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Model
{
    class Marca
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100,MinimumLength = 2)]
        public String Nome { get; set; }

        public override string ToString() // sobrescrita de metodo necessária para o combobox mostrar somente o nome,ou o que for retornado pelo toString
        {
            return Nome;
        }

    }
}
