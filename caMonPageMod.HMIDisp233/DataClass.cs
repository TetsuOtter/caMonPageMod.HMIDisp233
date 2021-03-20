using System.ComponentModel;

namespace caMonPageMod.HMIDisp233
{
	public class DataClass : ILamps_No2_Type0, ILamps_No2_Type1000, ILamps_No2_Type2000, ILamps_No2_Type5000, ILamps_No2_Type6000ATS, ILamps_No2_Type6000ATC, ILamps_No2_Type7000ATS, ILamps_No2_Type7000ATACS
	{
		#region ATS-P
		public PanelToBoolClass PPow { get; } = new PanelToBoolClass(2);
		public PanelToBoolClass PPTN { get; } = new PanelToBoolClass(3);
		public PanelToBoolClass ATS_PNB { get; } = new PanelToBoolClass(5);
		public PanelToBoolClass PEB { get; } = new PanelToBoolClass(8);
		public PanelToBoolClass PBO { get; } = new PanelToBoolClass(4);
		public PanelToBoolClass ATSP { get; } = new PanelToBoolClass(6);
		public PanelToBoolClass PM { get; } = new PanelToBoolClass(7);
		#endregion ATS-P

		#region ATS-Sn
		public PanelToBoolClass ATSPow { get; } = new PanelToBoolClass(0);
		public PanelToBoolClass ATSB { get; } = new PanelToBoolClass(1);
		#endregion ATS-Sn

		#region D-ATC / ATC-10(CS-ATC)  D-ATCは対応プラグインなし
		public PanelToBoolClass DATC { get; } = new PanelToBoolClass();
		public PanelToBoolClass ATC { get; } = new PanelToBoolClass(53);
		public PanelToBoolClass ATCOff { get; } = new PanelToBoolClass();
		public PanelToBoolClass ATCPL { get; } = new PanelToBoolClass();
		public PanelToBoolClass EMOS { get; } = new PanelToBoolClass(56);
		public PanelToBoolClass ATCNB { get; } = new PanelToBoolClass(57);
		public PanelToBoolClass ATCEB { get; } = new PanelToBoolClass(58);
		public PanelToBoolClass ATCBS { get; } = new PanelToBoolClass();
		public PanelToBoolClass ATCPow { get; } = new PanelToBoolClass(52);
		public PanelToBoolClass ATCO { get; } = new PanelToBoolClass(59);
		#endregion D-ATC

		#region TASC
		public PanelToBoolClass TASCP { get; } = new PanelToBoolClass(85);
		public PanelToBoolClass TASCPt { get; } = new PanelToBoolClass(86);
		public PanelToBoolClass TASCB { get; } = new PanelToBoolClass(87);
		public PanelToBoolClass TASCCO { get; } = new PanelToBoolClass(88);
		public PanelToBoolClass TASCMC { get; } = new PanelToBoolClass();//対応indexなし
		public PanelToBoolClass INT { get; } = new PanelToBoolClass(89);
		#endregion TASC

		#region FD
		public PanelToBoolClass FP { get; } = new PanelToBoolClass(226);
		public PanelToBoolClass CDAC { get; } = new PanelToBoolClass(227);
		public PanelToBoolClass FDAC { get; } = new PanelToBoolClass(228);
		public PanelToBoolClass FDI { get; } = new PanelToBoolClass(229);
		public PanelToBoolClass FDICO { get; } = new PanelToBoolClass(230);
		#endregion FD

		#region 233-2k
		public PanelToBoolClass TASC { get => TASCP; }//推測
		public PanelToBoolClass TASCC { get => TASCPt; }//推測
		public PanelToBoolClass Metro { get; } = new PanelToBoolClass(37);
		public PanelToBoolClass JR { get; } = new PanelToBoolClass(36);
		public PanelToBoolClass In { get; } = new PanelToBoolClass(55);
		public PanelToBoolClass NoATC { get; } = new PanelToBoolClass(54);
		#endregion 233-2k

