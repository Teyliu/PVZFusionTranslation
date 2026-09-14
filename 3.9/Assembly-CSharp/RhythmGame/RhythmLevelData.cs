using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace RhythmGame
{
	// Token: 0x02000A97 RID: 2711
	[Token(Token = "0x2000A97")]
	[Serializable]
	public class RhythmLevelData
	{
		// Token: 0x060037B3 RID: 14259 RVA: 0x0012ACA0 File Offset: 0x00128EA0
		[Token(Token = "0x60037B3")]
		[Address(RVA = "0x7DAF50", Offset = "0x7D9550", VA = "0x1807DAF50")]
		public RhythmLevelData()
		{
			List<NoteData> list = new List();
			this.notes = list;
			base..ctor();
		}

		// Token: 0x04002B39 RID: 11065
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002B39")]
		public MusicType musicType = (MusicType)((ulong)13L);

		// Token: 0x04002B3A RID: 11066
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002B3A")]
		public string musicName = "song";

		// Token: 0x04002B3B RID: 11067
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002B3B")]
		public float fallTime = 1f;

		// Token: 0x04002B3C RID: 11068
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4002B3C")]
		public float bpm = 160f;

		// Token: 0x04002B3D RID: 11069
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002B3D")]
		public float audioOffset;

		// Token: 0x04002B3E RID: 11070
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002B3E")]
		public List<NoteData> notes;
	}
}
