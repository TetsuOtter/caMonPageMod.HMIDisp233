using System.Windows;
using System.Windows.Controls;

namespace caMonPageMod.HMIDisp233.No2
{
	/// <summary>
	/// Type7k.xaml の相互作用ロジック
	/// </summary>
	public partial class Type7k : UserControl
	{
		public enum Mode { Auto, ATACS, ATSP, ATC6 }
		public Type7k(DataClass dc, Mode mode)
		{
			DataContext = dc;
			InitializeComponent();

			if (mode == Mode.Auto)
			{
				Loaded += Type7k_Loaded;
				Unloaded += Type7k_Unloaded;
			}
			else
			{
				ATS.Visibility = mode == Mode.ATSP ? Visibility.Visible : Visibility.Collapsed;
				ATC.Visibility = mode == Mode.ATC6 ? Visibility.Visible : Visibility.Collapsed;
				ATACS.Visibility = mode == Mode.ATACS ? Visibility.Visible : Visibility.Collapsed;
			}
		}

		private void Type7k_Loaded(object sender, RoutedEventArgs e)
		{
			TR.BIDSSMemLib.SMemLib.PanelDChanged += SMemLib_PanelDChanged;
		}

		private void Type7k_Unloaded(object sender, RoutedEventArgs e)
		{
			TR.BIDSSMemLib.SMemLib.PanelDChanged -= SMemLib_PanelDChanged;
		}

		private void SMemLib_PanelDChanged(object sender, TR.BIDSSMemLib.SMemLib.ArrayDChangedEArgs e)
		{
			if (e.NewArray.Length >= 256)
			{
				Visibility v_ats = Visibility.Collapsed;
				Visibility v_atc = Visibility.Collapsed;
				Visibility v_atacs = Visibility.Collapsed;

				switch (e.NewArray[254])
				{
					case 0:
						v_ats = Visibility.Visible;
						break;
					case 1:
						v_atc = Visibility.Visible;
						break;
					case 2:
						v_atacs = Visibility.Visible;
						break;
				}

				if (ATS.Visibility != v_ats)
					ATS.Visibility = v_ats;
				if (ATC.Visibility != v_atc)
					ATC.Visibility = v_atc;
				if (ATACS.Visibility != v_atacs)
					ATACS.Visibility = v_atacs;
			}
		}
	}
}
