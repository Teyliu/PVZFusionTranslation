using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C43 RID: 3139
	[Token(Token = "0x2000C43")]
	public class Round1_10 : AbyssLevelData
	{
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06004161 RID: 16737 RVA: 0x00157BE8 File Offset: 0x00155DE8
		[Token(Token = "0x1700052B")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x6004161")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_10;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06004162 RID: 16738 RVA: 0x00157BF8 File Offset: 0x00155DF8
		[Token(Token = "0x1700052C")]
		public override int MaxWave
		{
			[Token(Token = "0x6004162")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06004163 RID: 16739 RVA: 0x00157C08 File Offset: 0x00155E08
		[Token(Token = "0x1700052D")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6004163")]
			[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "12")]
			get
			{
				return SceneType.NightPool;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06004164 RID: 16740 RVA: 0x00157C18 File Offset: 0x00155E18
		[Token(Token = "0x1700052E")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6004164")]
			[Address(RVA = "0x87E760", Offset = "0x87CD60", VA = "0x18087E760", Slot = "20")]
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

		// Token: 0x06004165 RID: 16741 RVA: 0x00157C70 File Offset: 0x00155E70
		[Token(Token = "0x6004165")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Round1_10()
		{
		}
	}
}
