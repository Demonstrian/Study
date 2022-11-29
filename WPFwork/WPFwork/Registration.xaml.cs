using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFwork
{
	/// <summary>
	/// Логика взаимодействия для Registration.xaml
	/// </summary>
	public partial class Registration : Window
	{

		AppContext db;

		public Registration()
		{
			InitializeComponent();

			db = new AppContext();
		}

		private void buttonRegistrationReg_Click(object sender, RoutedEventArgs e)
		{
			string login = textboxRegLogin.Text.Trim();
			string password = passwordboxRegPassword.Password.Trim();

			if (login.Length < 5)
			{
				textboxRegLogin.ToolTip = "Это поле введено некорректно!";
				textboxRegLogin.Background = Brushes.Red;
			}
			else if (password.Length < 5)
			{
				passwordboxRegPassword.ToolTip = "Это поле введено некорректно!";
				passwordboxRegPassword.Background = Brushes.Red;
			}
			else
			{
				textboxRegLogin.ToolTip = "";
				textboxRegLogin.Background = Brushes.Transparent;
				passwordboxRegPassword.ToolTip = "";
				passwordboxRegPassword.Background = Brushes.Transparent;

				MessageBox.Show("Регистрация прошла успешно!");

				User user = new User(login, password);

				db.Users.Add(user);
				db.SaveChanges();
			}
		}

		private void buttonCloseReg_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
