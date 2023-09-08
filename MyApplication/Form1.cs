using MyApplication.Entidades;

using Newtonsoft.Json;
using Techsoft.MyApplication.Aplicacion.Servicios;
using MyApplication.Repositorio;
using MyApplication.Contratos;

namespace MyApplication
{
    public partial class Form1 : Form
    {


        //private readonly DBOptions DbOptions;

        private readonly ClienteService _clienteService;

        public Form1()
        {
            InitializeComponent();

            //DbOptions = Configuracion.Instancia(DBOptions.SQLServer).DbOption;

            //_clienteService = new ClienteService();

        }

        private void LimpiarControles()
        {
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtEdad.Text = String.Empty;

        }


        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                _clienteService.Guardar(txtNombre.Text, txtApellido.Text, txtTelefono.Text,
                                       txtDireccion.Text, int.Parse(txtEdad.Text));


                //var cliente = new Cliente(
                //       txtNombre.Text, txtApellido.Text, txtTelefono.Text,
                //       txtDireccion.Text, int.Parse(txtEdad.Text));

                //RepositorioFabrik
                //    .CrearRepositorio(DbOptions)
                //    .Guardar<Cliente>(cliente);

                LimpiarControles();

                MessageBox.Show("Cliente Guardado con éxito.");
            }

            catch (ArgumentException ar)
            {
                MessageBox.Show($"Datos Inválidos: {ar.Message}");
            }
            catch (InvalidOperationException ar)
            {
                MessageBox.Show($"Operación Inválida: {ar.Message}");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al guardar.");
            }



        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            btnGuardar.Enabled = false;

            var clienteId = Guid.Parse(txtId.Text);

            try
            {
                IRepositorio<Cliente> repo = new ClientesRepository();
                var result = await repo.ConsultarPorId(clienteId);
                
                txtNombre.Text = result.Nombre;
                txtApellido.Text = result.Apellido;
                txtTelefono.Text = result.Telefono;
                txtDireccion.Text = result.Direccion;
                txtEdad.Text = result.Edad.ToString();
               
            } catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnBuscar.Enabled = true;
                btnGuardar.Enabled = true;
            }

        }
    }
}