using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AFB RID: 2811
	[Token(Token = "0x2000AFB")]
	public class TravelIZ : SuperIZLevelData
	{
		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06003A6E RID: 14958 RVA: 0x00134114 File Offset: 0x00132314
		[Token(Token = "0x17000424")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003A6E")]
			[Address(RVA = "0x795570", Offset = "0x793B70", VA = "0x180795570", Slot = "42")]
			get
			{
				return ChallengeLevel.SuperIZ;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06003A6F RID: 14959 RVA: 0x00134128 File Offset: 0x00132328
		[Token(Token = "0x17000425")]
		public override string Name
		{
			[Token(Token = "0x6003A6F")]
			[Address(RVA = "0x795580", Offset = "0x793B80", VA = "0x180795580", Slot = "8")]
			get
			{
				return "超级僵尸大战";
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06003A70 RID: 14960 RVA: 0x0013413C File Offset: 0x0013233C
		[Token(Token = "0x17000426")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003A70")]
			[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "12")]
			get
			{
				return SceneType.Night_6;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06003A71 RID: 14961 RVA: 0x0013414C File Offset: 0x0013234C
		[Token(Token = "0x17000427")]
		public override List<ZombieType> PreselectCards_zombie
		{
			[Token(Token = "0x6003A71")]
			[Address(RVA = "0x7955B0", Offset = "0x793BB0", VA = "0x1807955B0", Slot = "24")]
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

		// Token: 0x06003A72 RID: 14962 RVA: 0x001341C8 File Offset: 0x001323C8
		[Token(Token = "0x6003A72")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public TravelIZ()
		{
		}
	}
}
