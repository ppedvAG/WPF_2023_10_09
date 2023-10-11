using System.Collections.Generic;
using System.Windows;

namespace M010;

public partial class MainWindow : Window
{
	public List<string> Personen { get; set; }

	public bool PersonenNichtLeer => CB.HasItems;

	public MainWindow()
	{
		InitializeComponent();
		CB.ItemsSource = Personen;
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		CB.Items.Add("123");
	}
}
