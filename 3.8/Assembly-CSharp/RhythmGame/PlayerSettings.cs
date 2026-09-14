using System;
using Cpp2IlInjected;
using UnityEngine;

namespace RhythmGame
{
	// Token: 0x02000A56 RID: 2646
	[Token(Token = "0x2000A56")]
	[Serializable]
	public class PlayerSettings
	{
		// Token: 0x0600366E RID: 13934 RVA: 0x00125A0C File Offset: 0x00123C0C
		[Token(Token = "0x600366E")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public PlayerSettings()
		{
		}

		// Token: 0x040029C1 RID: 10689
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40029C1")]
		public KeyCode k1;

		// Token: 0x040029C2 RID: 10690
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40029C2")]
		public KeyCode k2;

		// Token: 0x040029C3 RID: 10691
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40029C3")]
		public KeyCode k3;

		// Token: 0x040029C4 RID: 10692
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40029C4")]
		public KeyCode k4;

		// Token: 0x040029C5 RID: 10693
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40029C5")]
		public int clickDelayMs;
	}
}
