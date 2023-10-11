using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace M009;

public class ValidatorExtension : MarkupExtension
{
	public Binding Binding { get; set; }

	public ValidatorExtension(Binding b, ValidationRuleCollection coll)
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

public class ValidationRuleCollection : Collection<ValidationRule> { }
