using System;
using Cpp2IlInjected;

namespace GameLevel.Scene
{
	// Token: 0x02000BF6 RID: 3062
	[Token(Token = "0x2000BF6")]
	public class NightWinter : GameScene
	{
		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06003FD8 RID: 16344 RVA: 0x0015218C File Offset: 0x0015038C
		[Token(Token = "0x170004B9")]
		public override string Name
		{
			[Token(Token = "0x6003FD8")]
			[Address(RVA = "0x80BD10", Offset = "0x80A310", VA = "0x18080BD10", Slot = "4")]
			get
			{
				return "冬夜";
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06003FD9 RID: 16345 RVA: 0x001521A0 File Offset: 0x001503A0
		[Token(Token = "0x170004BA")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003FD9")]
			[Address(RVA = "0x69D930", Offset = "0x69BF30", VA = "0x18069D930", Slot = "5")]
			get
			{
				return SceneType.NightWinter;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06003FDA RID: 16346 RVA: 0x001521B0 File Offset: 0x001503B0
		[Token(Token = "0x170004BB")]
		public override MusicType MusicType
		{
			[Token(Token = "0x6003FDA")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "6")]
			get
			{
				return MusicType.Day;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06003FDB RID: 16347 RVA: 0x001521C0 File Offset: 0x001503C0
		[Token(Token = "0x170004BC")]
		public override ZombieType SceneLeader
		{
			[Token(Token = "0x6003FDB")]
			[Address(RVA = "0x80BD40", Offset = "0x80A340", VA = "0x18080BD40", Slot = "7")]
			get
			{
				return ZombieType.UltimateSnowZombie;
			}
		}

		// Token: 0x06003FDC RID: 16348 RVA: 0x001521D4 File Offset: 0x001503D4
		[Token(Token = "0x6003FDC")]
		[Address(RVA = "0x80BCE0", Offset = "0x80A2E0", VA = "0x18080BCE0", Slot = "8")]
		public override void SceneSetting(Board board)
		{
			board.theSun = (int)((ulong)150L);
			board.boardTag.isNight = true;
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x00152200 File Offset: 0x00150400
		[Token(Token = "0x6003FDD")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public NightWinter()
		{
		}
	}
}
