using System.Windows.Controls;

namespace caMonPageMod.HMIDisp233.No2
{
	/// <summary>
	/// Type2k.xaml の相互作用ロジック
	/// </summary>
	public partial class Type2k : UserControl
	{
		public Type2k(DataClass dc)
		{
			DataContext = dc;
			InitializeComponent();
		}
	}
}
