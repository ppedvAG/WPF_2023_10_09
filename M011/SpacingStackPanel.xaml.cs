using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

namespace M011
{
	[ContentProperty("Items")]
	public partial class SpacingStackPanel : UserControl
	{
		public static readonly DependencyProperty ItemsSourceProperty =
			ItemsControl.ItemsSourceProperty.AddOwner(typeof(SpacingStackPanel));
		
		public IEnumerable ItemsSource
		{
			get => (IEnumerable) GetValue(ItemsSourceProperty);
			set => SetValue(ItemsSourceProperty, value);
		}

		//public ItemCollection Items => UIItems.Items;

		public int Spacing
		{
			get => (int) GetValue(SpaceProperty);
			set => SetValue(SpaceProperty, value);
		}

		public static readonly DependencyProperty SpaceProperty =
			DependencyProperty.Register("Space", typeof(int), typeof(SpacingStackPanel), new PropertyMetadata(0));

		public SpacingStackPanel()
		{
			InitializeComponent();
		}

		protected override void OnRender(DrawingContext drawingContext)
		{
			base.OnRender(drawingContext);
		}
	}
}
