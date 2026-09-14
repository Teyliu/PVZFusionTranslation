using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C3F RID: 3135
	[Token(Token = "0x2000C3F")]
	public class Round1_14 : AbyssLevelData
	{
		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600414D RID: 16717 RVA: 0x00157928 File Offset: 0x00155B28
		[Token(Token = "0x1700051B")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x600414D")]
			[Address(RVA = "0x714BD0", Offset = "0x7131D0", VA = "0x180714BD0", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_14;
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600414E RID: 16718 RVA: 0x00157938 File Offset: 0x00155B38
		[Token(Token = "0x1700051C")]
		public override int MaxWave
		{
			[Token(Token = "0x600414E")]
			[Address(RVA = "0x5C7DA0", Offset = "0x5C63A0", VA = "0x1805C7DA0", Slot = "10")]
			get
			{
				return 20;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600414F RID: 16719 RVA: 0x00157948 File Offset: 0x00155B48
		[Token(Token = "0x1700051D")]
		public override SceneType SceneType
		{
			[Token(Token = "0x600414F")]
			[Address(RVA = "0x3F9250", Offset = "0x3F7850", VA = "0x1803F9250", Slot = "12")]
			get
			{
				return SceneType.Roof;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06004150 RID: 16720 RVA: 0x00157958 File Offset: 0x00155B58
		[Token(Token = "0x1700051E")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x6004150")]
			[Address(RVA = "0x87F230", Offset = "0x87D830", VA = "0x18087F230", Slot = "20")]
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

		// Token: 0x06004151 RID: 16721 RVA: 0x001579C8 File Offset: 0x00155BC8
		[Token(Token = "0x6004151")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Round1_14()
		{
		}
	}
}
