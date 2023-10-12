using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace M014;

/// <summary>
/// ICommand: Interface, welches die Basis der Commands bildet
/// Gibt Execute und CanExecute vor
/// CanExecuteChanged: Beim CommandManager registrieren
/// </summary>
public class DeleteCommand : ICommand
{
	public event EventHandler? CanExecuteChanged
	{
		add { CommandManager.RequerySuggested += value; }
		remove { CommandManager.RequerySuggested -= value; }
	}

	public bool CanExecute(object? parameter)
	{
		string str = parameter as string;
		return !string.IsNullOrEmpty(str);
	}

	public void Execute(object? parameter)
	{
		parameter = "";
	}
}
