using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B0A RID: 2826
	[Token(Token = "0x2000B0A")]
	public class LaserUmbrella : TravelAdvantureLevelData
	{
		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06003ADF RID: 15071 RVA: 0x00135550 File Offset: 0x00133750
		[Token(Token = "0x17000467")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003ADF")]
			[Address(RVA = "0x3ADAB0", Offset = "0x3AC0B0", VA = "0x1803ADAB0", Slot = "42")]
			get
			{
				return TravelAdvanture.LaserUmbrella;
			}
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x00135560 File Offset: 0x00133760
		[Token(Token = "0x6003AE0")]
		[Address(RVA = "0x7B0C90", Offset = "0x7AF290", VA = "0x1807B0C90", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "流光仙人掌 + 流光保护伞\n使用寒冰菇、路灯花进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003AE1 RID: 15073 RVA: 0x0013558C File Offset: 0x0013378C
		[Token(Token = "0x6003AE1")]
		[Address(RVA = "0x783650", Offset = "0x781C50", VA = "0x180783650", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			board.theSun = num;
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06003AE2 RID: 15074 RVA: 0x001355B8 File Offset: 0x001337B8
		[Token(Token = "0x17000468")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003AE2")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06003AE3 RID: 15075 RVA: 0x001355C8 File Offset: 0x001337C8
		[Token(Token = "0x17000469")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003AE3")]
			[Address(RVA = "0x7B0EE0", Offset = "0x7AF4E0", VA = "0x1807B0EE0", Slot = "20")]
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

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06003AE4 RID: 15076 RVA: 0x00135638 File Offset: 0x00133838
		[Token(Token = "0x1700046A")]
		public override int MaxWave
		{
			[Token(Token = "0x6003AE4")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06003AE5 RID: 15077 RVA: 0x00135648 File Offset: 0x00133848
		[Token(Token = "0x1700046B")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003AE5")]
			[Address(RVA = "0x7B0D10", Offset = "0x7AF310", VA = "0x1807B0D10", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				return list;
			}
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x00135694 File Offset: 0x00133894
		[Token(Token = "0x6003AE6")]
		[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
		public LaserUmbrella()
		{
		}
	}
}
