using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Model
{
    class Defeito
    {

        public int Id { get; set; }
        public String Peca { get; set; }
        public String Solucao { get; set; }
       
        public String DescricaoDefeito { get; set; }
        public String Causa { get; set; }

    }
}
