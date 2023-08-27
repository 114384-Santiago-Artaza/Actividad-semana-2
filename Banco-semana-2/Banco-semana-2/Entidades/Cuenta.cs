using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_semana_2.Entidades
{
    internal class Cuenta
    {
        public int Cbu { get; set; }
        public int Saldo { get; set; }
        public Tipo tipos { get; set; }
        public Cliente clientes { get; set; }
        public List<Tipo> tipo { get; set; }
        public List<Cliente> cliente { get; set; }
        public string Ultimo { get; set; }

        public Cuenta()
        {
            tipo = new List<Tipo>();
            cliente = new List<Cliente>();
        }

        public void AgregarDetalle(Tipo detalle, Cliente client)
        {
            tipo.Add(detalle);
            cliente.Add(client);
        }

        public void QuitarDetalle(int posicion)
        {
            tipo.RemoveAt(posicion);
            cliente.RemoveAt(posicion);
          
        }

        public Cuenta(int cbu, int saldo, Tipo tipos, Cliente clientes, string ultimo)
        {
            Cbu = cbu;
            Saldo = saldo;
            this.tipos = tipos;
            this.clientes = clientes;
            Ultimo = ultimo;
        }
    }
}
