using System;
using System.Windows;
using System.Windows.Controls;

using BIDSDataUpdateNotifier.LampStateProvider;

using caMon;

using caMonPageMod.HMIDisp233.No2;

namespace caMonPageMod.HMIDisp233
{
	/// <summary>
	/// TopPage.xaml の相互作用ロジック
	/// </summary>
	public partial class TopPage : Page, IPages
	{
		public TopPage()
		{
			InitializeComponent();
			FrontPage = this;
		}

		public Page FrontPage { get; }

		public event EventHandler BackToHome;
		public event EventHandler CloseApp;

		readonly HoanLampStates LampStates = new();
		public void Dispose()
		{
			
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			CP.Content = (sender as Button)?.Name switch
			{
				"typ0" => new Type0(LampStates),
				"typ1" => new Type1k(LampStates),
				"typ2" => new Type2k(LampStates),
				"typ6d" => new Type6k(LampStates, Type6k.Mode.DATC),
				"typ6p" => new Type6k(LampStates, Type6k.Mode.ATSP),
				"typ7" => new Type7k(LampStates, Type7k.Mode.Auto),
				"typ7p" => new Type7k(LampStates, Type7k.Mode.ATSP),
				"typ7r" => new Type7k(LampStates, Type7k.Mode.ATACS),
				_ => null
			};
			PageSelPopUp.Visibility = Visibility.Collapsed;
		}

		private void SelBtnClick(object sender, RoutedEventArgs e)
			=> PageSelPopUp.Visibility = PageSelPopUp.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;

		private void GoHome(object sender, RoutedEventArgs e) => BackToHome?.Invoke(this, null);

		private void CloseAppInv(object sender, RoutedEventArgs e) => CloseApp?.Invoke(this, null);
	}

	public class HoanLampStates
	{
		public ATSPLamps ATSP { get; } = new();
		public ATACSLamps ATACS { get; } = new();
		public ATSSnLamps ATSSn { get; } = new();
		public TASCLamps TASC { get; } = new();
		public FDLamps FD { get; } = new();
		public DATCLamps DATC { get; } = new();

		public DataClass CSATC { get; } = new();
	}
}
