using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MintMarket
{
    public partial class FormListaProductos : Form
    {
        public FormListaProductos()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormMantProducto frm = new FormMantProducto();
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormMantProducto frm = new FormMantProducto();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.textNombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.textPrecio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.textCosto.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.textDescuento.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frm.textCantidad.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frm.textDescripcion.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                frm.ShowDialog();

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
