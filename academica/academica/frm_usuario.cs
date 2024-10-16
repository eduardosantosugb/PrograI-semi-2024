using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academica
{
    public partial class frm_usuario : Form
    {

        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        String accion = "nuevo";
        public frm_usuario()
        {
            InitializeComponent();
        }

        private void grbDatosUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void usuario_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            miTabla = ds.Tables["usuario"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["IdUsuario"] };
            grdDatosUsuario.DataSource = miTabla;
            mostrarDatosUsuario();
        }

        private void mostrarDatosUsuario()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtIdUsuario.Text  = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtUsuario.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtClaveUsuario.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtNombreUsuario.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                txtDuiDocente.Text = miTabla.Rows[posicion].ItemArray[5].ToString();
                txtGmailDocente.Text = miTabla.Rows[posicion].ItemArray[6].ToString();

                lblRegistrosUsuario.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
        }

        private void grdDatosUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSiguienteUsuario_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosUsuario();
            }
            else
            {
                MessageBox.Show("Esta en el ultimo registro", "Navegacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorUsuario_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosUsuario();
            }
            else
            {
                MessageBox.Show("Esta en el primer registro", "Navegacion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoUsuario_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosUsuario();
        }

        private void btnPrimeroUsuario_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosUsuario();
        }

        private void estadoControles(Boolean estado)
        {
            grbDatosUsuario.Enabled = estado;
            grbNavegacionUsuario.Enabled = !estado;
            btnEliminarUsuario.Enabled = !estado;
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {

            if (btnNuevoUsuario.Text == "Nuevo")
            {
                btnNuevoUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                accion = "nuevo";
                estadoControles(true);
                limpiarCajas();
            }
            else
            {//Guardar
                String[] usuario = {
                    accion, miTabla.Rows[posicion].ItemArray[0].ToString(),
                    txtIdUsuario.Text, txtUsuario.Text,txtClaveUsuario.Text, txtNombreUsuario.Text, txtDuiDocente.Text , txtGmailDocente.Text
                };
                String respuesta = objConexion.administrarUsuario(usuario);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnNuevoUsuario.Text = "Nuevo";
                    btnModificarUsuario.Text = "Modificar";
                    estadoControles(false);
                    actualizarDs();
                }
            }
        }
        void limpiarCajas()
        {
            txtIdUsuario.Text = "";
            txtUsuario.Text = "";
           txtClaveUsuario.Text = "";
            txtNombreUsuario.Text = "";
            txtDuiDocente.Text = "";
            txtDuiDocente.Text = "";
            txtGmailDocente.Text = "";
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {

            if (btnModificarUsuario.Text == "Modificar")
            {
                btnNuevoUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                accion = "modificar";
                estadoControles(true);

            }
            else
            {//Cancelar
                mostrarDatosUsuario();
                btnNuevoUsuario.Text = "Nuevo";
                btnModificarUsuario.Text = "Modificar";
                estadoControles(false);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreUsuario.Text.Trim() + "?", "Eliminar Usuario", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] Usuario = {
                    "eliminar", miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String respuesta = objConexion.(Usuario);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                    mostrarDatosUsuario();
                }
            }
        }
    }
}
