using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CDE RID: 3294
	[Token(Token = "0x2000CDE")]
	public class Round1_10 : AbyssLevelData
	{
		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060044F7 RID: 17655 RVA: 0x0015DC50 File Offset: 0x0015BE50
		[Token(Token = "0x170007A1")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x60044F7")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_10;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060044F8 RID: 17656 RVA: 0x0015DC60 File Offset: 0x0015BE60
		[Token(Token = "0x170007A2")]
		public override int MaxWave
		{
			[Token(Token = "0x60044F8")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060044F9 RID: 17657 RVA: 0x0015DC70 File Offset: 0x0015BE70
		[Token(Token = "0x170007A3")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60044F9")]
			[Address(RVA = "0x3A98B0", Offset = "0x3A7EB0", VA = "0x1803A98B0", Slot = "12")]
			get
			{
				return SceneType.NightPool;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060044FA RID: 17658 RVA: 0x0015DC80 File Offset: 0x0015BE80
		[Token(Token = "0x170007A4")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x60044FA")]
			[Address(RVA = "0x836000", Offset = "0x834600", VA = "0x180836000", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				int size4 = list._size;
				int size5 = list._size;
				return list;
			}
		}

		// Token: 0x060044FB RID: 17659 RVA: 0x0015DCD8 File Offset: 0x0015BED8
		[Token(Token = "0x60044FB")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Round1_10()
		{
		}
	}
}
