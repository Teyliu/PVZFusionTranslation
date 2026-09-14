using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000CE3 RID: 3299
	[Token(Token = "0x2000CE3")]
	public class Round1_5 : AbyssLevelData
	{
		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06004510 RID: 17680 RVA: 0x0015DF84 File Offset: 0x0015C184
		[Token(Token = "0x170007B5")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x6004510")]
			[Address(RVA = "0x3ABC00", Offset = "0x3AA200", VA = "0x1803ABC00", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_5;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06004511 RID: 17681 RVA: 0x0015DF94 File Offset: 0x0015C194
		[Token(Token = "0x170007B6")]
		public override int MaxWave
		{
			[Token(Token = "0x6004511")]
			[Address(RVA = "0x3AA5A0", Offset = "0x3A8BA0", VA = "0x1803AA5A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06004512 RID: 17682 RVA: 0x0015DFA4 File Offset: 0x0015C1A4
		[Token(Token = "0x170007B7")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6004512")]
			[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "12")]
			get
			{
				return SceneType.Night;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06004513 RID: 17683 RVA: 0x0015DFB4 File Offset: 0x0015C1B4
		[Token(Token = "0x170007B8")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6004513")]
			[Address(RVA = "0x837690", Offset = "0x835C90", VA = "0x180837690", Slot = "20")]
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

		// Token: 0x06004514 RID: 17684 RVA: 0x0015E00C File Offset: 0x0015C20C
		[Token(Token = "0x6004514")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public Round1_5()
		{
		}
	}
}
