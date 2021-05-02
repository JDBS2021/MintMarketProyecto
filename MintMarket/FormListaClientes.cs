using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MintMarket
{
    public partial class FormListaClientes : Form
    {
        public FormListaClientes()
        {
            InitializeComponent();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            InsertarFilas();
        }
        

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormMantCliente frm = new FormMantCliente();
            if (dataGridView1.SelectedRows.Count > 0)
            {               
                frm.txtid.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtapellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtdireccion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.txttelefono.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.textPass.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frm.ShowDialog();
             
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormMantCliente frm = new FormMantCliente();
            frm.ShowDialog();
        }

        private void InsertarFilas()
        {
            dataGridView1.Rows.Insert(0, "1", "Jesus", "Beleño","jbeleno@unicesar.edu.co", "Valledupar", "56465", "*********");

            dataGridView1.Rows.Insert(1, "2", "Jesus", "Beleño", "jbeleno@unicesar.edu.co", "Valledupar", "56465", "*********");
            dataGridView1.Rows.Insert(2, "3", "Jesus", "Beleño", "jbeleno@unicesar.edu.co", "Valledupar", "56465", "*********");
            dataGridView1.Rows.Insert(3, "4", "Jesus", "Beleño", "jbeleno@unicesar.edu.co", "Valledupar", "56465", "*********");
            dataGridView1.Rows.Insert(4, "5", "Jesus", "Beleño", "jbeleno@unicesar.edu.co", "Valledupar", "56465", "*********");

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*FormPagos frm = Owner as FormPagos;
;

            frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtapellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.Close();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
