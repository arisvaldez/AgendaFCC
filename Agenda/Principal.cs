using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Principal : Form
    {
        private int id;
        agenda age = new agenda();
        DataTable dt;


        public Principal()
        {
            InitializeComponent();
            RestablecerControles();
            Consultar();
            DgvAgenda.Columns["Id"].Visible = false;
        }

        private void Consultar() 
        {
            dt = age.Consultar();
            DgvAgenda.DataSource = dt;
        }

        private void ObtenerId() 
        {
            id = Convert.ToInt32(DgvAgenda.CurrentRow.Cells["Id"].Value);
        }

        private void ObtenerDatos()
        {
            ObtenerId();
            TxtNombre.Text = DgvAgenda.CurrentRow.Cells["Nombre"].Value.ToString();
            TxtTelefono.Text = DgvAgenda.CurrentRow.Cells["Telefono"].Value.ToString();
        }

        private void RestablecerControles() 
        {
            this.TxtNombre.Clear();
            this.TxtTelefono.Clear();
            this.TxtFiltrar.Clear();
            this.BtnEliminar.Enabled = false;
            this.BtnModificar.Enabled = false;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombre.Text) || string.IsNullOrWhiteSpace(TxtNombre.Text)) 
            {
                return;
            }

            bool rs = age.Insertar(TxtNombre.Text, TxtTelefono.Text);

            if (rs)
            {
                MessageBox.Show("Registrado Correctamente");
                RestablecerControles();
                Consultar();
            }
            else 
            {
                MessageBox.Show("No se ha Registrado Correctamente");
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtNombre.Text) || string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                return;
            }

            bool rs = age.Actualizar(id, TxtNombre.Text, TxtTelefono.Text);

            if (rs)
            {
                MessageBox.Show("Actualizado Correctamente");
                RestablecerControles();
                Consultar();
            }
            else
            {
                MessageBox.Show("No se ha Actualizado Correctamente");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r =
                MessageBox.Show("Eliminar",
                "Estas seguro de deseas eliminar este registro?, no podras deshacer los cambios.",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation
                );

            if (r == DialogResult.OK) 
            {
                bool rs = age.Eliminar(id);
                if (rs)
                {
                    MessageBox.Show("Eliminado Correctamente");
                    RestablecerControles();
                    Consultar();
                }
                else
                {
                    MessageBox.Show("No se ha Eliminado Correctamente");
                }
            }

        }

        private void TxtFiltrar_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = $"Nombre LIKE '%{TxtFiltrar.Text}%' OR Telefono LIKE '%{TxtFiltrar.Text}%'";
            /*if (TxtFiltrar.Text.Length == 0)
                Consultar();
            if (TxtFiltrar.Text.Length < 3)
                return;
           DgvAgenda.DataSource = age.Filtrar(TxtFiltrar.Text);*/
        }

        private void DgvAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RestablecerControles();
            ObtenerId();
            this.BtnEliminar.Enabled = true;
        }

        private void DgvAgenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerDatos();
            this.BtnEliminar.Enabled = false;
            this.BtnModificar.Enabled = true;
        }
    }
    
}
