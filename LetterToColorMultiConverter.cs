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

namespace Kachelding
{
	public class LetterToColorMultiConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			if (values.Length != 5) throw new ArgumentException("wrong parameters!", nameof(values));
			if (values[0] is not string) throw new ArgumentException("Wrong parameter type", nameof(values));

			return values[0] switch
			{
				"A" or "a" => new SolidColorBrush((Color)ColorConverter.ConvertFromString((string)values[1])),
				"B" or "b" => new SolidColorBrush((Color)ColorConverter.ConvertFromString((string)values[2])),
				"C" or "c" => new SolidColorBrush((Color)ColorConverter.ConvertFromString((string)values[3])),
				"D" or "d" => new SolidColorBrush((Color)ColorConverter.ConvertFromString((string)values[4])),
				_ => Brushes.Black,
			};
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
