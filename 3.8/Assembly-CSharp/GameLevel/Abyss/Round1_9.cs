using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CDF RID: 3295
	[Token(Token = "0x2000CDF")]
	public class Round1_9 : AbyssLevelData
	{
		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060044FC RID: 17660 RVA: 0x0015DCEC File Offset: 0x0015BEEC
		[Token(Token = "0x170007A5")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x60044FC")]
			[Address(RVA = "0x3AC960", Offset = "0x3AAF60", VA = "0x1803AC960", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_9;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060044FD RID: 17661 RVA: 0x0015DCFC File Offset: 0x0015BEFC
		[Token(Token = "0x170007A6")]
		public override int MaxWave
		{
			[Token(Token = "0x60044FD")]
			[Address(RVA = "0x698EE0", Offset = "0x6974E0", VA = "0x180698EE0", Slot = "10")]
			get
			{
				return 30;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060044FE RID: 17662 RVA: 0x0015DD0C File Offset: 0x0015BF0C
		[Token(Token = "0x170007A7")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60044FE")]
			[Address(RVA = "0x69FFF0", Offset = "0x69E5F0", VA = "0x18069FFF0", Slot = "12")]
			get
			{
				return SceneType.BigPool;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x060044FF RID: 17663 RVA: 0x0015DD1C File Offset: 0x0015BF1C
		[Token(Token = "0x170007A8")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x60044FF")]
			[Address(RVA = "0x837F60", Offset = "0x836560", VA = "0x180837F60", Slot = "20")]
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
				return list;
			}
		}

		// Token: 0x06004500 RID: 17664 RVA: 0x0015DD94 File Offset: 0x0015BF94
		[Token(Token = "0x6004500")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Round1_9()
		{
		}
	}
}
