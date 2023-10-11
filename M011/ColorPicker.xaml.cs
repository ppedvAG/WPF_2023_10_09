using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace M011;

public partial class ColorPicker : UserControl
{
	public Color PickedColor
	{
		get { return (Color) GetValue(PickedColorProperty); }
		set { SetValue(PickedColorProperty, value); }
	}

	/// <summary>
	/// Über ein DependencyProperty können bei UserControls eigene Properties weitergegeben werden
	/// </summary>
	public static readonly DependencyProperty PickedColorProperty =
		DependencyProperty.Register(
			"PickedColor", //Name des Felds
			typeof(Color), //Typ des Felds
			typeof(ColorPicker), //Typ des Besitzers
			new PropertyMetadata(Colors.Transparent)); //Standardwert

	public ColorPicker()
	{
		InitializeComponent();

		Binding binding = new("Fill.Color")
		{
			Source = Rect,
			Mode = BindingMode.OneWay
		};
		BindingOperations.SetBinding(this, PickedColorProperty, binding);
	}
}
