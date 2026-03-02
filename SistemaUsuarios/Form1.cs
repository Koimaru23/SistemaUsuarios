using SistemaUsuarios.Data;

namespace SistemaUsuarios
{
    public partial class Form1 : Form

    {
        UsuarioDAO objetoDAO = new UsuarioDAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = objetoDAO.Listar();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //A qui llamamos al DAO para insertar lo que se escribe
            objetoDAO.Insertar(txtNombre.Text, txtApellido.Text, txtUser.Text, txtPass.Text, txtEmail.Text);

            MessageBox.Show("¡Usuario registrado 7w7!");

            //Altualizar la tabla
            dgvUsuarios.DataSource = objetoDAO.Listar();

            //Limpiar
            txtNombre.Clear();
            txtApellido.Clear();
            txtUser.Clear();
            txtPass.Clear();
            txtEmail.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Para no borar por error
            DialogResult respuesta = MessageBox.Show("¿Seguro que quieres borrar este usuario?", "Cuidado", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                int id = int.Parse(dgvUsuarios.CurrentRow.Cells["id"].Value.ToString());
                objetoDAO.Eliminar(id);
                dgvUsuarios.DataSource = objetoDAO.Listar();
                MessageBox.Show("Usuario Eliminado");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Obtener el Id
            int idSeleccionado = int.Parse(dgvUsuarios.CurrentRow.Cells["id"].Value.ToString());

            //Funciona con El Dao 
            objetoDAO.Editar(idSeleccionado, txtNombre.Text, txtApellido.Text, txtUser.Text, txtEmail.Text);

            MessageBox.Show("¡Datos actualizados!");
            dgvUsuarios.DataSource = objetoDAO.Listar();
            LimpiarCampos();

        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtUser.Clear();
            txtPass.Clear();
            txtEmail.Clear();
            txtNombre.Focus(); 
        }
    }
}
