using aawd.Controllers;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace aawd
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		IgorController controller = new IgorController("https://localhost:7053");
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Window1 window1 = new Window1();
			window1.Show();
			this.Close();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			var response = controller.Authorization(new ServicAPI.Models.Model.User() { Password = Password.Text, Username = Login.Text });
			MessageBox.Show(response.Content);
			if (response.IsSuccessStatusCode)
			{
				MainWindow wnd = new MainWindow();
				wnd.Show();
				this.Close();
			}
		}
	}
}
