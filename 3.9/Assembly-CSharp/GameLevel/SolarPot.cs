using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B50 RID: 2896
	[Token(Token = "0x2000B50")]
	public class SolarPot : TravelAdvantureLevelData
	{
		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06003C51 RID: 15441 RVA: 0x0013AECC File Offset: 0x001390CC
		[Token(Token = "0x170004CB")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003C51")]
			[Address(RVA = "0x5D3550", Offset = "0x5D1B50", VA = "0x1805D3550", Slot = "42")]
			get
			{
				return TravelAdvanture.SolarPot;
			}
		}

		// Token: 0x06003C52 RID: 15442 RVA: 0x0013AEDC File Offset: 0x001390DC
		[Token(Token = "0x6003C52")]
		[Address(RVA = "0x831AF0", Offset = "0x8300F0", VA = "0x180831AF0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "金盆 + 向日葵\n使用铲子进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003C53 RID: 15443 RVA: 0x0013AF08 File Offset: 0x00139108
		[Token(Token = "0x6003C53")]
		[Address(RVA = "0x831B70", Offset = "0x830170", VA = "0x180831B70", Slot = "36")]
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

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06003C54 RID: 15444 RVA: 0x0013AF54 File Offset: 0x00139154
		[Token(Token = "0x170004CC")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003C54")]
			[Address(RVA = "0x7185D0", Offset = "0x716BD0", VA = "0x1807185D0", Slot = "12")]
			get
			{
				return SceneType.Roof_Pool;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06003C55 RID: 15445 RVA: 0x0013AF64 File Offset: 0x00139164
		[Token(Token = "0x170004CD")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003C55")]
			[Address(RVA = "0x831D90", Offset = "0x830390", VA = "0x180831D90", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				int size6 = list._size;
				return list;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06003C56 RID: 15446 RVA: 0x0013AFC4 File Offset: 0x001391C4
		[Token(Token = "0x170004CE")]
		public override int MaxWave
		{
			[Token(Token = "0x6003C56")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06003C57 RID: 15447 RVA: 0x0013AFD4 File Offset: 0x001391D4
		[Token(Token = "0x170004CF")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003C57")]
			[Address(RVA = "0x831C70", Offset = "0x830270", VA = "0x180831C70", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x0013B010 File Offset: 0x00139210
		[Token(Token = "0x6003C58")]
		[Address(RVA = "0x7602C0", Offset = "0x75E8C0", VA = "0x1807602C0")]
		public SolarPot()
		{
		}
	}
}
