using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace GameLevel.Abyss
{
	// Token: 0x02000C48 RID: 3144
	[Token(Token = "0x2000C48")]
	public class Round1_5 : AbyssLevelData
	{
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600417A RID: 16762 RVA: 0x00157F1C File Offset: 0x0015611C
		[Token(Token = "0x1700053F")]
		protected override AbyssLevel Level
		{
			[Token(Token = "0x600417A")]
			[Address(RVA = "0x3F7A00", Offset = "0x3F6000", VA = "0x1803F7A00", Slot = "42")]
			get
			{
				return AbyssLevel.Round1_5;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600417B RID: 16763 RVA: 0x00157F2C File Offset: 0x0015612C
		[Token(Token = "0x17000540")]
		public override int MaxWave
		{
			[Token(Token = "0x600417B")]
			[Address(RVA = "0x3F63A0", Offset = "0x3F49A0", VA = "0x1803F63A0", Slot = "10")]
			get
			{
				return 10;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600417C RID: 16764 RVA: 0x00157F3C File Offset: 0x0015613C
		[Token(Token = "0x17000541")]
		public override SceneType SceneType
		{
			[Token(Token = "0x600417C")]
			[Address(RVA = "0x3E8E50", Offset = "0x3E7450", VA = "0x1803E8E50", Slot = "12")]
			get
			{
				return SceneType.Night;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600417D RID: 16765 RVA: 0x00157F4C File Offset: 0x0015614C
		[Token(Token = "0x17000542")]
		public override List<ZombieType> SpawnZombies
		{
			[Token(Token = "0x600417D")]
			[Address(RVA = "0x87FDF0", Offset = "0x87E3F0", VA = "0x18087FDF0", Slot = "20")]
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

		// Token: 0x0600417E RID: 16766 RVA: 0x00157FA4 File Offset: 0x001561A4
		[Token(Token = "0x600417E")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public Round1_5()
		{
		}
	}
}
