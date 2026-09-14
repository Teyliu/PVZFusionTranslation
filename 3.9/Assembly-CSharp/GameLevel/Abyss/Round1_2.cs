using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C4B RID: 3147
	[Token(Token = "0x2000C4B")]
	public class Round1_2 : AbyssLevelData
	{
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06004189 RID: 16777 RVA: 0x001580D8 File Offset: 0x001562D8
		[Token(Token = "0x1700054B")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x6004189")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_2;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600418A RID: 16778 RVA: 0x001580E8 File Offset: 0x001562E8
		[Token(Token = "0x1700054C")]
		public override int MaxWave
		{
			[Token(Token = "0x600418A")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600418B RID: 16779 RVA: 0x001580F8 File Offset: 0x001562F8
		[Token(Token = "0x1700054D")]
		public override SceneType SceneType
		{
			[Token(Token = "0x600418B")]
			[Address(RVA = "0x3F2A00", Offset = "0x3F1000", VA = "0x1803F2A00", Slot = "12")]
			get
			{
				return SceneType.Day;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x0600418C RID: 16780 RVA: 0x00158110 File Offset: 0x00156310
		[Token(Token = "0x1700054E")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x600418C")]
			[Address(RVA = "0x87F940", Offset = "0x87DF40", VA = "0x18087F940", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x00158158 File Offset: 0x00156358
		[Token(Token = "0x600418D")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Round1_2()
		{
		}
	}
}
