using System.Windows.Controls;

namespace caMonPageMod.HMIDisp233.No2
{
	/// <summary>
	/// Type0.xaml の相互作用ロジック
	/// </summary>
	public partial class Type0 : UserControl
	{
		public Type0(HoanLampStates dc)
		{
			DataContext = dc;
			InitializeComponent();
		}
	}
}
