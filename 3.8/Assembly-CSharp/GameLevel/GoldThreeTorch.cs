using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B10 RID: 2832
	[Token(Token = "0x2000B10")]
	public class GoldThreeTorch : TravelAdvantureLevelData
	{
		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06003B10 RID: 15120 RVA: 0x00135E5C File Offset: 0x0013405C
		[Token(Token = "0x17000485")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003B10")]
			[Address(RVA = "0x69B710", Offset = "0x699D10", VA = "0x18069B710", Slot = "42")]
			get
			{
				return TravelAdvanture.GoldThreeTorch;
			}
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x00135E6C File Offset: 0x0013406C
		[Token(Token = "0x6003B11")]
		[Address(RVA = "0x7AFBF0", Offset = "0x7AE1F0", VA = "0x1807AFBF0", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "三线火炬 + 吸金磁\n使用路灯花、火炬树桩进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x00135E98 File Offset: 0x00134098
		[Token(Token = "0x6003B12")]
		[Address(RVA = "0x7AFC70", Offset = "0x7AE270", VA = "0x1807AFC70", Slot = "36")]
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
			TravelMgr instance2 = TravelMgr.Instance;
			TravelMgr instance3 = TravelMgr.Instance;
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06003B13 RID: 15123 RVA: 0x00135EF8 File Offset: 0x001340F8
		[Token(Token = "0x17000486")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B13")]
			[Address(RVA = "0x69E470", Offset = "0x69CA70", VA = "0x18069E470", Slot = "12")]
			get
			{
				return SceneType.Roof_Pool;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06003B14 RID: 15124 RVA: 0x00135F08 File Offset: 0x00134108
		[Token(Token = "0x17000487")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003B14")]
			[Address(RVA = "0x7AFFA0", Offset = "0x7AE5A0", VA = "0x1807AFFA0", Slot = "20")]
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

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06003B15 RID: 15125 RVA: 0x00135F68 File Offset: 0x00134168
		[Token(Token = "0x17000488")]
		public override int MaxWave
		{
			[Token(Token = "0x6003B15")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06003B16 RID: 15126 RVA: 0x00135F78 File Offset: 0x00134178
		[Token(Token = "0x17000489")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003B16")]
			[Address(RVA = "0x7AFDD0", Offset = "0x7AE3D0", VA = "0x1807AFDD0", Slot = "22")]
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

		// Token: 0x06003B17 RID: 15127 RVA: 0x00135FC4 File Offset: 0x001341C4
		[Token(Token = "0x6003B17")]
		[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
		public GoldThreeTorch()
		{
		}
	}
}
