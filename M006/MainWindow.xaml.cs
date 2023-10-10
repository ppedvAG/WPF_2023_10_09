using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace M006;

public partial class MainWindow : Window
{
	//public int Zahl { get; set; } = 5;

	//Binding über DependencyProperty
	//Generell im statischen Code (UI)
	//INotifyPropertyChanged wird generell in Datenklassen verwendet
	public int Zahl
	{
		get { return (int) GetValue(ZahlProperty); }
		set { SetValue(ZahlProperty, value); }
	}

	public static readonly DependencyProperty ZahlProperty =
		DependencyProperty.Register(
			"Zahl", //Name des Properties in der UI
			typeof(int), //Den Typen des Properties
			typeof(MainWindow), //Der Typ der beinhaltenden Klasse
			new PropertyMetadata(5)); //Parameter

	public Person TestPerson { get; set; } = new Person() { ID = 0, Name = "Max", Description = "Eine Person" };

	//ObservableCollection
	//Implementiert das Interface und kann dadurch direkt an die UI angebunden werden
	public ObservableCollection<int> Zahlen { get; set; } = new();

	public BindableProperty<int> Nummer { get; set; } = new() { Value = 5 };

	public MainWindow()
	{
		InitializeComponent();
		//DataContext = this; //Hier den DataContext auf das Window selbst setzen (-> Suche alle Properties im Window selbst)
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Zahl++;
		TestPerson.ID++;
		Zahlen.Add(Random.Shared.Next());
		Nummer.Value++;
	}
}
