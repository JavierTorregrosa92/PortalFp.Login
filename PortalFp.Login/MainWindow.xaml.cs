using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PortalFp.Login
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void BtnAcceder_Click(object sender, RoutedEventArgs e)
		{
			string usuario = TxtUsuario.Text;
			string contraseña = TxtPassword.Password;

			if (usuario == "" || contraseña == "")
			{
				TxtMensaje.Text = "Debes introducir usuario y contraseña.";
				TxtMensaje.Foreground = Brushes.Red;
			} 
			else if (usuario == "admin" && contraseña == "1234")
			{
				TxtMensaje.Text = "Credenciales correctas. ¡Bienvenido al programa!";
				TxtMensaje.Foreground = Brushes.Green;
			}
			else 
			{
				TxtMensaje.Text = "Credenciales incorrectas.";
				TxtMensaje.Foreground = Brushes.Red;
			}
		}
	}
}