		#region ATACS
		public PanelToBoolClass AIDTr { get; } = new PanelToBoolClass();//対応Indexなし
		public PanelToBoolClass ATACS { get; } = new PanelToBoolClass(41);
		public PanelToBoolClass Cut { get; } = new PanelToBoolClass(42);
		public PanelToBoolClass PtnL { get; } = new PanelToBoolClass(47);
		public PanelToBoolClass EmO { get; } = new PanelToBoolClass(48);
		public PanelToBoolClass ATACSNB { get; } = new PanelToBoolClass(43);
		public PanelToBoolClass ATACSEB { get; } = new PanelToBoolClass(44);
		public PanelToBoolClass ASTP { get; } = new PanelToBoolClass(45);
		public PanelToBoolClass ATACSP { get; } = new PanelToBoolClass(38);
		public PanelToBoolClass ATACSCO { get; } = new PanelToBoolClass(39);
		public PanelToBoolClass BwD { get; } = new PanelToBoolClass(46);
		public PanelToBoolClass ATACSMC { get; } = new PanelToBoolClass();//対応Indexなし
		public PanelToBoolClass _1sMC { get; } = new PanelToBoolClass(21);
		public PanelToBoolClass _2sMC { get; } = new PanelToBoolClass(22);
		#endregion ATACS
	}

	public interface ILamps_ATSP
	{
		/// <summary>P電源</summary>
		PanelToBoolClass PPow { get; }
		/// <summary>パターン接近</summary>
		PanelToBoolClass PPTN { get; }
		/// <summary>常用ブレーキ</summary>
		PanelToBoolClass ATS_PNB { get; }
		/// <summary>非常ブレーキ</summary>
		PanelToBoolClass PEB { get; }
		/// <summary>ブレーキ開放</summary>
		PanelToBoolClass PBO { get; }
		/// <summary>ATS-P</summary>
		PanelToBoolClass ATSP { get; }
		/// <summary>故障</summary>
		PanelToBoolClass PM { get; }
	}
	public interface ILamps_ATSS
	{
		PanelToBoolClass ATSPow { get; }
		PanelToBoolClass ATSB { get; }
	}

	public interface ILamps_DATC
	{
		/// <summary>D-ATC</summary>
		PanelToBoolClass DATC { get; }
		/// <summary>ATC</summary>
		PanelToBoolClass ATC { get; }
		/// <summary>切</summary>
		PanelToBoolClass ATCOff { get; }
		/// <summary>パターン低減</summary>
		PanelToBoolClass ATCPL { get; }
		/// <summary>非常運転</summary>
		PanelToBoolClass EMOS { get; }
		/// <summary>ATC常用</summary>
		PanelToBoolClass ATCNB { get; }
		/// <summary>ATC非常</summary>
		PanelToBoolClass ATCEB { get; }
		/// <summary>停通防止動作</summary>
		PanelToBoolClass ATCBS { get; }
		/// <summary>ATC電源</summary>
		PanelToBoolClass ATCPow { get; }
		/// <summary>ATC開放</summary>
		PanelToBoolClass ATCO { get; }
	}

	public interface ILamps_TASC
	{
		/// <summary>TASC電源</summary>
		PanelToBoolClass TASCP { get; }
		/// <summary>TASCパターン</summary>
		PanelToBoolClass TASCPt { get; }
		/// <summary>TASCブレーキ</summary>
		PanelToBoolClass TASCB { get; }
		/// <summary>TASC切</summary>
		PanelToBoolClass TASCCO { get; }
		/// <summary>TASC故障</summary>
		PanelToBoolClass TASCMC { get; }
		/// <summary>インチング制御中</summary>
		PanelToBoolClass INT { get; }
	}
	public interface ILamps_FD
	{
		/// <summary>定位置</summary>
		PanelToBoolClass FP { get; }
		/// <summary>車両ドア全閉</summary>
		PanelToBoolClass CDAC { get; }
		/// <summary>ホームドア全閉</summary>
		PanelToBoolClass FDAC { get; }
		/// <summary>ホームドア連携</summary>
		PanelToBoolClass FDI { get; }
		/// <summary>ホームドア分離</summary>
		PanelToBoolClass FDICO { get; }
	}

