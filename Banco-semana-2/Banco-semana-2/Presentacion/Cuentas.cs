using Banco_semana_2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Banco_semana_2
{
    public partial class Cuentas : Form
    {
        Cuenta nueva;
        bool primera;
        public Cuentas()
        {
            InitializeComponent();
            nueva = new Cuenta();
            primera = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CargarPersonas();
            CargarTipo();

        }

        private void CargarTipo()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=Abbys;Initial Catalog=Banco_Eje;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = conexion.CreateCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_tipo";
            DataTable table = new DataTable();
            table.Load(comando.ExecuteReader());
            conexion.Close();

            CboTipo.DataSource = table;
            CboTipo.ValueMember = table.Columns[0].ColumnName;
            CboTipo.DisplayMember = table.Columns[1].ColumnName;


        }

        private void CargarPersonas()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=Abbys;Initial Catalog=Banco_Eje;Integrated Security=True";
            conexion.Open();
            SqlCommand comando =conexion.CreateCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "SP_CONSULTAR_CLIENTES";
            DataTable table= new DataTable();
            table.Load(comando.ExecuteReader());
            conexion.Close();

            CboCliente.DataSource= table;
            CboCliente.ValueMember= table.Columns[0].ColumnName;
            CboCliente.DisplayMember = table.Columns[1].ColumnName;




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgCuentas.CurrentCell.ColumnIndex == 6)
            {
                nueva.QuitarDetalle(DgCuentas.CurrentRow.Index);
                DgCuentas.Rows.RemoveAt(DgCuentas.CurrentRow.Index);

            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (Validador())
            {

                DataRowView item = (DataRowView)CboCliente.SelectedItem;
                int Cod = Convert.ToInt32(item.Row.ItemArray[0]);
                string nom = item.Row.ItemArray[1].ToString();
                string ape = item.Row.ItemArray[2].ToString();
                int dni = Convert.ToInt32(item.Row.ItemArray[3]);
                Cliente p = new Cliente(Cod, nom, ape,dni);

                DataRowView tutu = (DataRowView)CboTipo.SelectedItem;
                int Tipo = Convert.ToInt32(tutu.Row.ItemArray[0]);
                string tipon = tutu.Row.ItemArray[1].ToString();
                Tipo t = new Tipo(Tipo,tipon);

                int cbu = Convert.ToInt32(TxtCbu.Text);
                int saldo=Convert.ToInt32(TxtSaldo.Text);
                string ultimo = Convert.ToString(TxtUltimo.Text);
                Cuenta cuent = new Cuenta(cbu,saldo,t,p,ultimo);

                for (int i = 0; i < DgCuentas.Rows.Count; i++)
                {
                    if (DgCuentas.Rows[i].Cells["ColCbu"].Value != null &&
                        int.TryParse(DgCuentas.Rows[i].Cells["ColCbu"].Value.ToString(), out int cbuValue))
                    {
                        if (cuent.Cbu == cbuValue)
                        {
                            MessageBox.Show("Valor de Cbu duplicado");
                            return;
                        }
                    }
                }


                nueva.AgregarDetalle(t,p);

                DgCuentas.Rows.Add("",cuent.Cbu, cuent.Saldo, cuent.tipos.TipoC,cuent.clientes.Nombre,cuent.Ultimo, "quitar");
               
               
                

            }
        }
        private bool Validador()
        {
            if (TxtCbu.Text =="")
            {
                MessageBox.Show("Ingrese un Cbu ");
                return false;
            }
            try
            {
                int.Parse(TxtCbu.Text);

            }
            catch
            {
                MessageBox.Show("Ingrese un Cbu valido  ");
                return false;
            }

            if (TxtSaldo.Text == "")
            {
                MessageBox.Show("Ingrese un Saldo ");
                return false;

            }
            try
            {
                int.Parse(TxtSaldo.Text);

            }
            catch
            {
                MessageBox.Show("Ingrese un Saldo valido  ");
                return false;
            }

            if(CboCliente.SelectedIndex == -1) 
            {
                MessageBox.Show("Seleccione un cliente  ");
                return false;
            }

            if (CboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de cuenta  ");
                return false;
            }

            if (TxtUltimo.Text =="")
            {
               
                    MessageBox.Show(" Ingrese un ultimo Movimiento");
                    return false;
                
            }

            foreach (DataGridViewRow Fila in DgCuentas.Rows)
            {
                if (Fila.Cells["ColCliente"].Value.ToString().Equals(CboCliente.Text))
                {
                    MessageBox.Show("Este Cliente ya tiene una cuenta creada"
                           , "Control"
                           , MessageBoxButtons.OK
                           , MessageBoxIcon.Exclamation);
                    return false; 

                }

            }
            return true;
        }



    }
}
