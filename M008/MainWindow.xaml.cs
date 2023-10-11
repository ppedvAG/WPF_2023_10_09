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

namespace M008
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			LB.ItemsSource = new List<string>() { "L1", "L2", "L3" };
			CB.ItemsSource = new List<Person>()
			{
				new Person(){ Id = 0, Name = "Max", Description = "Person1" },
				new Person(){ Id = 1, Name = "Max2", Description = "Person2" },
				new Person(){ Id = 2, Name = "Max3", Description = "Person3" }
			};

			PersonLB.ItemsSource = CB.ItemsSource;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
	}
}
