using System;
using System.Windows.Input;

namespace M014;

public class CustomCommand : ICommand
{
	private Action<object> command;

	private Func<object, bool> canExe;

	public event EventHandler? CanExecuteChanged
	{
		add { CommandManager.RequerySuggested += value; }
		remove { CommandManager.RequerySuggested -= value; }
	}

	public CustomCommand(Action<object> command, Func<object, bool> canExe)
	{
		this.command = command;
		this.canExe = canExe;
	}

	public bool CanExecute(object? parameter) => canExe(parameter);

	public void Execute(object? parameter) => command(parameter);
}
