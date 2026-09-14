using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B33 RID: 2867
	[Token(Token = "0x2000B33")]
	public class NightSnow1 : NightSnowLevelData
	{
		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06003B8D RID: 15245 RVA: 0x001388D0 File Offset: 0x00136AD0
		[Token(Token = "0x17000458")]
		public override int LevelNumber
		{
			[Token(Token = "0x6003B8D")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "16")]
			get
			{
				return 10;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06003B8E RID: 15246 RVA: 0x001388E0 File Offset: 0x00136AE0
		[Token(Token = "0x17000459")]
		public override int MaxWave
		{
			[Token(Token = "0x6003B8E")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06003B8F RID: 15247 RVA: 0x001388F0 File Offset: 0x00136AF0
		[Token(Token = "0x1700045A")]
		public override string Name
		{
			[Token(Token = "0x6003B8F")]
			[Address(RVA = "0x7F1C70", Offset = "0x7F0270", VA = "0x1807F1C70", Slot = "8")]
			get
			{
				return "雪原：回忆";
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06003B90 RID: 15248 RVA: 0x00138904 File Offset: 0x00136B04
		[Token(Token = "0x1700045B")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6003B90")]
			[Address(RVA = "0x7F1CA0", Offset = "0x7F02A0", VA = "0x1807F1CA0", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x00138948 File Offset: 0x00136B48
		[Token(Token = "0x6003B91")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public NightSnow1()
		{
		}
	}
}
