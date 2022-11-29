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
	/// Логика взаимодействия для Authorization.xaml
	/// </summary>
	public partial class Authorization : Window
	{
		public Authorization()
		{
			InitializeComponent();
		}

		private void ButtonRegistration_Click(object sender, RoutedEventArgs e)
		{
			Registration windowReg = new Registration();
			windowReg.ShowDialog();

		}

		private void btnAuth_Click(object sender, RoutedEventArgs e)
		{		
			string login = textboxAuthLogin.Text.Trim();
			string password = passwordboxAuthPassword.Password.Trim();

			if (login.Length < 5)
			{
				textboxAuthLogin.ToolTip = "Это поле введено некорректно!";
				textboxAuthLogin.Background = Brushes.Red;
			}
			else if (password.Length < 5)
			{
				passwordboxAuthPassword.ToolTip = "Это поле введено некорректно!";
				passwordboxAuthPassword.Background = Brushes.Red;
			}
			else
			{
				textboxAuthLogin.ToolTip = "";
				textboxAuthLogin.Background = Brushes.Transparent;
				passwordboxAuthPassword.ToolTip = "";
				passwordboxAuthPassword.Background = Brushes.Transparent;

				User authUser = null;
				using (AppContext db = new AppContext())
				{
					authUser = db.Users.Where(user => user.Login == login && user.Password == password).FirstOrDefault();
				}

				if (authUser != null)
				{
					MessageBox.Show("Авторизация прошла успешно!");
					Assortiment windowAssort = new Assortiment();
					windowAssort.ShowDialog();
				}
				else
				{
					MessageBox.Show("Неверный логин или пароль!");
				}
			}
		}
	}
}
