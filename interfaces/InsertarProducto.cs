using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using common;

namespace interfaces
{
    public partial class Insertar_Producto : Form
    {
        public Insertar_Producto()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Productos pform = new Productos();
            pform.Show();
            this.Hide();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.nombre = txtNombre.Text;
            p.precio = double.Parse(txtPrecio.Text);
            p.stock = int.Parse(txtStock.Text);
            p.descripcion = txtDescripcion.Text;
        }
    }
}
