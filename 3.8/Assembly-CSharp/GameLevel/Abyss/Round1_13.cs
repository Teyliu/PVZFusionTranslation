using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CDB RID: 3291
	[Token(Token = "0x2000CDB")]
	public class Round1_13 : AbyssLevelData
	{
		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060044E8 RID: 17640 RVA: 0x0015DA44 File Offset: 0x0015BC44
		[Token(Token = "0x17000795")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x60044E8")]
			[Address(RVA = "0x3AAFC0", Offset = "0x3A95C0", VA = "0x1803AAFC0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_13;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060044E9 RID: 17641 RVA: 0x0015DA54 File Offset: 0x0015BC54
		[Token(Token = "0x17000796")]
		public override int MaxWave
		{
			[Token(Token = "0x60044E9")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060044EA RID: 17642 RVA: 0x0015DA64 File Offset: 0x0015BC64
		[Token(Token = "0x17000797")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60044EA")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "12")]
			get
			{
				return SceneType.Roof;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060044EB RID: 17643 RVA: 0x0015DA74 File Offset: 0x0015BC74
		[Token(Token = "0x17000798")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x60044EB")]
			[Address(RVA = "0x8368B0", Offset = "0x834EB0", VA = "0x1808368B0", Slot = "20")]
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

		// Token: 0x060044EC RID: 17644 RVA: 0x0015DACC File Offset: 0x0015BCCC
		[Token(Token = "0x60044EC")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Round1_13()
		{
		}
	}
}
