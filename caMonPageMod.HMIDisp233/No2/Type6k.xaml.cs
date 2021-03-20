using System.Windows;
using System.Windows.Controls;

namespace caMonPageMod.HMIDisp233.No2
{
	/// <summary>
	/// Type6k.xaml の相互作用ロジック
	/// </summary>
	public partial class Type6k : UserControl
	{
		public enum Mode
		{
			None, ATSP, DATC
		}

		public Type6k(DataClass dc, Mode mode)
		{
			DataContext = dc;
			InitializeComponent();
			ATC.Visibility = mode == Mode.DATC ? Visibility.Visible : Visibility.Collapsed;
			ATS.Visibility = mode == Mode.ATSP ? Visibility.Visible : Visibility.Collapsed;
		}
	}
}
