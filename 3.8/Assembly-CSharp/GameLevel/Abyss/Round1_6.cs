using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CE2 RID: 3298
	[Token(Token = "0x2000CE2")]
	public class Round1_6 : AbyssLevelData
	{
		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x0600450B RID: 17675 RVA: 0x0015DED8 File Offset: 0x0015C0D8
		[Token(Token = "0x170007B1")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x600450B")]
			[Address(RVA = "0x3A5EC0", Offset = "0x3A44C0", VA = "0x1803A5EC0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_6;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x0600450C RID: 17676 RVA: 0x0015DEE8 File Offset: 0x0015C0E8
		[Token(Token = "0x170007B2")]
		public override int MaxWave
		{
			[Token(Token = "0x600450C")]
			[Address(RVA = "0x5644F0", Offset = "0x562AF0", VA = "0x1805644F0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x0600450D RID: 17677 RVA: 0x0015DEF8 File Offset: 0x0015C0F8
		[Token(Token = "0x170007B3")]
		public override SceneType SceneType
		{
			[Token(Token = "0x600450D")]
			[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "12")]
			get
			{
				return SceneType.Night_6;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x0600450E RID: 17678 RVA: 0x0015DF08 File Offset: 0x0015C108
		[Token(Token = "0x170007B4")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x600450E")]
			[Address(RVA = "0x8378B0", Offset = "0x835EB0", VA = "0x1808378B0", Slot = "20")]
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
				return list;
			}
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x0015DF70 File Offset: 0x0015C170
		[Token(Token = "0x600450F")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Round1_6()
		{
		}
	}
}
