using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_semana_2.Entidades
{
    internal class Cliente
    {

        public int CodigoCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }


        public Cliente()
        {
            CodigoCliente = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Dni = 0;
        }

        public Cliente(int codigo,string nombre,string apellido,int dni)
        {
            CodigoCliente= codigo;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }

        public override string ToString()
        {
            return Nombre;
        }
        

    }
}
