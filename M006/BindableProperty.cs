using System.ComponentModel;

namespace M006;

public class BindableProperty<T> : INotifyPropertyChanged
{
	public event PropertyChangedEventHandler? PropertyChanged;

	private T val;

	public T Value
	{
		get => val;
		set
		{
			val = value;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
		}
	}
}
