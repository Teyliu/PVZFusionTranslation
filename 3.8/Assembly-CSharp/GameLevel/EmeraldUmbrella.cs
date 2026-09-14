using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B0F RID: 2831
	[Token(Token = "0x2000B0F")]
	public class EmeraldUmbrella : TravelAdvantureLevelData
	{
		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06003B08 RID: 15112 RVA: 0x00135CD4 File Offset: 0x00133ED4
		[Token(Token = "0x17000480")]
		protected override TravelAdvanture Level
		{
			[Token(Token = "0x6003B08")]
			[Address(RVA = "0x69B2B0", Offset = "0x6998B0", VA = "0x18069B2B0", Slot = "42")]
			get
			{
				return TravelAdvanture.EmeraldUmbrella;
			}
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x00135CE4 File Offset: 0x00133EE4
		[Token(Token = "0x6003B09")]
		[Address(RVA = "0x7A3280", Offset = "0x7A1880", VA = "0x1807A3280", Slot = "39")]
		public override void OnBoardAwake(Board board)
		{
			base.OnBoardAwake(board);
			board.config.startTip = "超级伞 + 菜伞\n使用西瓜、卷心菜进行亚种切换";
			throw new NullReferenceException();
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x00135D10 File Offset: 0x00133F10
		[Token(Token = "0x6003B0A")]
		[Address(RVA = "0x7A3300", Offset = "0x7A1900", VA = "0x1807A3300", Slot = "36")]
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

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06003B0B RID: 15115 RVA: 0x00135D5C File Offset: 0x00133F5C
		[Token(Token = "0x17000481")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B0B")]
			[Address(RVA = "0x69E470", Offset = "0x69CA70", VA = "0x18069E470", Slot = "12")]
			get
			{
				return SceneType.Roof_Pool;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06003B0C RID: 15116 RVA: 0x00135D6C File Offset: 0x00133F6C
		[Token(Token = "0x17000482")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003B0C")]
			[Address(RVA = "0x7A35D0", Offset = "0x7A1BD0", VA = "0x1807A35D0", Slot = "20")]
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

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06003B0D RID: 15117 RVA: 0x00135DEC File Offset: 0x00133FEC
		[Token(Token = "0x17000483")]
		public override int MaxWave
		{
			[Token(Token = "0x6003B0D")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06003B0E RID: 15118 RVA: 0x00135DFC File Offset: 0x00133FFC
		[Token(Token = "0x17000484")]
		public override List<PlantType> PreselectCards
		{
			[Token(Token = "0x6003B0E")]
			[Address(RVA = "0x7A3400", Offset = "0x7A1A00", VA = "0x1807A3400", Slot = "22")]
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

		// Token: 0x06003B0F RID: 15119 RVA: 0x00135E48 File Offset: 0x00134048
		[Token(Token = "0x6003B0F")]
		[Address(RVA = "0x6FAF20", Offset = "0x6F9520", VA = "0x1806FAF20")]
		public EmeraldUmbrella()
		{
		}
	}
}
