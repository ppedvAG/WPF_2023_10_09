using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace M012
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public ObservableCollection<Person> people { get; set; } = new ObservableCollection<Person>();

		public MainWindow()
		{
			InitializeComponent();
			people.Add(new Person() { Id = 0, Name = "Max", Description = "Person1" });
			people.Add(new Person() { Id = 1, Name = "Max2", Description = "Person2" });
			people.Add(new Person() { Id = 2, Name = "Max3", Description = "Person3" });
		}
	}
}
