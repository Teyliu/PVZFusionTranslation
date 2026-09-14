using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C46 RID: 3142
	[Token(Token = "0x2000C46")]
	public class Round1_7 : AbyssLevelData
	{
		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06004170 RID: 16752 RVA: 0x00157DE4 File Offset: 0x00155FE4
		[Token(Token = "0x17000537")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x6004170")]
			[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_7;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06004171 RID: 16753 RVA: 0x00157DF4 File Offset: 0x00155FF4
		[Token(Token = "0x17000538")]
		public override int MaxWave
		{
			[Token(Token = "0x6004171")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06004172 RID: 16754 RVA: 0x00157E04 File Offset: 0x00156004
		[Token(Token = "0x17000539")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6004172")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06004173 RID: 16755 RVA: 0x00157E14 File Offset: 0x00156014
		[Token(Token = "0x1700053A")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6004173")]
			[Address(RVA = "0x8802E0", Offset = "0x87E8E0", VA = "0x1808802E0", Slot = "20")]
			get
			{
				List<ZombieType> list = new List();
				int size = list._size;
				int size2 = list._size;
				int size3 = list._size;
				return list;
			}
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x00157E5C File Offset: 0x0015605C
		[Token(Token = "0x6004174")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Round1_7()
		{
		}
	}
}
