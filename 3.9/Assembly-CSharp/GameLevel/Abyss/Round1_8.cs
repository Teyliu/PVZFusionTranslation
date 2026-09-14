using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C45 RID: 3141
	[Token(Token = "0x2000C45")]
	public class Round1_8 : AbyssLevelData
	{
		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600416B RID: 16747 RVA: 0x00157D40 File Offset: 0x00155F40
		[Token(Token = "0x17000533")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x600416B")]
			[Address(RVA = "0x3F6B70", Offset = "0x3F5170", VA = "0x1803F6B70", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_8;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x0600416C RID: 16748 RVA: 0x00157D50 File Offset: 0x00155F50
		[Token(Token = "0x17000534")]
		public override int MaxWave
		{
			[Token(Token = "0x600416C")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x0600416D RID: 16749 RVA: 0x00157D60 File Offset: 0x00155F60
		[Token(Token = "0x17000535")]
		public override SceneType SceneType
		{
			[Token(Token = "0x600416D")]
			[Address(RVA = "0x716AF0", Offset = "0x7150F0", VA = "0x180716AF0", Slot = "12")]
			get
			{
				return SceneType.ReversalPool;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x0600416E RID: 16750 RVA: 0x00157D70 File Offset: 0x00155F70
		[Token(Token = "0x17000536")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x600416E")]
			[Address(RVA = "0x880450", Offset = "0x87EA50", VA = "0x180880450", Slot = "20")]
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

		// Token: 0x0600416F RID: 16751 RVA: 0x00157DD0 File Offset: 0x00155FD0
		[Token(Token = "0x600416F")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Round1_8()
		{
		}
	}
}
