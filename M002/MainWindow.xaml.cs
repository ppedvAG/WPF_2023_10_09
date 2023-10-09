using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace M002
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			//Liste von Personen einbinden (z.B. Datenbank)
			//List<string> personen = new List<string>();
			//personen.Add("P1");
			//personen.Add("P2");
			//personen.Add("P3");
			//Dropdown.Items.Clear();
			//Dropdown.ItemsSource = personen;

			DayOfWeek[] days = Enum.GetValues<DayOfWeek>();
			Dropdown.Items.Clear();
			Dropdown.ItemsSource = days;
		}

		private void ButtonTestClicked(object sender, RoutedEventArgs e)
		{
			Info.Text = "Ein Text vom Button";
		}

		private void InputEnterPressed(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				Info.Text = Input.Text;
			}
		}

		private void CheckBox_Checked(object sender, RoutedEventArgs e)
		{
			if(IsInitialized) //Event wird bei setzen des Standardwerts im XAML gefeuert, durch IsInitialized prüfen, ob das Programm bereits vollständig geladen ist
				Info.Text = "CheckBox checked";
		}

		private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
		{
			if (IsInitialized)
				Info.Text = "CheckBox unchecked";
		}

		private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
		{
			Info.Text = e.NewValue.ToString();
		}

		private void BeendenClicked(object sender, RoutedEventArgs e)
		{
			//Bei Result aufpassen welche Buttons verwendet wurden (OK != Yes, Cancel != No)
			MessageBoxResult result = MessageBox.Show("Möchtest du wirklich beenden?", "Beenden?", MessageBoxButton.YesNo, MessageBoxImage.Question);
			if (result == MessageBoxResult.Yes)
			{
				Close();
			}
		}
	}
}
