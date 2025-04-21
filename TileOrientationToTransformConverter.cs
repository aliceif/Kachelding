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
	[ValueConversion(typeof(string), typeof(Transform))]
	public class TileOrientationToTransformConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is not string) throw new ArgumentException("Wrong parameter type", nameof(value));
			if (parameter is null) parameter = "00";
			if (parameter is not string) throw new ArgumentException("Wrong parameter type", nameof(value));

			IEnumerable<Transform> positionTransforms = parameter switch
			{
				"00" => [],
				"01" => [new TranslateTransform(1 * 40, 0 * 40)],
				"10" => [new TranslateTransform(0 * 40, 1 * 40)],
				"11" => [new TranslateTransform(1 * 40, 1 * 40)],
				_ => throw new NotImplementedException(),
			};

			IEnumerable<Transform> modificationTransforms = value switch
			{
				"N" => [],
				"E" => [
					new RotateTransform(90),
					parameter switch {
						"00" => new TranslateTransform(-1 * 40, 0 * 40),
						"01" => new TranslateTransform( 0 * 40, -1 * 40),
						"10" => new TranslateTransform(+1 * 40, 0 * 40),
						"11" => new TranslateTransform( 0 * 40, +1 * 40),
				_ => throw new NotImplementedException(),
					}
					],
				_ => throw new NotImplementedException(),
			};

			return new TransformGroup { Children = new TransformCollection(positionTransforms.Concat(modificationTransforms)) };
		}
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
