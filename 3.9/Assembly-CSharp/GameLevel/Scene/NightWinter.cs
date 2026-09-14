using System;
using Cpp2IlInjected;

namespace GameLevel.Scene
{
	// Token: 0x02000C38 RID: 3128
	[Token(Token = "0x2000C38")]
	public class NightWinter : GameScene
	{
		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06004129 RID: 16681 RVA: 0x001573BC File Offset: 0x001555BC
		[Token(Token = "0x17000509")]
		public override string Name
		{
			[Token(Token = "0x6004129")]
			[Address(RVA = "0x87E6B0", Offset = "0x87CCB0", VA = "0x18087E6B0", Slot = "4")]
			get
			{
				return "冬夜";
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x0600412A RID: 16682 RVA: 0x001573D0 File Offset: 0x001555D0
		[Token(Token = "0x1700050A")]
		public override SceneType SceneType
		{
			[Token(Token = "0x600412A")]
			[Address(RVA = "0x717A90", Offset = "0x716090", VA = "0x180717A90", Slot = "5")]
			get
			{
				return SceneType.NightWinter;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600412B RID: 16683 RVA: 0x001573E0 File Offset: 0x001555E0
		[Token(Token = "0x1700050B")]
		public override MusicType MusicType
		{
			[Token(Token = "0x600412B")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "6")]
			get
			{
				return MusicType.Day;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x001573F0 File Offset: 0x001555F0
		[Token(Token = "0x1700050C")]
		public override ZombieType SceneLeader
		{
			[Token(Token = "0x600412C")]
			[Address(RVA = "0x87E6E0", Offset = "0x87CCE0", VA = "0x18087E6E0", Slot = "7")]
			get
			{
				return ZombieType.UltimateSnowZombie;
			}
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x00157404 File Offset: 0x00155604
		[Token(Token = "0x600412D")]
		[Address(RVA = "0x87E680", Offset = "0x87CC80", VA = "0x18087E680", Slot = "8")]
		public override void SceneSetting(Board board)
		{
			board.theSun = (int)((ulong)150L);
			board.boardTag.isNight = true;
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x00157430 File Offset: 0x00155630
		[Token(Token = "0x600412E")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public NightWinter()
		{
		}
	}
}
