using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalZoo
{
    public partial class Inicio : Form
    {


        public Inicio()
        {
            InitializeComponent();
        }

        private void btnRegAnimales_Click(object sender, EventArgs e)
        {
            RegistroAnimales x = new RegistroAnimales();
            x.Show();
            Hide();

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnAnimalesEnf_Click(object sender, EventArgs e)
        {
            AnimalesEnfermeria x = new AnimalesEnfermeria();
            x.Show();
            Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
