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

namespace M004
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

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Info.Text += "Button Clicked\n";
			e.Handled = true; //Hier Kette der Events beenden
		}

		private void Window_Click(object sender, RoutedEventArgs e)
		{
			Info.Text += "Window Clicked\n";
		}

		private void StackPanel_Click(object sender, RoutedEventArgs e)
		{
			Info.Text += "StackPanel Clicked\n";
		}

		private void Window_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Info.Text += "Window Mouse Down\n";
		}

		private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Info.Text += "StackPanel Mouse Down\n";
			e.Handled = true; //Hier wird das Button Event abgefangen, weil StackPanel über dem Button ist
		}

		private void Info_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Info.Text += "Info Mouse Down\n";
		}
	}
}
