using System.ComponentModel;

namespace M006;

public class Person : INotifyPropertyChanged
{
	//Dieses Event wird von der UI selbstständig angehängt
	//Wir hängen hier selbst keine Methode an
	public event PropertyChangedEventHandler? PropertyChanged;

	private int id;

	public int ID
	{
		get => id;
		set
		{
			id = value;
			//Benachrichtigungslogik für ein Property
			//Ruft das Event auf (welches von der UI selbst angebunden wurde) und übergibt den Namen des Properties (nameof(...))
			//nameof: Gibt eine Stringrepräsentation von dem gegebenen Namen zurück
			Notify(nameof(ID));
		}
	}

	private string name;

	public string Name
	{
		get => name;
		set
		{
			name = value;
			Notify(nameof(Name));
		}
	}

	private string description;

	public string Description
	{
		get => description;
		set
		{
			description = value;
			Notify(nameof(Description));
		}
	}

	private void Notify(string name)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}
