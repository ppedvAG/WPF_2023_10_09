using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

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
	}

	public class LetterMarkupValidation : MarkupExtension
	{
		public Binding Binding { get; set; }

		public LetterMarkupValidation(Binding b, ValidationRuleCollection coll)
		{
			Binding = b;

			foreach (ValidationRule rule in coll)
				b.ValidationRules.Add(rule);
		}

		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			return Binding.ProvideValue(serviceProvider);
		}
	}

	public class ValidationRuleCollection : List<ValidationRule> { }
}
