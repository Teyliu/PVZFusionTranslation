using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000ADE RID: 2782
	[Token(Token = "0x2000ADE")]
	public class RandomMix4Level : RandomMix3Level
	{
		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060039C4 RID: 14788 RVA: 0x00130F20 File Offset: 0x0012F120
		[Token(Token = "0x170003DD")]
		protected override ChallengeLevel Level
		{
			[Token(Token = "0x60039C4")]
			[Address(RVA = "0x791780", Offset = "0x78FD80", VA = "0x180791780", Slot = "42")]
			get
			{
				return ChallengeLevel.RandomMix4;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060039C5 RID: 14789 RVA: 0x00130F34 File Offset: 0x0012F134
		[Token(Token = "0x170003DE")]
		public override string Name
		{
			[Token(Token = "0x60039C5")]
			[Address(RVA = "0x791790", Offset = "0x78FD90", VA = "0x180791790", Slot = "8")]
			get
			{
				return "超级随机：命运";
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060039C6 RID: 14790 RVA: 0x00130F48 File Offset: 0x0012F148
		[Token(Token = "0x170003DF")]
		public override SceneType SceneType
		{
			[Token(Token = "0x60039C6")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "12")]
			get
			{
				return SceneType.Pool;
			}
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x00130F58 File Offset: 0x0012F158
		[Token(Token = "0x60039C7")]
		[Address(RVA = "0x783350", Offset = "0x781950", VA = "0x180783350")]
		public RandomMix4Level()
		{
		}
	}
}