	public interface ILamps_CSATC
	{
		/// <summary>地下鉄</summary>
		PanelToBoolClass Metro { get; }
		/// <summary>JR</summary>
		PanelToBoolClass JR { get; }
		/// <summary>ATC常用</summary>
		PanelToBoolClass ATCNB { get; }
		/// <summary>ATC非常</summary>
		PanelToBoolClass ATCEB { get; }
		/// <summary>ATC電源</summary>
		PanelToBoolClass ATCPow { get; }
		/// <summary>構内</summary>
		PanelToBoolClass In { get; }
		/// <summary>非設</summary>
		PanelToBoolClass NoATC { get; }
		/// <summary>ATC</summary>
		PanelToBoolClass ATC { get; }
	}

	public interface ILamps_ATACS
	{
		/// <summary>車上ID故障</summary>
		PanelToBoolClass AIDTr { get; }
		/// <summary>ATACS</summary>
		PanelToBoolClass ATACS { get; }
		/// <summary>切</summary>
		PanelToBoolClass Cut { get; }
		/// <summary>パターン低減</summary>
		PanelToBoolClass PtnL { get; }
		/// <summary>非常運転</summary>
		PanelToBoolClass EmO { get; }
		/// <summary>ATACS常用</summary>
		PanelToBoolClass ATACSNB { get; }
		/// <summary>ATACS非常</summary>
		PanelToBoolClass ATACSEB { get; }
		/// <summary>停通防止動作</summary>
		PanelToBoolClass ASTP { get; }
		/// <summary>ATACS電源</summary>
		PanelToBoolClass ATACSP { get; }
		/// <summary>ATACS開放</summary>
		PanelToBoolClass ATACSCO { get; }
		/// <summary>後退検知</summary>
		PanelToBoolClass BwD { get; }
		/// <summary>ATACS故障</summary>
		PanelToBoolClass ATACSMC { get; }
		/// <summary>1系故障</summary>
		PanelToBoolClass _1sMC { get; }
		/// <summary>2系故障</summary>
		PanelToBoolClass _2sMC { get; }
	}

	public interface ILamps_No2_Type0 : ILamps_ATSP, ILamps_ATSS { }
	public interface ILamps_No2_Type5000 : ILamps_ATSP, ILamps_ATSS { }

	public interface ILamps_No2_Type1000 : ILamps_ATSS, ILamps_DATC, ILamps_TASC, ILamps_FD { }
	public interface ILamps_No2_Type6000ATC : ILamps_DATC, ILamps_TASC { }
	public interface ILamps_No2_Type6000ATS : ILamps_DATC, ILamps_TASC { }

	public interface ILamps_No2_Type2000 : ILamps_ATSS, ILamps_CSATC, ILamps_FD
	{
		/// <summary>ATSC</summary>
		PanelToBoolClass TASC { get; }
		/// <summary>TASC制御</summary>
		PanelToBoolClass TASCC { get; }
		///// <summary>TASCブレーキ</summary>
		//PanelToBoolClass TASCB { get; }
	}

	public interface ILamps_No2_Type7000ATS : ILamps_ATSP { }
	public interface ILamps_No2_Type7000ATACS : ILamps_ATACS { }

	public class PanelToBoolClass : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(in string name) => PropertyChanged?.Invoke(this, new(name));

		public PanelToBoolClass() => Init(-1);
		public PanelToBoolClass(in int index) => Init(index);
		private void Init(in int index)
		{
			Index = index;
			TR.BIDSSMemLib.SMemLib.PanelDChanged += SMemLib_PanelDChanged;
		}

		private void SMemLib_PanelDChanged(object sender, TR.BIDSSMemLib.SMemLib.ArrayDChangedEArgs e)
		{
			if (Index < 0 || e.NewArray.Length <= Index)
				return;
			Value = (e.NewArray[Index] > 0);
		}

		private int _Index = -1;
		public int Index { get => _Index; set { if (_Index != value) { _Index = value; OnPropertyChanged(nameof(Index)); } } }

		private bool _Value = false;
		public bool Value { get => _Value; set { if(Value != value) { _Value = value; OnPropertyChanged(nameof(Value)); } } }
	}


}
