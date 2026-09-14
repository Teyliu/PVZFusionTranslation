using System;
using Cpp2IlInjected;

namespace GameLevel.Scene
{
	// Token: 0x02000BF3 RID: 3059
	[Token(Token = "0x2000BF3")]
	public abstract class GameScene
	{
		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06003FCD RID: 16333
		[Token(Token = "0x170004B5")]
		public abstract string Name
		{
			[Token(Token = "0x6003FCD")]
			[Address(Slot = "4")]
			get;
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06003FCE RID: 16334
		[Token(Token = "0x170004B6")]
		public abstract SceneType SceneType
		{
			[Token(Token = "0x6003FCE")]
			[Address(Slot = "5")]
			get;
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06003FCF RID: 16335
		[Token(Token = "0x170004B7")]
		public abstract MusicType MusicType
		{
			[Token(Token = "0x6003FCF")]
			[Address(Slot = "6")]
			get;
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06003FD0 RID: 16336
		[Token(Token = "0x170004B8")]
		public abstract ZombieType SceneLeader
		{
			[Token(Token = "0x6003FD0")]
			[Address(Slot = "7")]
			get;
		}

		// Token: 0x06003FD1 RID: 16337
		[Token(Token = "0x6003FD1")]
		[Address(Slot = "8")]
		public abstract void SceneSetting(Board board);

		// Token: 0x06003FD2 RID: 16338 RVA: 0x001520D4 File Offset: 0x001502D4
		[Token(Token = "0x6003FD2")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		protected GameScene()
		{
		}
	}
}
