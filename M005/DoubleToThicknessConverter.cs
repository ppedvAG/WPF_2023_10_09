using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace M005
{
	class DoubleToThicknessConverter : IValueConverter
	{
		//Source -> Target
		//Slider -> Button (möglich)
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			//Der value Parameter enthält den Wert der beim Binding gesendet wird
			double sliderValue = (double) value;
			return new Thickness(sliderValue);
		}

		//Target -> Source
		//Button -> Slider (nicht möglich)
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
