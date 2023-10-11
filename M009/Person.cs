using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M009
{
	internal class Person : IDataErrorInfo
	{
		public int ID { get; set; }

		private string name;

		public string Name
		{
			get => name;
			set
			{
				if (value.All(char.IsLetter))
					name = value;
			}
		}

		public string this[string columnName]
		{
			get
			{
				switch(columnName)
				{
					case nameof(ID):
						return ID.ToString();
					case nameof(Name):
						return name;
				}
				return null;
			}
		}

		public string Error => "Ein Wert ist Fehlerhaft";
	}
}
