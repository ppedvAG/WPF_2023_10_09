using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace M009
{
	internal class LengthValidation : ValidationRule
	{
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			string s = value as string;
			if (s.Length >= 3 && s.Length <= 20)
			{
				return ValidationResult.ValidResult;
			}
			else
			{
				return new ValidationResult(false, "Die Länge des Texts muss zwischen 3 und 20 Zeichen sein.");
			}
		}
	}
}
