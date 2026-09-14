using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B44 RID: 2884
	[Token(Token = "0x2000B44")]
	public class NuclearDoomCherry : TravelAdvantureLevelData
	{
		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x00139E28 File Offset: 0x00138028
		[Token(Token = "0x1700048F")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003BF0")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "42")]
			get
			{
				return TravelAdvanture.NuclearDoomCherry;
			}
		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x00139E38 File Offset: 0x00138038
		[Token(Token = "0x6003BF1")]
		[Address(RVA = "0x7F1F90", Offset = "0x7F0590", VA = "0x1807F1F90", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "毁灭樱桃 + 樱桃炸弹\n使用窝瓜、樱桃炸弹进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003BF2 RID: 15346 RVA: 0x00139E64 File Offset: 0x00138064
		[Token(Token = "0x6003BF2")]
		[Address(RVA = "0x7F2010", Offset = "0x7F0610", VA = "0x1807F2010", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06003BF3 RID: 15347 RVA: 0x00139E90 File Offset: 0x00138090
		[Token(Token = "0x17000490")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003BF3")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06003BF4 RID: 15348 RVA: 0x00139EA8 File Offset: 0x001380A8
		[Token(Token = "0x17000491")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003BF4")]
			[Address(RVA = "0x7F21B0", Offset = "0x7F07B0", VA = "0x1807F21B0", Slot = "20")]
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

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06003BF5 RID: 15349 RVA: 0x00139F18 File Offset: 0x00138118
		[Token(Token = "0x17000492")]
		public override int MaxWave
		{
			[Token(Token = "0x6003BF5")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06003BF6 RID: 15350 RVA: 0x00139F28 File Offset: 0x00138128
		[Token(Token = "0x17000493")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003BF6")]
			[Address(RVA = "0x7F2040", Offset = "0x7F0640", VA = "0x1807F2040", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x00139F6C File Offset: 0x0013816C
		[Token(Token = "0x6003BF7")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public NuclearDoomCherry()
		{
		}
	}
}
