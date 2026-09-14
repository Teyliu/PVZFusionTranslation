using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B54 RID: 2900
	[Token(Token = "0x2000B54")]
	public class BambooDragon : TravelAdvantureLevelData
	{
		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06003C71 RID: 15473 RVA: 0x0013B4AC File Offset: 0x001396AC
		[Token(Token = "0x170004DF")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003C71")]
			[Address(RVA = "0x7194F0", Offset = "0x717AF0", VA = "0x1807194F0", Slot = "42")]
			get
			{
				return TravelAdvanture.BambooDragon;
			}
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x0013B4BC File Offset: 0x001396BC
		[Token(Token = "0x6003C72")]
		[Address(RVA = "0x81A8C0", Offset = "0x818EC0", VA = "0x18081A8C0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "樱桃辣椒 + 爆竹\n该植物暂时没有亚种";
			throw new NullReferenceException();
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x0013B4E8 File Offset: 0x001396E8
		[Token(Token = "0x6003C73")]
		[Address(RVA = "0x81A940", Offset = "0x818F40", VA = "0x18081A940", Slot = "36")]
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

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06003C74 RID: 15476 RVA: 0x0013B534 File Offset: 0x00139734
		[Token(Token = "0x170004E0")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003C74")]
			[Address(RVA = "0x7185D0", Offset = "0x716BD0", VA = "0x1807185D0", Slot = "12")]
			get
			{
				return SceneType.Roof_Pool;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06003C75 RID: 15477 RVA: 0x0013B544 File Offset: 0x00139744
		[Token(Token = "0x170004E1")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003C75")]
			[Address(RVA = "0x81AB60", Offset = "0x819160", VA = "0x18081AB60", Slot = "20")]
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

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06003C76 RID: 15478 RVA: 0x0013B5C4 File Offset: 0x001397C4
		[Token(Token = "0x170004E2")]
		public override int MaxWave
		{
			[Token(Token = "0x6003C76")]
			[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "10")]
			get
			{
				return 30;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06003C77 RID: 15479 RVA: 0x0013B5D4 File Offset: 0x001397D4
		[Token(Token = "0x170004E3")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003C77")]
			[Address(RVA = "0x81AA40", Offset = "0x819040", VA = "0x18081AA40", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x0013B610 File Offset: 0x00139810
		[Token(Token = "0x6003C78")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public BambooDragon()
		{
		}
	}
}
