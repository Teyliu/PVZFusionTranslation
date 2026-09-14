using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B04 RID: 2820
	[Token(Token = "0x2000B04")]
	public class CattailLour : TravelAdvantureLevelData
	{
		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06003AAF RID: 15023 RVA: 0x00134D80 File Offset: 0x00132F80
		[Token(Token = "0x17000449")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003AAF")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "42")]
			get
			{
				return TravelAdvanture.CattailLour;
			}
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x00134D90 File Offset: 0x00132F90
		[Token(Token = "0x6003AB0")]
		[Address(RVA = "0x7835D0", Offset = "0x781BD0", VA = "0x1807835D0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "香蒲 + 猫瓜\n使用闪电洋葱、香蒲进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x00134DBC File Offset: 0x00132FBC
		[Token(Token = "0x6003AB1")]
		[Address(RVA = "0x783650", Offset = "0x781C50", VA = "0x180783650", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06003AB2 RID: 15026 RVA: 0x00134DE8 File Offset: 0x00132FE8
		[Token(Token = "0x1700044A")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003AB2")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06003AB3 RID: 15027 RVA: 0x00134E00 File Offset: 0x00133000
		[Token(Token = "0x1700044B")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003AB3")]
			[Address(RVA = "0x7837F0", Offset = "0x781DF0", VA = "0x1807837F0", Slot = "20")]
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
				return list;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06003AB4 RID: 15028 RVA: 0x00134E68 File Offset: 0x00133068
		[Token(Token = "0x1700044C")]
		public override int MaxWave
		{
			[Token(Token = "0x6003AB4")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06003AB5 RID: 15029 RVA: 0x00134E78 File Offset: 0x00133078
		[Token(Token = "0x1700044D")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003AB5")]
			[Address(RVA = "0x783680", Offset = "0x781C80", VA = "0x180783680", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x00134EBC File Offset: 0x001330BC
		[Token(Token = "0x6003AB6")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public CattailLour()
		{
		}
	}
}
