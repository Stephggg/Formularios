using System;
using System.Windows.Forms;

namespace TallerMecanico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Llenar el ComboBox con opciones para tipo de reparación
            cmbTipoReparacion.Items.Add("Cambio de aceite");
            cmbTipoReparacion.Items.Add("Revisión general");
            cmbTipoReparacion.Items.Add("Cambio de frenos");
            cmbTipoReparacion.Items.Add("Reparación de motor");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar los campos ingresados
            if (string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                string.IsNullOrWhiteSpace(txtAno.Text) ||
                string.IsNullOrWhiteSpace(txtMatricula.Text) ||
                string.IsNullOrWhiteSpace(txtNombreDueno.Text) ||
                string.IsNullOrWhiteSpace(txtCedula.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                cmbTipoReparacion.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Lógica para manejar el registro de autos
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string ano = txtAno.Text;
            string matricula = txtMatricula.Text;
            string tipoReparacion = cmbTipoReparacion.SelectedItem.ToString();
            bool seguro = chkSeguro.Checked;
            string nombreDueno = txtNombreDueno.Text;
            string cedula = txtCedula.Text;
            string telefono = txtTelefono.Text;
            DateTime fechaRegistro = dtpFechaRegistro.Value;

            // Aquí puedes agregar el código para guardar estos datos
            MessageBox.Show("Registro exitoso!");
            // Limpiar los campos después del registro
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación o realizar otra acción
            txtMarca.Clear();
            txtModelo.Clear();
            txtAno.Clear();
            txtMatricula.Clear();
            txtNombreDueno.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            cmbTipoReparacion.SelectedIndex = -1;
            chkSeguro.Checked = false;
            dtpFechaRegistro.Value = DateTime.Now;
        }

        private void LimpiarCampos()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtAno.Clear();
            txtMatricula.Clear();
            txtNombreDueno.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            cmbTipoReparacion.SelectedIndex = -1;
            chkSeguro.Checked = false;
            dtpFechaRegistro.Value = DateTime.Now;
        }

        private void labelEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


