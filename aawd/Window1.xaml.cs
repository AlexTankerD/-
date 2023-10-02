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
using System.Windows.Shapes;

namespace aawd
{
	/// <summary>
	/// Логика взаимодействия для Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		IgorController controller = new IgorController("https://localhost:7053");
		public Window1()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow();
			mainWindow.Show();
			this.Close();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			var responce = controller.Registration(new ServicAPI.Models.Model.User() { Username=Login.Text, Password=Password.Text});
			MessageBox.Show(responce.Content);
			if (responce.IsSuccessStatusCode) 
			{
				MainWindow wnd = new MainWindow();
				wnd.Show();
				this.Close();
			}

			
		}
	}
}
