using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace M006
{
	internal class CollectionToStringConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			IEnumerable<object> values = (IEnumerable<object>) value;
			StringBuilder sb = new StringBuilder();
			sb.Append("[");
			foreach (object item in values)
				sb.Append(item + ", ");
			sb.Append("]");
			return sb.ToString();
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
