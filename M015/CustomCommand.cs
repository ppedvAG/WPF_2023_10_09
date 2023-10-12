using System;
using System.Windows.Input;

namespace M015;

public class CustomCommand : ICommand
{
	private Action<object> command;

	public Action<object> Command
	{
		get => command;
		set => command = value;
	}

	private Func<object, bool> canExe;

	public Func<object, bool> CanExe
	{
		get => canExe;
		set => canExe = value;
	}

	public event EventHandler? CanExecuteChanged
	{
		add { CommandManager.RequerySuggested += value; }
		remove { CommandManager.RequerySuggested -= value; }
	}

    public CustomCommand() { }

    public CustomCommand(Action<object> command, Func<object, bool> canExe)
	{
		this.command = command;
		this.canExe = canExe;
	}

	public bool CanExecute(object? parameter) => canExe(parameter);

	public void Execute(object? parameter) => command(parameter);
}
