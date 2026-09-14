using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace RhythmGame
{
	// Token: 0x02000A57 RID: 2647
	[Token(Token = "0x2000A57")]
	[Serializable]
	public class RhythmLevelData
	{
		// Token: 0x0600366F RID: 13935 RVA: 0x00125A20 File Offset: 0x00123C20
		[Token(Token = "0x600366F")]
		[Address(RVA = "0x7740C0", Offset = "0x7726C0", VA = "0x1807740C0")]
		public RhythmLevelData()
		{
			List<NoteData> list = new List();
			this.notes = list;
			base..ctor();
		}

		// Token: 0x040029C6 RID: 10694
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40029C6")]
		public MusicType musicType = (MusicType)((ulong)13L);

		// Token: 0x040029C7 RID: 10695
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40029C7")]
		public string musicName = "song";

		// Token: 0x040029C8 RID: 10696
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40029C8")]
		public float fallTime = 1f;

		// Token: 0x040029C9 RID: 10697
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x40029C9")]
		public float bpm = 160f;

		// Token: 0x040029CA RID: 10698
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40029CA")]
		public float audioOffset;

		// Token: 0x040029CB RID: 10699
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40029CB")]
		public List<NoteData> notes;
	}
}
