using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kachelding
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window, INotifyPropertyChanged
	{
		public MainWindow()
		{
			InitializeComponent();
			this.DataContext = this;
			this.PixelSize = 16;
			this.Cell00 = "A";
			this.Cell01 = "B";
			this.Cell02 = "C";
			this.Cell03 = "D";
			this.ColorA = "Black";
			this.ColorB = "Red";
			this.ColorC = "Green";
			this.ColorD = "Blue";
		}


		private int _pixelSize;

		public int PixelSize
		{
			get { return _pixelSize; }
			set
			{
				if (_pixelSize != value)
				{
					_pixelSize = value;
					OnPropertyChanged(nameof(PixelSize));
				}
			}
		}

		#region "Cell NPs"
		private string _cell00;

		public string Cell00
		{
			get { return _cell00; }
			set
			{
				if (_cell00 != value)
				{
					_cell00 = value;
					OnPropertyChanged(nameof(Cell00));
				}
			}
		}

		private string _cell01;

		public string Cell01
		{
			get { return _cell01; }
			set
			{
				if (_cell01 != value)
				{
					_cell01 = value;
					OnPropertyChanged(nameof(Cell01));
				}
			}
		}

		private string _cell02;

		public string Cell02
		{
			get { return _cell02; }
			set
			{
				if (_cell02 != value)
				{
					_cell02 = value;
					OnPropertyChanged(nameof(Cell02));
				}
			}
		}

		private string _cell03;

		public string Cell03
		{
			get { return _cell03; }
			set
			{
				if (_cell03 != value)
				{
					_cell03 = value;
					OnPropertyChanged(nameof(Cell03));
				}
			}
		}

		#endregion "Cell NPs"

		#region "Color NPs"

		private string _colorA;

		public string ColorA
		{
			get { return _colorA; }
			set
			{
				if (_colorA != value)
				{
					_colorA = value;
					OnPropertyChanged(nameof(ColorA));
				}
			}
		}

		private string _colorB;

		public string ColorB
		{
			get { return _colorB; }
			set
			{
				if (_colorB != value)
				{
					_colorB = value;
					OnPropertyChanged(nameof(ColorB));
				}
			}
		}

		private string _colorC;

		public string ColorC
		{
			get { return _colorC; }
			set
			{
				if (_colorC != value)
				{
					_colorC = value;
					OnPropertyChanged(nameof(ColorC));
				}
			}
		}

		private string _colorD;

		public string ColorD
		{
			get { return _colorD; }
			set
			{
				if (_colorD != value)
				{
					_colorD = value;
					OnPropertyChanged(nameof(ColorD));
				}
			}
		}

		#endregion "Color NPs"

		#region "INP"

		public event PropertyChangedEventHandler? PropertyChanged;

		protected void OnPropertyChanged(string? propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion "INP"
	}
}