using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Factura
{
    public partial class Pedidos : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe ; PASSWORD = 123 ; USER ID = nicolas");
        public Pedidos()
        {
            InitializeComponent();
            
        }
        

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 ventana2 = new Form1();

            ventana2.Show();
        }


        

        private void btnpedidos_Click(object sender, EventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("SP_cargar_pedidos", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("pedidos", OracleType.Cursor).Direction = ParameterDirection.Output;


            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gvpedidos.DataSource = tabla;
            conexion.Close();
        }

        private void btnentregado_Click(object sender, EventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("SP_pedido_entregado", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtidpedido.Text);
      
            comando.ExecuteNonQuery();
            MessageBox.Show("Pedido entregado");
            conexion.Close();

        }
    }
}
