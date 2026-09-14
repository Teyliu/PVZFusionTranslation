using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C40 RID: 3136
	[Token(Token = "0x2000C40")]
	public class Round1_13 : AbyssLevelData
	{
		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06004152 RID: 16722 RVA: 0x001579DC File Offset: 0x00155BDC
		[Token(Token = "0x1700051F")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x6004152")]
			[Address(RVA = "0x3F6DC0", Offset = "0x3F53C0", VA = "0x1803F6DC0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_13;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06004153 RID: 16723 RVA: 0x001579EC File Offset: 0x00155BEC
		[Token(Token = "0x17000520")]
		public override int MaxWave
		{
			[Token(Token = "0x6004153")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06004154 RID: 16724 RVA: 0x001579FC File Offset: 0x00155BFC
		[Token(Token = "0x17000521")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6004154")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "12")]
			get
			{
				return SceneType.Roof;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06004155 RID: 16725 RVA: 0x00157A0C File Offset: 0x00155C0C
		[Token(Token = "0x17000522")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6004155")]
			[Address(RVA = "0x87F010", Offset = "0x87D610", VA = "0x18087F010", Slot = "20")]
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

		// Token: 0x06004156 RID: 16726 RVA: 0x00157A64 File Offset: 0x00155C64
		[Token(Token = "0x6004156")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Round1_13()
		{
		}
	}
}
