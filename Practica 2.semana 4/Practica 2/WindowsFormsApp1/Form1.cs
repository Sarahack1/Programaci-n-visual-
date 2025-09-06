using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Tarea> listaTareas = new List<Tarea>();

        private void ActualizarGrid()
        {
            dgvTareas.DataSource = null;
            dgvTareas.DataSource = listaTareas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigoNuevo = txtCodigo.Text.Trim();

            bool existe = listaTareas.Any(t => t.Codigo.Equals(codigoNuevo, StringComparison.OrdinalIgnoreCase));
            if (existe)
            {
                MessageBox.Show("Ya se ha agregado una tarea con ese código.", "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Tarea nueva = new Tarea()
            {
                Codigo = codigoNuevo,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Fecha = dtpFecha.Value,
                Lugar = txtLugar.Text,
                Estado = cmbEstado.SelectedItem.ToString()
            };

            listaTareas.Add(nueva);
            ActualizarGrid();
            MessageBox.Show("Tarea agregada correctamente.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas[index].Codigo = txtCodigo.Text;
                listaTareas[index].Nombre = txtNombre.Text;
                listaTareas[index].Descripcion = txtDescripcion.Text;
                listaTareas[index].Fecha = dtpFecha.Value;
                listaTareas[index].Lugar = txtLugar.Text;
                listaTareas[index].Estado = cmbEstado.SelectedItem.ToString();

                ActualizarGrid();
                MessageBox.Show("Tarea editada correctamente.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count > 0)
            {
                int index = dgvTareas.SelectedRows[0].Index;
                listaTareas.RemoveAt(index);
                ActualizarGrid();
                MessageBox.Show("Tarea eliminada correctamente.");
            }
        }

        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvTareas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvTareas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvTareas.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpFecha.Value = (DateTime)dgvTareas.Rows[e.RowIndex].Cells[3].Value;
                txtLugar.Text = dgvTareas.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbEstado.SelectedItem = dgvTareas.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool hayCriterio =
                !string.IsNullOrWhiteSpace(txtBuscarCodigo.Text) ||
                cmbBuscarEstado.SelectedItem != null ||
                dtpFechaInicio.Value.Date <= dtpFechaFin.Value.Date;

            if (!hayCriterio)
            {
                MessageBox.Show("Por favor, ingresa al menos un criterio de búsqueda.", "Criterio requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IEnumerable<Tarea> resultado = listaTareas;

            if (!string.IsNullOrWhiteSpace(txtBuscarCodigo.Text))
            {
                string codigo = txtBuscarCodigo.Text.Trim();
                resultado = resultado.Where(t => t.Codigo.IndexOf(codigo, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (cmbBuscarEstado.SelectedItem != null)
            {
                string estado = cmbBuscarEstado.SelectedItem.ToString();
                resultado = resultado.Where(t => t.Estado == estado);
            }

            DateTime inicio = dtpFechaInicio.Value.Date;
            DateTime fin = dtpFechaFin.Value.Date;
            if (inicio <= fin)
            {
                resultado = resultado.Where(t => t.Fecha.Date >= inicio && t.Fecha.Date <= fin);
            }

            dvg_busqueda.DataSource = null;
            dvg_busqueda.DataSource = resultado.ToList();

            if (!resultado.Any())
            {
                MessageBox.Show("No se encontraron tareas con los criterios especificados.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dvg_busqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvTareas.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvTareas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = dgvTareas.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpFecha.Value = (DateTime)dgvTareas.Rows[e.RowIndex].Cells[3].Value;
                txtLugar.Text = dgvTareas.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbEstado.SelectedItem = dgvTareas.Rows[e.RowIndex].Cells[5].Value.ToString();
            }

        }
    }
}
