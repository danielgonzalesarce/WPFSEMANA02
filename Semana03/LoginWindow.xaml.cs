using System.Windows;

namespace Semana03
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Password;

            // 1. Validar campos vacíos o incorrectos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                lblMensaje.Text = "Por favor, ingrese usuario y contraseña.";
                return;
            }

            // 2. Validación de credenciales
            if (usuario == "admin" && password == "1234")
            {
                // Correcto: abre el menú principal
                MainWindow menuPrincipal = new MainWindow();
                menuPrincipal.Show();
                this.Close();
            }
            else
            {
                // Incorrecto: muestra mensaje de error
                lblMensaje.Text = "Usuario o contraseña incorrectos.";
            }
        }
    }
}