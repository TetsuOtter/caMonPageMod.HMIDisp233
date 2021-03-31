using System.Windows.Controls;

namespace caMonPageMod.HMIDisp233.No2
{
	/// <summary>
	/// Type1k.xaml の相互作用ロジック
	/// </summary>
	public partial class Type1k : UserControl
	{
		public Type1k(HoanLampStates dc)
		{
			DataContext = dc;
			InitializeComponent();
		}
	}
}
