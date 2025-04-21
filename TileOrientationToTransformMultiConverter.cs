using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Kachelding
{
	public class TileOrientationToTransformMultiConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			if (values.Length != 2) throw new ArgumentException("wrong parameters!", nameof(values));
			if (values[0] is not string) throw new ArgumentException("Wrong parameter type", nameof(values));
			if (parameter is null) parameter = "00";
			if (parameter is not string) throw new ArgumentException("Wrong parameter type", nameof(parameter));

			var quarterTileSize = (int)values[1] / 2;

			IEnumerable<Transform> positionTransforms = parameter switch
			{
				"00" => [],
				"01" => [new TranslateTransform(1 * quarterTileSize, 0 * quarterTileSize)],
				"10" => [new TranslateTransform(0 * quarterTileSize, 1 * quarterTileSize)],
				"11" => [new TranslateTransform(1 * quarterTileSize, 1 * quarterTileSize)],
				_ => throw new NotImplementedException(),
			};

			IEnumerable<Transform> flipTransforms = values[0] switch
			{
				"N" or "E" or "S" or "W" => [],
				"0" or "3" or "6" or "9" => [ new ScaleTransform(-1, 1), parameter switch {
					"00" or "10" => new TranslateTransform(-1 * quarterTileSize, 0 * quarterTileSize),
					"01" or "11" => new TranslateTransform(+1 * quarterTileSize, 0 * quarterTileSize),
					_ => throw new NotImplementedException(),
				}],
				_ => throw new NotImplementedException(),
			};

			IEnumerable<Transform> rotationTransforms = values[0] switch
			{
				"N" or "0" => [],
				"E" or "3" => [
					new RotateTransform(90),
					parameter switch {
						"00" => new TranslateTransform(-1 * quarterTileSize, 0 * quarterTileSize),
						"01" => new TranslateTransform( 0 * quarterTileSize, -1 * quarterTileSize),
						"10" => new TranslateTransform( 0 * quarterTileSize, +1 * quarterTileSize),
						"11" => new TranslateTransform(+1 * quarterTileSize, 0 * quarterTileSize),
						_ => throw new NotImplementedException(),
					}
					],
				"S" or "6" => [
					new RotateTransform(180),
					parameter switch {
						"00" => new TranslateTransform(-1 * quarterTileSize, -1 * quarterTileSize),
						"01" => new TranslateTransform(+1 * quarterTileSize, -1 * quarterTileSize),
						"10" => new TranslateTransform(-1 * quarterTileSize, +1 * quarterTileSize),
						"11" => new TranslateTransform(+1 * quarterTileSize, +1 * quarterTileSize),
						_ => throw new NotImplementedException(),
					}
					],
				"W" or "9" => [
					new RotateTransform(270),
					parameter switch {
						"00" => new TranslateTransform( 0 * quarterTileSize, -1 * quarterTileSize),
						"01" => new TranslateTransform(+1 * quarterTileSize, 0 * quarterTileSize),
						"10" => new TranslateTransform( -1 * quarterTileSize, 0 * quarterTileSize),
						"11" => new TranslateTransform(0 * quarterTileSize, +1 * quarterTileSize),
						_ => throw new NotImplementedException(),
					}
					],
				_ => throw new NotImplementedException(),
			};

			return new TransformGroup { Children = [.. positionTransforms, .. flipTransforms, .. rotationTransforms] };
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
