using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace M009
{
	internal class LetterValidation : ValidationRule
	{
		/// <summary>
		/// Der Value ist hier der vom User eingegebene Wert
		/// Diese Methode wird ausgeführt wenn das Binding ausgeführt wird (Standard: LostFocus)
		/// </summary>
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			if ((value as string).All(char.IsLetter))
				return ValidationResult.ValidResult;
			else
				return new ValidationResult(false, "Der eingegebene Text darf nur aus Zeichen bestehen");
		}

		public override string ToString()
		{
			return "Der eingegebene Text darf nur aus Zeichen bestehen";
		}
	}
}
