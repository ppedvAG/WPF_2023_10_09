using System.ComponentModel;

namespace M015.ViewModel;

public class ViewModelBase : INotifyPropertyChanged
{
	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
