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

namespace M013;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	public IPage CurrentPage
	{
		get { return (IPage) GetValue(CurrentPageProperty); }
		set { SetValue(CurrentPageProperty, value); }
	}

	public static readonly DependencyProperty CurrentPageProperty =
		DependencyProperty.Register("CurrentPage", typeof(IPage), typeof(MainWindow));

	public MainWindow() => InitializeComponent();

	private void Navigate(object sender, RoutedEventArgs e)
	{
		Button b = (Button) sender;
		Type pageType = b.Tag as Type;
		if (pageType.GetInterface(nameof(IPage)) != null)
		{
			IPage page = Activator.CreateInstance(pageType) as IPage;
			CurrentPage = page;
		}
	}
}
