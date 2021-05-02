using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MintMarket
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            botonMaximizar.Visible = false;
            botonRestaurar.Visible = true;
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void botonRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            botonRestaurar.Visible = false;
            botonMaximizar.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }

        private void btnReporteProducto_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnReportePedido_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnReportePagos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
