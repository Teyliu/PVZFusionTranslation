using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AF9 RID: 2809
	[Token(Token = "0x2000AF9")]
	public class CustomVictory : BoardVictory
	{
		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06003A1E RID: 14878 RVA: 0x001327B0 File Offset: 0x001309B0
		[Token(Token = "0x170003E3")]
		public override VictoryType VictoryType
		{
			[Token(Token = "0x6003A1E")]
			[Address(RVA = "0x3F61B0", Offset = "0x3F47B0", VA = "0x1803F61B0", Slot = "4")]
			get
			{
				return VictoryType.Custom;
			}
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x001327C0 File Offset: 0x001309C0
		[Token(Token = "0x6003A1F")]
		[Address(RVA = "0x7EE660", Offset = "0x7ECC60", VA = "0x1807EE660")]
		public CustomVictory(Func<bool> func)
		{
			this.condition = func;
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x001327DC File Offset: 0x001309DC
		[Token(Token = "0x6003A20")]
		[Address(RVA = "0x7EE640", Offset = "0x7ECC40", VA = "0x1807EE640", Slot = "6")]
		protected override bool Check(Board board)
		{
			if (this.condition != (ulong)0L)
			{
				Func<bool> func = this.condition;
			}
			return false;
		}

		// Token: 0x04002C10 RID: 11280
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002C10")]
		private readonly Func<bool> condition;
	}
}
