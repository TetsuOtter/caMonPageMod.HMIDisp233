using BIDSDataUpdateNotifier;
using BIDSDataUpdateNotifier.LampStateProvider;

namespace caMonPageMod.HMIDisp233
{
	public class DataClass : LampsClassBASE<Lamps_CSATC_Indexes>, ILamps_CSATC<BoolValueProvideFromPanel>
	{
		static private readonly Lamps_CSATC_Indexes DefaultIndexes = new()
		{
			ATC = 53,
			ATCEB = 58,
			ATCNB = 57,
			ATCPow = 52,
			NoATC = 54,
			In = 55,
			JR = 36,
			Metro = 37
		};

		public DataClass() => LampsIndexes = DefaultIndexes;
		public DataClass(in Lamps_CSATC_Indexes indexes) => LampsIndexes = indexes;

		public override Lamps_CSATC_Indexes LampsIndexes
		{
			get => new() { ATC = ATC.Index, ATCEB = ATCEB.Index, ATCNB = ATCNB.Index, ATCPow =  ATCPow.Index, In = In.Index, JR = JR.Index, Metro = Metro.Index, NoATC = NoATC.Index };
			set
			{
				ATC.Index = value.ATC;
				ATCEB.Index = value.ATCEB;
				ATCNB.Index = value.ATCNB;
				ATCPow.Index = value.ATCPow;
				In.Index = value.In;
				JR.Index = value.JR;
				Metro.Index = value.Metro;
				NoATC.Index = value.NoATC;
			}
		}
		
		public BoolValueProvideFromPanel Metro { get; } = new();
		public BoolValueProvideFromPanel JR { get; } = new();
		public BoolValueProvideFromPanel ATCNB { get; } = new();
		public BoolValueProvideFromPanel ATCEB { get; } = new();
		public BoolValueProvideFromPanel ATCPow { get; } = new();
		public BoolValueProvideFromPanel In { get; } = new();
		public BoolValueProvideFromPanel NoATC { get; } = new();
		public BoolValueProvideFromPanel ATC { get; } = new();
	}

	public interface ILamps_CSATC<T>
	{
		/// <summary>地下鉄</summary>
		T Metro { get; }
		/// <summary>JR</summary>
		T JR { get; }
		/// <summary>ATC常用</summary>
		T ATCNB { get; }
		/// <summary>ATC非常</summary>
		T ATCEB { get; }
		/// <summary>ATC電源</summary>
		T ATCPow { get; }
		/// <summary>構内</summary>
		T In { get; }
		/// <summary>非設</summary>
		T NoATC { get; }
		/// <summary>ATC</summary>
		T ATC { get; }
	}

	public class Lamps_CSATC_Indexes : ILamps_CSATC<int>
	{
		public int Metro { get; set; }
		public int JR { get; set; }
		public int ATCNB { get; set; }
		public int ATCEB { get; set; }
		public int ATCPow { get; set; }
		public int In { get; set; }
		public int NoATC { get; set; }
		public int ATC { get; set; }
	}
}
