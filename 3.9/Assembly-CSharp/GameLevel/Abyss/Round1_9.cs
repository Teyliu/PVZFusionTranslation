using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C44 RID: 3140
	[Token(Token = "0x2000C44")]
	public class Round1_9 : AbyssLevelData
	{
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06004166 RID: 16742 RVA: 0x00157C84 File Offset: 0x00155E84
		[Token(Token = "0x1700052F")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x6004166")]
			[Address(RVA = "0x3F87C0", Offset = "0x3F6DC0", VA = "0x1803F87C0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_9;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06004167 RID: 16743 RVA: 0x00157C94 File Offset: 0x00155E94
		[Token(Token = "0x17000530")]
		public override int MaxWave
		{
			[Token(Token = "0x6004167")]
			[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "10")]
			get
			{
				return 30;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06004168 RID: 16744 RVA: 0x00157CA4 File Offset: 0x00155EA4
		[Token(Token = "0x17000531")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6004168")]
			[Address(RVA = "0x71A150", Offset = "0x718750", VA = "0x18071A150", Slot = "12")]
			get
			{
				return SceneType.BigPool;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06004169 RID: 16745 RVA: 0x00157CB4 File Offset: 0x00155EB4
		[Token(Token = "0x17000532")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6004169")]
			[Address(RVA = "0x8806C0", Offset = "0x87ECC0", VA = "0x1808806C0", Slot = "20")]
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

		// Token: 0x0600416A RID: 16746 RVA: 0x00157D2C File Offset: 0x00155F2C
		[Token(Token = "0x600416A")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Round1_9()
		{
		}
	}
}
