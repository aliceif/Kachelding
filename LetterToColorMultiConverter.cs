using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

using Windows.Graphics.Printing;

namespace Kachelding
{
	public class LetterToColorMultiWiringConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			if (values.Length != 6) throw new ArgumentException("wrong parameters!", nameof(values));
			if (values is not [string letter, string colorA, string colorB, string colorC, string colorD, string wiring]) throw new ArgumentException("Wrong parameter type", nameof(values));

			return GetRewiredLetter(letter, wiring) switch
			{
				"A" or "a" => new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorA)),
				"B" or "b" => new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorB)),
				"C" or "c" => new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorC)),
				"D" or "d" => new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorD)),
				_ => Brushes.Black,
			};
		}

		private string GetRewiredLetter(string letter, string wiring) => letter switch
		{
			"A" or "a" => wiring[0].ToString(),
			"B" or "b" => wiring[1].ToString(),
			"C" or "c" => wiring[2].ToString(),
			"D" or "d" => wiring[3].ToString(),
			_ => letter,
		};

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
