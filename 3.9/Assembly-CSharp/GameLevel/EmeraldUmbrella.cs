using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B51 RID: 2897
	[Token(Token = "0x2000B51")]
	public class EmeraldUmbrella : TravelAdvantureLevelData
	{
		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06003C59 RID: 15449 RVA: 0x0013B024 File Offset: 0x00139224
		[Token(Token = "0x170004D0")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003C59")]
			[Address(RVA = "0x715410", Offset = "0x713A10", VA = "0x180715410", Slot = "42")]
			get
			{
				return TravelAdvanture.EmeraldUmbrella;
			}
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x0013B034 File Offset: 0x00139234
		[Token(Token = "0x6003C5A")]
		[Address(RVA = "0x81E7A0", Offset = "0x81CDA0", VA = "0x18081E7A0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "超级伞 + 菜伞\n使用西瓜、卷心菜进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003C5B RID: 15451 RVA: 0x0013B060 File Offset: 0x00139260
		[Token(Token = "0x6003C5B")]
		[Address(RVA = "0x81E820", Offset = "0x81CE20", VA = "0x18081E820", Slot = "36")]
		public override void OnBoardStart(Board board)
		{
			base.OnBoardStart(board);
			int num = board.theSun;
			num += num;
			int num2 = 0;
			board.theSun = num;
			if (num2 < board.rowNum)
			{
				CreatePlant instance = CreatePlant.Instance;
				num2++;
			}
			num2++;
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06003C5C RID: 15452 RVA: 0x0013B0AC File Offset: 0x001392AC
		[Token(Token = "0x170004D1")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003C5C")]
			[Address(RVA = "0x7185D0", Offset = "0x716BD0", VA = "0x1807185D0", Slot = "12")]
			get
			{
				return SceneType.Roof_Pool;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06003C5D RID: 15453 RVA: 0x0013B0BC File Offset: 0x001392BC
		[Token(Token = "0x170004D2")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003C5D")]
			[Address(RVA = "0x81EAF0", Offset = "0x81D0F0", VA = "0x18081EAF0", Slot = "20")]
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
				int size9 = list._size;
				int size10 = list._size;
				return list;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06003C5E RID: 15454 RVA: 0x0013B13C File Offset: 0x0013933C
		[Token(Token = "0x170004D3")]
		public override int MaxWave
		{
			[Token(Token = "0x6003C5E")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06003C5F RID: 15455 RVA: 0x0013B14C File Offset: 0x0013934C
		[Token(Token = "0x170004D4")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003C5F")]
			[Address(RVA = "0x81E920", Offset = "0x81CF20", VA = "0x18081E920", Slot = "22")]
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

		// Token: 0x06003C60 RID: 15456 RVA: 0x0013B198 File Offset: 0x00139398
		[Token(Token = "0x6003C60")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public EmeraldUmbrella()
		{
		}
	}
}
