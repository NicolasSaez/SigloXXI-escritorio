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
            OracleCommand comando = new OracleCommand("SP_obtener_cod_cant", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("id_cocina", OracleType.Number).Value = Convert.ToInt32(txtidpedido.Text);
            comando.Parameters.Add("codcocina", OracleType.Number).Direction = ParameterDirection.Output;
            comando.Parameters.Add("cantcocina", OracleType.Number).Direction = ParameterDirection.Output;
            comando.ExecuteNonQuery();
            int param1 = Convert.ToInt32(comando.Parameters["codcocina"].Value);
            int param2 = Convert.ToInt32(comando.Parameters["cantcocina"].Value);




            OracleCommand comando1 = new OracleCommand("SP_pedido_entregado", conexion);
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtidpedido.Text);

            comando1.ExecuteNonQuery();
            MessageBox.Show("Pedido entregado");
            conexion.Close();

            restarStock(param1, param2);

            if (alertaStock(param1) < 20)
            {
                MessageBox.Show("Reponer Stock'BAJO 10 DE STOCK'");
            }

        }

        public bool restarStock(int ID_COCINA, int CANTIDAD)
        {
            conexion.Open();
            OracleCommand comando1 = new OracleCommand("SP_restar_stock", conexion);
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.Add("id_rec", OracleType.Number).Value = ID_COCINA;
            comando1.Parameters.Add("cant", OracleType.Number).Value = CANTIDAD;
            comando1.ExecuteNonQuery();

            conexion.Close();
            return true;
        }


        public int alertaStock(int ID_RECETA)
        {
            conexion.Open();
            OracleCommand comando2 = new OracleCommand("SP_alerta_stock", conexion);
            comando2.CommandType = System.Data.CommandType.StoredProcedure;
            comando2.Parameters.Add("id_receta", OracleType.Number).Value = ID_RECETA;
            comando2.Parameters.Add("cantidadTotal", OracleType.Number).Direction = ParameterDirection.Output;
            comando2.ExecuteNonQuery();
            int resultado = Convert.ToInt32(comando2.Parameters["cantidadTotal"].Value);

            conexion.Close();
            return resultado;
        }
    }
}
