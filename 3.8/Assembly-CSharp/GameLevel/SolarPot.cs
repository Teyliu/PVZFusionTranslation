using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B0E RID: 2830
	[Token(Token = "0x2000B0E")]
	public class SolarPot : TravelAdvantureLevelData
	{
		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06003B00 RID: 15104 RVA: 0x00135B7C File Offset: 0x00133D7C
		[Token(Token = "0x1700047B")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003B00")]
			[Address(RVA = "0x56FE40", Offset = "0x56E440", VA = "0x18056FE40", Slot = "42")]
			get
			{
				return TravelAdvanture.SolarPot;
			}
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x00135B8C File Offset: 0x00133D8C
		[Token(Token = "0x6003B01")]
		[Address(RVA = "0x7B61B0", Offset = "0x7B47B0", VA = "0x1807B61B0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "金盆 + 向日葵\n使用铲子进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x00135BB8 File Offset: 0x00133DB8
		[Token(Token = "0x6003B02")]
		[Address(RVA = "0x7B6230", Offset = "0x7B4830", VA = "0x1807B6230", Slot = "36")]
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

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06003B03 RID: 15107 RVA: 0x00135C04 File Offset: 0x00133E04
		[Token(Token = "0x1700047C")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B03")]
			[Address(RVA = "0x69E470", Offset = "0x69CA70", VA = "0x18069E470", Slot = "12")]
			get
			{
				return SceneType.Roof_Pool;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06003B04 RID: 15108 RVA: 0x00135C14 File Offset: 0x00133E14
		[Token(Token = "0x1700047D")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003B04")]
			[Address(RVA = "0x7B6450", Offset = "0x7B4A50", VA = "0x1807B6450", Slot = "20")]
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

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06003B05 RID: 15109 RVA: 0x00135C74 File Offset: 0x00133E74
		[Token(Token = "0x1700047E")]
		public override int MaxWave
		{
			[Token(Token = "0x6003B05")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06003B06 RID: 15110 RVA: 0x00135C84 File Offset: 0x00133E84
		[Token(Token = "0x1700047F")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003B06")]
			[Address(RVA = "0x7B6330", Offset = "0x7B4930", VA = "0x1807B6330", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003B07 RID: 15111 RVA: 0x00135CC0 File Offset: 0x00133EC0
		[Token(Token = "0x6003B07")]
		[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
		public SolarPot()
		{
		}
	}
}
