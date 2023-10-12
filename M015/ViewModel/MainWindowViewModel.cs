using M015.Model;
using System.Collections.ObjectModel;

namespace M015.ViewModel;

public class MainWindowViewModel : ViewModelBase
{
	public ObservableCollection<Person> Personen { get; set; } = new();

	public CustomCommand TestButton { get; set; }

	public CustomCommand CreatePerson { get; set; }

	private string windowTitle;

	public string WindowTitle
	{
		get => windowTitle;
		set
		{
			windowTitle = value;
			Notify(nameof(WindowTitle));
		}
	}

	public MainWindowViewModel()
	{
		WindowTitle = "Titel";
		Personen.Add(new Person() { Id = 0, Name = "Max", Description = "Eine Beschreibung" });
		CreateTestButtonCommand();
		CreateCreatePersonCommand();
	}

	public void CreateTestButtonCommand()
	{
		TestButton = new CustomCommand();
		TestButton.Command = x => App.Current.MainWindow.Close();
		TestButton.CanExe = x => true;
	}

	public void CreateCreatePersonCommand()
	{
		CreatePerson = new CustomCommand();
		CreatePerson.Command = x =>
		{
			Personen.Add(new Person());
			WindowTitle += WindowTitle;
		};
		CreatePerson.CanExe = x => true;
	}
}
