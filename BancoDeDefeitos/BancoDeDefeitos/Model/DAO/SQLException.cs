using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDefeitos.Model.DAO
{
    class SQLException : Exception
    {

        public SQLException(string msg) : base (msg)
        {

        }

    }
}
