using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using finalZoo.Enfermeria;
using finalZoo.Animales;
using finalZoo.Control;

namespace finalZoo
{
    public partial class RegistroAnimales : Form
    {
        public RegistroAnimales()
        {
            InitializeComponent();
        }

        
        private void RegistroAnimales_Load(object sender, EventArgs e)
        {
            System.Collections.Generic.List<Enfermeria.EnviarEnfermeria>
            enviarEnfermeria = new List<Enfermeria.EnviarEnfermeria>();

            enviarEnfermeria.Add(new Enfermeria.EnviarEnfermeria() { Id = 0, Nombre = " " });
            enviarEnfermeria.Add(new Enfermeria.EnviarEnfermeria() { Id = 1, Nombre = "NO" });
            enviarEnfermeria.Add(new Enfermeria.EnviarEnfermeria() { Id = 2, Nombre = "SI" });

            cbxEnviarEnfermeria.DataSource = enviarEnfermeria;
            cbxEnviarEnfermeria.DisplayMember = "Nombre";

            ////////////////////////////////////////////////////////////////////////////////////////////

            System.Collections.Generic.List<Animales.Clasificacion>
            clasi = new List<Animales.Clasificacion>();

            clasi.Add(new Animales.Clasificacion() { Id = 0, Nombre = " " });
            clasi.Add(new Animales.Clasificacion() { Id = 1, Nombre = "MAMIFERO" });
            clasi.Add(new Animales.Clasificacion() { Id = 2, Nombre = "ACUATICO" });
            clasi.Add(new Animales.Clasificacion() { Id = 3, Nombre = "AVE" });

            cbxClasificacion.DataSource = clasi;
            cbxClasificacion.DisplayMember = "Nombre";

            ///////////////////////////////////////////////////////////////////////////////////////////////

           if (((EnviarEnfermeria)cbxEnviarEnfermeria.SelectedItem).Id == 2) 
           {
               txtDiagnostico.Enabled = true;
               txtDiagnostico.Enabled = true;
               dttFechaIngreso.Enabled = true;
               lblFechaIngreso.Enabled = true;
           }
           else
                if (((EnviarEnfermeria)cbxEnviarEnfermeria.SelectedItem).Id == 1) 
                {
                    txtDiagnostico.Enabled = false;
                    txtDiagnostico.Enabled = false;
                    dttFechaIngreso.Enabled = false;
                    lblFechaIngreso.Enabled = false;
                }
            
        }

       
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool errores = false;

            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                errorMensaje.SetError(txtNombre,"Invalido" );
                MessageBox.Show("El nombre es obligatorio");
                return;
            }

            if (string.IsNullOrEmpty(txtEdad.Text))
            {
                errorMensaje.SetError(txtEdad, "Invalido");
                MessageBox.Show("La Edad es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtPaisOrigen.Text))
            {
                errorMensaje.SetError(txtPaisOrigen, "Invalido");
                MessageBox.Show("El Pais origen es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtEspecie.Text))
            {
                errorMensaje.SetError(txtEspecie, "Invalido");
                MessageBox.Show("La especie es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(txtSubespecie.Text))
            {
                errorMensaje.SetError(txtSubespecie, "Invalido");
                MessageBox.Show("Falta subespecie");
                return;
            }
            if (string.IsNullOrEmpty(txtCostumbres.Text))
            {
                errorMensaje.SetError(txtCostumbres, "Invalido");
                MessageBox.Show("Falta costumbres");
                return;
            }

            Animales.Nombre x = new Animales.Nombre();
           // Animales.EnviarEnfermeria y = new Animales.EnviarEnfermeria();
            x.nombre = txtNombre.Text;
            x.Especie = txtEspecie.Text;
            x.EdadEnAños = Convert.ToInt16(txtEdad.Text);
            x.SubEspecie = txtSubespecie.Text;
            x.CostumbresAlimenticias = txtCostumbres.Text;
            x.Diagnostico = txtDiagnostico.Text;
            x.FechaIngreso = dttFechaIngreso.Value;
            x.IdClasificación = (cbxClasificacion.SelectedItem as Clasificacion).Id;
            x.IdEnviarEnfermeria = (cbxEnviarEnfermeria.SelectedItem as EnviarEnfermeria).Id;

            //x. = (cboTipoDocumento.SelectedItem as TipoDocumento).Id;

            ControlAnimal.IngresarAnimal(x);

            MessageBox.Show("Paciente ingresado exitosamente");



        }







        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Inicio x = new Inicio();
            x.Show();
            Hide();
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtEspecie.Text = "";
            txtPaisOrigen.Text = "";
            txtSubespecie.Text = "";
            txtCostumbres.Text = "";
            txtDiagnostico.Text = "";
            cbxEnviarEnfermeria.SelectedIndex = 1;



        }

        private void RegistroAnimales_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void cbxEnviarEnfermeria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((EnviarEnfermeria)cbxEnviarEnfermeria.SelectedItem).Id == 2)
            {
                txtDiagnostico.Enabled = true;
                txtDiagnostico.Enabled = true;
                dttFechaIngreso.Enabled = true;
                lblFechaIngreso.Enabled = true;
            }
            else
                if (((EnviarEnfermeria)cbxEnviarEnfermeria.SelectedItem).Id == 1)
                {
                    txtDiagnostico.Enabled = false;
                    txtDiagnostico.Enabled = false;
                    dttFechaIngreso.Enabled = false;
                    lblFechaIngreso.Enabled = false;
                }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
                AnimalesEnfermeria form = new AnimalesEnfermeria();
                form.ShowDialog();
                
            
        }
    }
} 
