using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C41 RID: 3137
	[Token(Token = "0x2000C41")]
	public class Round1_12 : AbyssLevelData
	{
		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06004157 RID: 16727 RVA: 0x00157A78 File Offset: 0x00155C78
		[Token(Token = "0x17000523")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x6004157")]
			[Address(RVA = "0x3F72C0", Offset = "0x3F58C0", VA = "0x1803F72C0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_12;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06004158 RID: 16728 RVA: 0x00157A88 File Offset: 0x00155C88
		[Token(Token = "0x17000524")]
		public override int MaxWave
		{
			[Token(Token = "0x6004158")]
			[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "10")]
			get
			{
				return 30;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06004159 RID: 16729 RVA: 0x00157A98 File Offset: 0x00155C98
		[Token(Token = "0x17000525")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6004159")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
			get
			{
				return SceneType.NightPool;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600415A RID: 16730 RVA: 0x00157AA8 File Offset: 0x00155CA8
		[Token(Token = "0x17000526")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x600415A")]
			[Address(RVA = "0x87EC50", Offset = "0x87D250", VA = "0x18087EC50", Slot = "20")]
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

		// Token: 0x0600415B RID: 16731 RVA: 0x00157B28 File Offset: 0x00155D28
		[Token(Token = "0x600415B")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Round1_12()
		{
		}
	}
}
