namespace Academia
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // la propiedad Text de los TextBox contiene el texto escrito en ellos
            if (this.txtUsuario.Text == "Admin" && this.txtPass.Text == "admin")
            {
                // MessageBox.Show("Usted ha ingresado al sistema correctamente.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // generé un messagebox con un mensaje, titulo, botones (en este caso el boton Aceptar), Ícono
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lnkOlvidaPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
