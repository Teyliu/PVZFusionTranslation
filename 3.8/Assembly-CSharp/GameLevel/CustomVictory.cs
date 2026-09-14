using System;
using Cpp2IlInjected;

namespace GameLevel
{
	// Token: 0x02000AB9 RID: 2745
	[Token(Token = "0x2000AB9")]
	public class CustomVictory : BoardVictory
	{
		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060038DA RID: 14554 RVA: 0x0012D588 File Offset: 0x0012B788
		[Token(Token = "0x1700039B")]
		public override VictoryType VictoryType
		{
			[Token(Token = "0x60038DA")]
			[Address(RVA = "0x3AA3B0", Offset = "0x3A89B0", VA = "0x1803AA3B0", Slot = "4")]
			get
			{
				return VictoryType.Custom;
			}
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x0012D598 File Offset: 0x0012B798
		[Token(Token = "0x60038DB")]
		[Address(RVA = "0x787C40", Offset = "0x786240", VA = "0x180787C40")]
		public CustomVictory(Func<bool> func)
		{
			this.condition = func;
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x0012D5B4 File Offset: 0x0012B7B4
		[Token(Token = "0x60038DC")]
		[Address(RVA = "0x787C20", Offset = "0x786220", VA = "0x180787C20", Slot = "6")]
		protected override bool Check(Board board)
		{
			if (this.condition != (ulong)0L)
			{
				Func<bool> func = this.condition;
			}
			return false;
		}

		// Token: 0x04002A9D RID: 10909
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002A9D")]
		private readonly Func<bool> condition;
	}
}
