using System;
using Cpp2IlInjected;
using UnityEngine;

namespace RhythmGame
{
	// Token: 0x02000A96 RID: 2710
	[Token(Token = "0x2000A96")]
	[Serializable]
	public class PlayerSettings
	{
		// Token: 0x060037B2 RID: 14258 RVA: 0x0012AC8C File Offset: 0x00128E8C
		[Token(Token = "0x60037B2")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public PlayerSettings()
		{
		}

		// Token: 0x04002B34 RID: 11060
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002B34")]
		public KeyCode k1;

		// Token: 0x04002B35 RID: 11061
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4002B35")]
		public KeyCode k2;

		// Token: 0x04002B36 RID: 11062
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002B36")]
		public KeyCode k3;

		// Token: 0x04002B37 RID: 11063
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4002B37")]
		public KeyCode k4;

		// Token: 0x04002B38 RID: 11064
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002B38")]
		public int clickDelayMs;
	}
}
