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
			this.PixelSize = 100;
			this.Cell00 = "A";
			this.Cell01 = "B";
			this.Cell02 = "C";
			this.Cell03 = "D";
			this.Cell10 = "B";
			this.Cell11 = "A";
			this.Cell12 = "D";
			this.Cell13 = "C";
			this.Cell20 = "A";
			this.Cell21 = "B";
			this.Cell22 = "D";
			this.Cell23 = "C";
			this.Cell30 = "B";
			this.Cell31 = "A";
			this.Cell32 = "C";
			this.Cell33 = "D";
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

		private string _cell10;

		public string Cell10
		{
			get { return _cell10; }
			set
			{
				if (_cell10 != value)
				{
					_cell10 = value;
					OnPropertyChanged(nameof(Cell10));
				}
			}
		}

		private string _cell11;

		public string Cell11
		{
			get { return _cell11; }
			set
			{
				if (_cell11 != value)
				{
					_cell11 = value;
					OnPropertyChanged(nameof(Cell11));
				}
			}
		}

		private string _cell12;

		public string Cell12
		{
			get { return _cell12; }
			set
			{
				if (_cell12 != value)
				{
					_cell12 = value;
					OnPropertyChanged(nameof(Cell12));
				}
			}
		}

		private string _cell13;

		public string Cell13
		{
			get { return _cell13; }
			set
			{
				if (_cell13 != value)
				{
					_cell13 = value;
					OnPropertyChanged(nameof(Cell13));
				}
			}
		}

		private string _cell20;

		public string Cell20
		{
			get { return _cell20; }
			set
			{
				if (_cell20 != value)
				{
					_cell20 = value;
					OnPropertyChanged(nameof(Cell20));
				}
			}
		}

		private string _cell21;

		public string Cell21
		{
			get { return _cell21; }
			set
			{
				if (_cell21 != value)
				{
					_cell21 = value;
					OnPropertyChanged(nameof(Cell21));
				}
			}
		}

		private string _cell22;

		public string Cell22
		{
			get { return _cell22; }
			set
			{
				if (_cell22 != value)
				{
					_cell22 = value;
					OnPropertyChanged(nameof(Cell22));
				}
			}
		}

		private string _cell23;

		public string Cell23
		{
			get { return _cell23; }
			set
			{
				if (_cell23 != value)
				{
					_cell23 = value;
					OnPropertyChanged(nameof(Cell23));
				}
			}
		}

		private string _cell30;

		public string Cell30
		{
			get { return _cell30; }
			set
			{
				if (_cell30 != value)
				{
					_cell30 = value;
					OnPropertyChanged(nameof(Cell30));
				}
			}
		}

		private string _cell31;

		public string Cell31
		{
			get { return _cell31; }
			set
			{
				if (_cell31 != value)
				{
					_cell31 = value;
					OnPropertyChanged(nameof(Cell31));
				}
			}
		}

		private string _cell32;

		public string Cell32
		{
			get { return _cell32; }
			set
			{
				if (_cell32 != value)
				{
					_cell32 = value;
					OnPropertyChanged(nameof(Cell32));
				}
			}
		}

		private string _cell33;

		public string Cell33
		{
			get { return _cell33; }
			set
			{
				if (_cell33 != value)
				{
					_cell33 = value;
					OnPropertyChanged(nameof(Cell33));
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