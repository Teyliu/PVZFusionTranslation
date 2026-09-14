using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000B1E RID: 2846
	[Token(Token = "0x2000B1E")]
	public class RandomMix4Level : RandomMix3Level
	{
		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06003B08 RID: 15112 RVA: 0x00136000 File Offset: 0x00134200
		[Token(Token = "0x17000425")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x6003B08")]
			[Address(RVA = "0x7F7DD0", Offset = "0x7F63D0", VA = "0x1807F7DD0", Slot = "42")]
			get
			{
				return ChallengeLevel.RandomMix4;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06003B09 RID: 15113 RVA: 0x00136014 File Offset: 0x00134214
		[Token(Token = "0x17000426")]
		public override string Name
		{
			[Token(Token = "0x6003B09")]
			[Address(RVA = "0x7F7DE0", Offset = "0x7F63E0", VA = "0x1807F7DE0", Slot = "8")]
			get
			{
				return "超级随机：命运";
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06003B0A RID: 15114 RVA: 0x00136028 File Offset: 0x00134228
		[Token(Token = "0x17000427")]
		public override SceneType SceneType
		{
			[Token(Token = "0x6003B0A")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x00136038 File Offset: 0x00134238
		[Token(Token = "0x6003B0B")]
		[Address(RVA = "0x7EA200", Offset = "0x7E8800", VA = "0x1807EA200")]
		public RandomMix4Level()
		{
		}
	}
}
