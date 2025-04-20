using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Kachelding
{
	[ValueConversion(typeof(string), typeof(Brush))]
	public class LetterToColorConverter :  IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is not string) throw new ArgumentException("Wrong parameter type", nameof(value));
			return value switch
			{
				"A" => Brushes.Black,
				"B" => Brushes.Red,
				"C" => Brushes.Green,
				"D" => Brushes.Blue,
				_ => Brushes.Black,
			};
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
