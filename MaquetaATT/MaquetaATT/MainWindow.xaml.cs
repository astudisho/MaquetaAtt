using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Controls;



namespace MaquetaATT
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private const string HINT_USUARIO = "Usuario";
		private const string HINT_PASSWORD = "Password";

		public MainWindow()
		{
			InitializeComponent();

			inicializaObjetos();
		}

		public void inicializaObjetos()
		{
			txtUsuario.Text = HINT_USUARIO;
			txtPassword.Text = HINT_PASSWORD;
		}

		private void txtUsuario_GotFocus(object sender, RoutedEventArgs e)
		{
			if (txtUsuario.Text == HINT_USUARIO) { txtUsuario.Clear(); }
		}

		private void txtUsuario_LostFocus(object sender, RoutedEventArgs e)
		{
			if (txtUsuario.Text == "") { txtUsuario.Text = HINT_USUARIO; }
		}

		private void txtPassword_GotFocus(object sender, RoutedEventArgs e)
		{
			if (txtPassword.Text == HINT_PASSWORD) { txtPassword.Clear(); }
		}

		private void txtPassword_LostFocus(object sender, RoutedEventArgs e)
		{
			if (txtPassword.Text == "") { txtPassword.Text = HINT_PASSWORD; }
		}

		private void imgLogo_Loaded(object sender, RoutedEventArgs e)
		{
			/*
			BitmapImage bmiLogo = new BitmapImage();
			bmiLogo.BeginInit();
			//bmiLogo.UriSource = new System.Uri("attLogo.png",new System.Uri(".\\"));
			bmiLogo.EndInit();

			var image = sender as Image;

			image.Source = bmiLogo;
			*/
		}

		private void btnLogin_Click(object sender, RoutedEventArgs e)
		{
			Hide();
			new WpfCaptura().ShowDialog();
			Show();
		}
	}
}
