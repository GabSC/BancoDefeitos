using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Model
{
   public class DataGridObject 
    {
        public int EquipId { get; set; }
        public int Defeito_Id { get; set; }

        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Tipo{ get; set; }
        public String Observacao { get; set; }
        [Required]
        public String Sintoma { get; set; }
        [Required]
        public String Peca { get; set; }
        [Required]
        public String Causa { get; set; }
        [Required]
        public String Solucao { get; set; }

    }
}
