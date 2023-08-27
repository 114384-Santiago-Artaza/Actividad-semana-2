using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_semana_2.Entidades
{
    internal class Tipo
    {
        public int CodTipo { get; set; }
        public string TipoC { get; set; }

        public Tipo() 
        { 
         CodTipo = 0;
         TipoC = string.Empty;
        
        
        }
        public Tipo(int codtipo,string tipo) 
        {
            CodTipo = codtipo;
            TipoC = tipo;

        }   



    }
}
