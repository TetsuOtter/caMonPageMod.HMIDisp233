using System;
using System.Collections.Generic;
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

namespace caMonPageMod.HMIDisp233.No2
{
	/// <summary>
	/// Type0.xaml の相互作用ロジック
	/// </summary>
	public partial class Type0 : UserControl
	{
		public Type0(DataClass dc)
		{
			DataContext = dc;
			InitializeComponent();
		}
	}
}
