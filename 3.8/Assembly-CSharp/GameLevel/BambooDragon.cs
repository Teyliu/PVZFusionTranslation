using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B12 RID: 2834
	[Token(Token = "0x2000B12")]
	public class BambooDragon : TravelAdvantureLevelData
	{
		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06003B20 RID: 15136 RVA: 0x0013615C File Offset: 0x0013435C
		[Token(Token = "0x1700048F")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003B20")]
			[Address(RVA = "0x69F390", Offset = "0x69D990", VA = "0x18069F390", Slot = "42")]
			get
			{
				return TravelAdvanture.BambooDragon;
			}
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x0013616C File Offset: 0x0013436C
		[Token(Token = "0x6003B21")]
		[Address(RVA = "0x79F850", Offset = "0x79DE50", VA = "0x18079F850", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "樱桃辣椒 + 爆竹\n该植物暂时没有亚种";
			throw new NullReferenceException();
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x00136198 File Offset: 0x00134398
		[Token(Token = "0x6003B22")]
		[Address(RVA = "0x79F8D0", Offset = "0x79DED0", VA = "0x18079F8D0", Slot = "36")]
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

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06003B23 RID: 15139 RVA: 0x001361E4 File Offset: 0x001343E4
		[Token(Token = "0x17000490")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B23")]
			[Address(RVA = "0x69E470", Offset = "0x69CA70", VA = "0x18069E470", Slot = "12")]
			get
			{
				return SceneType.Roof_Pool;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x001361F4 File Offset: 0x001343F4
		[Token(Token = "0x17000491")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003B24")]
			[Address(RVA = "0x79FAF0", Offset = "0x79E0F0", VA = "0x18079FAF0", Slot = "20")]
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

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06003B25 RID: 15141 RVA: 0x00136274 File Offset: 0x00134474
		[Token(Token = "0x17000492")]
		public override int MaxWave
		{
			[Token(Token = "0x6003B25")]
			[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "10")]
			get
			{
				return 30;
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06003B26 RID: 15142 RVA: 0x00136284 File Offset: 0x00134484
		[Token(Token = "0x17000493")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003B26")]
			[Address(RVA = "0x79F9D0", Offset = "0x79DFD0", VA = "0x18079F9D0", Slot = "22")]
			get
			{
				List<PlantType> list = new List();
				int size = list._size;
				int size2 = list._size;
				return list;
			}
		}

		// Token: 0x06003B27 RID: 15143 RVA: 0x001362C0 File Offset: 0x001344C0
		[Token(Token = "0x6003B27")]
		[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
		public BambooDragon()
		{
		}
	}
}
