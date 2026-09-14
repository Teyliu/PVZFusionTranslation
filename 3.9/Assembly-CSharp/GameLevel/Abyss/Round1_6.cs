using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C47 RID: 3143
	[Token(Token = "0x2000C47")]
	public class Round1_6 : AbyssLevelData
	{
		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06004175 RID: 16757 RVA: 0x00157E70 File Offset: 0x00156070
		[Token(Token = "0x1700053B")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x6004175")]
			[Address(RVA = "0x3F1E50", Offset = "0x3F0450", VA = "0x1803F1E50", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_6;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06004176 RID: 16758 RVA: 0x00157E80 File Offset: 0x00156080
		[Token(Token = "0x1700053C")]
		public override int MaxWave
		{
			[Token(Token = "0x6004176")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06004177 RID: 16759 RVA: 0x00157E90 File Offset: 0x00156090
		[Token(Token = "0x1700053D")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6004177")]
			[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "12")]
			get
			{
				return SceneType.Night_6;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06004178 RID: 16760 RVA: 0x00157EA0 File Offset: 0x001560A0
		[Token(Token = "0x1700053E")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6004178")]
			[Address(RVA = "0x880010", Offset = "0x87E610", VA = "0x180880010", Slot = "20")]
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

		// Token: 0x06004179 RID: 16761 RVA: 0x00157F08 File Offset: 0x00156108
		[Token(Token = "0x6004179")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Round1_6()
		{
		}
	}
}
