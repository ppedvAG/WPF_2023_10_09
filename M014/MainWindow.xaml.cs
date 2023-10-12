using System;
using System.Collections.Generic;
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

namespace M014;

public partial class MainWindow : Window
{
	public DeleteCommand Delete { get; set; } = new DeleteCommand();

	public CustomCommand CloseCommand { get; set; } = new CustomCommand(x => App.Current.MainWindow.Close(), x => true);

	public MainWindow Self => this;

	public MainWindow()
	{
		InitializeComponent();
	}
}
