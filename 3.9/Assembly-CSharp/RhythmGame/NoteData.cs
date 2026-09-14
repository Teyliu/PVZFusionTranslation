using System;
using Cpp2IlInjected;

namespace RhythmGame
{
	// Token: 0x02000A98 RID: 2712
	[Token(Token = "0x2000A98")]
	[Serializable]
	public class NoteData
	{
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060037B4 RID: 14260 RVA: 0x0012ACEC File Offset: 0x00128EEC
		[Token(Token = "0x1700028E")]
		public float duration
		{
			[Token(Token = "0x60037B4")]
			[Address(RVA = "0x7D3700", Offset = "0x7D1D00", VA = "0x1807D3700")]
			get
			{
				return this.endTime;
			}
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x0012AD00 File Offset: 0x00128F00
		[Token(Token = "0x60037B5")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public NoteData()
		{
		}

		// Token: 0x04002B3F RID: 11071
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002B3F")]
		public float time;

		// Token: 0x04002B40 RID: 11072
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4002B40")]
		public int track;

		// Token: 0x04002B41 RID: 11073
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002B41")]
		public NoteType type;

		// Token: 0x04002B42 RID: 11074
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4002B42")]
		[NonSerialized]
		public bool spawned;

		// Token: 0x04002B43 RID: 11075
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002B43")]
		public float endTime;
	}
}
