using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B02 RID: 2818
	[Token(Token = "0x2000B02")]
	public class NuclearDoomCherry : TravelAdvantureLevelData
	{
		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06003A9F RID: 15007 RVA: 0x00134AD8 File Offset: 0x00132CD8
		[Token(Token = "0x1700043F")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003A9F")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "42")]
			get
			{
				return TravelAdvanture.NuclearDoomCherry;
			}
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x00134AE8 File Offset: 0x00132CE8
		[Token(Token = "0x6003AA0")]
		[Address(RVA = "0x78B910", Offset = "0x789F10", VA = "0x18078B910", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "毁灭樱桃 + 樱桃炸弹\n使用窝瓜、樱桃炸弹进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x00134B14 File Offset: 0x00132D14
		[Token(Token = "0x6003AA1")]
		[Address(RVA = "0x783650", Offset = "0x781C50", VA = "0x180783650", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06003AA2 RID: 15010 RVA: 0x00134B40 File Offset: 0x00132D40
		[Token(Token = "0x17000440")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003AA2")]
			[Address(RVA = "0x3A6A70", Offset = "0x3A5070", VA = "0x1803A6A70", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06003AA3 RID: 15011 RVA: 0x00134B58 File Offset: 0x00132D58
		[Token(Token = "0x17000441")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003AA3")]
			[Address(RVA = "0x78BB00", Offset = "0x78A100", VA = "0x18078BB00", Slot = "20")]
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

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06003AA4 RID: 15012 RVA: 0x00134BC8 File Offset: 0x00132DC8
		[Token(Token = "0x17000442")]
		public override int MaxWave
		{
			[Token(Token = "0x6003AA4")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06003AA5 RID: 15013 RVA: 0x00134BD8 File Offset: 0x00132DD8
		[Token(Token = "0x17000443")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003AA5")]
			[Address(RVA = "0x78B990", Offset = "0x789F90", VA = "0x18078B990", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003AA6 RID: 15014 RVA: 0x00134C1C File Offset: 0x00132E1C
		[Token(Token = "0x6003AA6")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public NuclearDoomCherry()
		{
		}
	}
}
