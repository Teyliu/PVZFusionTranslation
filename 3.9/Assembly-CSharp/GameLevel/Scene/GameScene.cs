using System;
using Cpp2IlInjected;

namespace GameLevel.Scene
{
	// Token: 0x02000C35 RID: 3125
	[Token(Token = "0x2000C35")]
	public abstract class GameScene
	{
		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600411E RID: 16670
		[Token(Token = "0x17000505")]
		public abstract string Name
		{
			[Token(Token = "0x600411E")]
			[Address(Slot = "4")]
			get;
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x0600411F RID: 16671
		[Token(Token = "0x17000506")]
		public abstract SceneType SceneType
		{
			[Token(Token = "0x600411F")]
			[Address(Slot = "5")]
			get;
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06004120 RID: 16672
		[Token(Token = "0x17000507")]
		public abstract MusicType MusicType
		{
			[Token(Token = "0x6004120")]
			[Address(Slot = "6")]
			get;
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06004121 RID: 16673
		[Token(Token = "0x17000508")]
		public abstract ZombieType SceneLeader
		{
			[Token(Token = "0x6004121")]
			[Address(Slot = "7")]
			get;
		}

		// Token: 0x06004122 RID: 16674
		[Token(Token = "0x6004122")]
		[Address(Slot = "8")]
		public abstract void SceneSetting(Board board);

		// Token: 0x06004123 RID: 16675 RVA: 0x00157304 File Offset: 0x00155504
		[Token(Token = "0x6004123")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		protected GameScene()
		{
		}
	}
}
