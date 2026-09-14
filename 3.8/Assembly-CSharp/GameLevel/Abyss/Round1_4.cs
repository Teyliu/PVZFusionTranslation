using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CE4 RID: 3300
	[Token(Token = "0x2000CE4")]
	public class Round1_4 : AbyssLevelData
	{
		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06004515 RID: 17685 RVA: 0x0015E020 File Offset: 0x0015C220
		[Token(Token = "0x170007B9")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x6004515")]
			[Address(RVA = "0x3AD3E0", Offset = "0x3AB9E0", VA = "0x1803AD3E0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_4;
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06004516 RID: 17686 RVA: 0x0015E030 File Offset: 0x0015C230
		[Token(Token = "0x170007BA")]
		public override int MaxWave
		{
			[Token(Token = "0x6004516")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06004517 RID: 17687 RVA: 0x0015E040 File Offset: 0x0015C240
		[Token(Token = "0x170007BB")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6004517")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "12")]
			get
			{
				return SceneType.Night;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06004518 RID: 17688 RVA: 0x0015E050 File Offset: 0x0015C250
		[Token(Token = "0x170007BC")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6004518")]
			[Address(RVA = "0x837520", Offset = "0x835B20", VA = "0x180837520", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06004519 RID: 17689 RVA: 0x0015E098 File Offset: 0x0015C298
		[Token(Token = "0x6004519")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Round1_4()
		{
		}
	}
}
