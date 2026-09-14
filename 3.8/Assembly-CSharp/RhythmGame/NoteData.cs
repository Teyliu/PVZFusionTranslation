using System;
using Cpp2IlInjected;

namespace RhythmGame
{
	// Token: 0x02000A58 RID: 2648
	[Token(Token = "0x2000A58")]
	[Serializable]
	public class NoteData
	{
		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06003670 RID: 13936 RVA: 0x00125A6C File Offset: 0x00123C6C
		[Token(Token = "0x17000246")]
		public float duration
		{
			[Token(Token = "0x6003670")]
			[Address(RVA = "0x76C8C0", Offset = "0x76AEC0", VA = "0x18076C8C0")]
			get
			{
				return this.endTime;
			}
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x00125A80 File Offset: 0x00123C80
		[Token(Token = "0x6003671")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public NoteData()
		{
		}

		// Token: 0x040029CC RID: 10700
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40029CC")]
		public float time;

		// Token: 0x040029CD RID: 10701
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40029CD")]
		public int track;

		// Token: 0x040029CE RID: 10702
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40029CE")]
		public NoteType type;

		// Token: 0x040029CF RID: 10703
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40029CF")]
		[NonSerialized]
		public bool spawned;

		// Token: 0x040029D0 RID: 10704
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40029D0")]
		public float endTime;
	}
}
