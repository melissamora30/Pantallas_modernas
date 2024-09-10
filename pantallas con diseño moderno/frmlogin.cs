namespace pantallas_con_diseño_moderno
{

    public partial class frmlogin : Form
    {

        public frmlogin()
        {
            InitializeComponent();
        }


        string usuario = "admin";
        string contraseña = "123";
        string respuesta = "Melissa Mora";



        public void validador(object sender, EventArgs e)
        {
            if (usuario == TxtUsuario.Text && contraseña == TxtContraseña.Text)
            {
                MessageBox.Show(" Inicio de sesión exitoso" + respuesta);
                this.Hide(); //Ocultar este formulario
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.Show(); // Mostrar nuevo formulario principal

                frmPrincipal.StartPosition = FormStartPosition.Manual; // Configuramos que la posición será manual
                frmPrincipal.Location = new Point(
                    this.Location.X + (this.Width - frmPrincipal.Width) / 2,
                    this.Location.Y + (this.Height - frmPrincipal.Height) / 2);
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
            }
            TxtUsuario.Clear();
            TxtContraseña.Clear();

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            validador(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //cierra la aplicación
        }

        private void btnprobar_Click(object sender, EventArgs e)
        {
            validador(sender, e);

        }
    }

}


//public void loginpanel_Paint(object sender, PaintEventArgs e)
//{

//}

//private void LblUsuario_Click(object sender, EventArgs e)
//{

//}


