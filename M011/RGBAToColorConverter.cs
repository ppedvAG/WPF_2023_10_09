using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace M011;

public class RGBAToColorConverter : IMultiValueConverter
{
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		Color col = Color.FromArgb(
				(byte) (double) values[0],
				(byte) (double) values[1],
				(byte) (double) values[2],
				(byte) (double) values[3]);
		return new SolidColorBrush(col);
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}
