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
	/// Логика взаимодействия для Assortiment.xaml
	/// </summary>
	public partial class Assortiment : Window
	{
		public Assortiment()
		{
			InitializeComponent();
		}

		private void btnAssortClose_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
