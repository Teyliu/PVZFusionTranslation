using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C3E RID: 3134
	[Token(Token = "0x2000C3E")]
	public class Round1_15 : AbyssLevelData
	{
		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06004148 RID: 16712 RVA: 0x00157874 File Offset: 0x00155A74
		[Token(Token = "0x17000517")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x6004148")]
			[Address(RVA = "0x5D3550", Offset = "0x5D1B50", VA = "0x1805D3550", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_15;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06004149 RID: 16713 RVA: 0x00157884 File Offset: 0x00155A84
		[Token(Token = "0x17000518")]
		public override int MaxWave
		{
			[Token(Token = "0x6004149")]
			[Address(RVA = "0x712FE0", Offset = "0x7115E0", VA = "0x180712FE0", Slot = "10")]
			get
			{
				return 30;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x0600414A RID: 16714 RVA: 0x00157894 File Offset: 0x00155A94
		[Token(Token = "0x17000519")]
		public override SceneType SceneType
		{
			[Token(Token = "0x600414A")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "12")]
			get
			{
				return SceneType.Roof;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600414B RID: 16715 RVA: 0x001578A4 File Offset: 0x00155AA4
		[Token(Token = "0x1700051A")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x600414B")]
			[Address(RVA = "0x87F550", Offset = "0x87DB50", VA = "0x18087F550", Slot = "20")]
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
				return list;
			}
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x00157914 File Offset: 0x00155B14
		[Token(Token = "0x600414C")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Round1_15()
		{
		}
	}
}
