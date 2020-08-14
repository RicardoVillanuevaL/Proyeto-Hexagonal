using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace interfaces
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
            Insertar_Producto ip = new Insertar_Producto();
            ip.Show();
            this.Hide();

        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }
    }
}
