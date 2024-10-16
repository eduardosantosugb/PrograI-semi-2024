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
    public partial class docentes : Form
    {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        String accion = "nuevo";
        public docentes()
        {
            InitializeComponent();
        }

        private void grbDatosDocente_Enter(object sender, EventArgs e)
        {

        }

        private void docentes_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            miTabla = ds.Tables["docentes"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["IdDocente"] };
            grdDatosDocente.DataSource = miTabla;
            mostrarDatosDocente();
        }

        private void mostrarDatosDocente()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtCodigoDocente.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtNombreDocente.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtDireccionDocente.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtTelefonoDocente.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                txtDuiDocente.Text = miTabla.Rows[posicion].ItemArray[5].ToString();
                txtGmailDocente.Text = miTabla.Rows[posicion].ItemArray[6].ToString();
                CboxEspecialidadesDocente.Text = miTabla.Rows[posicion].ItemArray[7].ToString();

                lblRegistrosDocente.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
        }

        private void btnSiguienteDocente_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosDocente();
            }
            else
            {
                MessageBox.Show("Esta en el ultimo registro", "Navegacion de docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorDocente_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosDocente();
            }
            else
            {
                MessageBox.Show("Esta en el primer registro", "Navegacion de alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoDocente_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosDocente();
        }

        private void btnPrimeroDocente_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosDocente();
        }

        private void estadoControles(Boolean estado)
        {
            grbDatosDocente.Enabled = estado;
            grbNavegacionDocente.Enabled = !estado;
            btnEliminarDocente.Enabled = !estado;
        }

        private void btnNuevoDocente_Click(object sender, EventArgs e)
        {
            if (btnNuevoDocente.Text == "Nuevo")
            {
                btnNuevoDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                accion = "nuevo";
                estadoControles(true);
                limpiarCajas();
            }
            else
            {//Guardar
                String[] docentes = {
                    accion, miTabla.Rows[posicion].ItemArray[0].ToString(),
                    txtCodigoDocente.Text, txtNombreDocente.Text, txtDireccionDocente.Text, txtTelefonoDocente.Text, txtDuiDocente.Text, txtGmailDocente.Text, CboxEspecialidadesDocente.Text
                };
                String respuesta = objConexion.administrarDocentes(docentes);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de docentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnNuevoDocente.Text = "Nuevo";
                    btnModificarDocente.Text = "Modificar";
                    estadoControles(false);
                    actualizarDs();
                }
            }
        }

        void limpiarCajas()
        {
            txtCodigoDocente.Text = "";
            txtNombreDocente.Text = "";
            txtDireccionDocente.Text = "";
            txtTelefonoDocente.Text = "";
            txtDuiDocente.Text = "";
            txtGmailDocente.Text = "";
            CboxEspecialidadesDocente.Text = "";
        }

        private void btnModificarDocente_Click(object sender, EventArgs e)
        {
            if (btnModificarDocente.Text == "Modificar")
            {
                btnNuevoDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                accion = "modificar";
                estadoControles(true);

            }
            else
            {//Cancelar
                mostrarDatosDocente();
                btnNuevoDocente.Text = "Nuevo";
                btnModificarDocente.Text = "Modificar";
                estadoControles(false);
            }
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreDocente.Text.Trim() + "?", "Eliminar docentes", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] docentes = {
                    "eliminar", miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String respuesta = objConexion.administrarDocentes(docentes);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de docentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                    mostrarDatosDocente();
                }
            }
        }

        private void filtrarDatos(String filtro)
        {
            DataView dv = miTabla.DefaultView;
            dv.RowFilter = "codigo like '%" + filtro + "%' OR nombre like '%" + filtro + "%'";
            grdDatosDocente.DataSource = dv;
        }

        private void txtBuscarDocente_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarDocente.Text);
            //if (e.KeyValue == 13) {//tecla enter
            seleccionarAlDocente();
            //}
        }

        private void grdDatosDocente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarAlDocente();
        }

        private void txtBuscarDocente_KeyUp_1(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarDocente.Text);
            //if (e.KeyValue == 13) {//tecla enter
            seleccionarAlDocente();
            //}
        }

        private void seleccionarAlDocente()
        {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosDocente.CurrentRow.Cells["IdDocente"].Value.ToString()));
            mostrarDatosDocente();
        }

        private void grdDatosDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarAlDocente();
        }

        private void txtBuscarDocente_TextChanged(object sender, EventArgs e)
        {
            
                string nombre = txtBuscarDocente.Text;
                BuscarNombre(nombre);
            }

            private void BuscarNombre(string nombre)
            {
                DataView dv = miTabla.DefaultView;
                dv.RowFilter = "nombre like '%" + nombre + "%'";
                if (dv.Count == 0)
                {
                    MessageBox.Show("No se encontró el nombre. Intente de nuevo.", "Error");
                }
            }
        }
    }

