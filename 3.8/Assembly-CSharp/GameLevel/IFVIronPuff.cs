using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B0B RID: 2827
	[Token(Token = "0x2000B0B")]
	public class IFVIronPuff : TravelAdvantureLevelData
	{
		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06003AE7 RID: 15079 RVA: 0x001356A8 File Offset: 0x001338A8
		[Token(Token = "0x1700046C")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003AE7")]
			[Address(RVA = "0x3AB4C0", Offset = "0x3A9AC0", VA = "0x1803AB4C0", Slot = "42")]
			get
			{
				return TravelAdvanture.IFVIronPuff;
			}
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x001356B8 File Offset: 0x001338B8
		[Token(Token = "0x6003AE8")]
		[Address(RVA = "0x7B0210", Offset = "0x7AE810", VA = "0x1807B0210", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "铁豆x3 + 磁力菇\n使用三叶草、磁力菇进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x001356E4 File Offset: 0x001338E4
		[Token(Token = "0x6003AE9")]
		[Address(RVA = "0x783650", Offset = "0x781C50", VA = "0x180783650", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06003AEA RID: 15082 RVA: 0x00135710 File Offset: 0x00133910
		[Token(Token = "0x1700046D")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003AEA")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06003AEB RID: 15083 RVA: 0x00135720 File Offset: 0x00133920
		[Token(Token = "0x1700046E")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003AEB")]
			[Address(RVA = "0x7B0400", Offset = "0x7AEA00", VA = "0x1807B0400", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				int size7 = list._size;
				int size8 = list._size;
				return list;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06003AEC RID: 15084 RVA: 0x00135790 File Offset: 0x00133990
		[Token(Token = "0x1700046F")]
		public override int MaxWave
		{
			[Token(Token = "0x6003AEC")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06003AED RID: 15085 RVA: 0x001357A0 File Offset: 0x001339A0
		[Token(Token = "0x17000470")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003AED")]
			[Address(RVA = "0x7B0290", Offset = "0x7AE890", VA = "0x1807B0290", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003AEE RID: 15086 RVA: 0x001357E4 File Offset: 0x001339E4
		[Token(Token = "0x6003AEE")]
		[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
		public IFVIronPuff()
		{
		}
	}
}
