using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AF3 RID: 2803
	[Token(Token = "0x2000AF3")]
	public class NightSnow1 : NightSnowLevelData
	{
		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06003A49 RID: 14921 RVA: 0x0013388C File Offset: 0x00131A8C
		[Token(Token = "0x17000410")]
		public override int LevelNumber
		{
			[Token(Token = "0x6003A49")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "16")]
			get
			{
				return 10;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06003A4A RID: 14922 RVA: 0x0013389C File Offset: 0x00131A9C
		[Token(Token = "0x17000411")]
		public override int MaxWave
		{
			[Token(Token = "0x6003A4A")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06003A4B RID: 14923 RVA: 0x001338AC File Offset: 0x00131AAC
		[Token(Token = "0x17000412")]
		public override string Name
		{
			[Token(Token = "0x6003A4B")]
			[Address(RVA = "0x78B5F0", Offset = "0x789BF0", VA = "0x18078B5F0", Slot = "8")]
			get
			{
				return "雪原：回忆";
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06003A4C RID: 14924 RVA: 0x001338C0 File Offset: 0x00131AC0
		[Token(Token = "0x17000413")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003A4C")]
			[Address(RVA = "0x78B620", Offset = "0x789C20", VA = "0x18078B620", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x00133904 File Offset: 0x00131B04
		[Token(Token = "0x6003A4D")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public NightSnow1()
		{
		}
	}
}
