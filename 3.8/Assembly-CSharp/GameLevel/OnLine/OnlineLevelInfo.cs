using System;
using Cpp2IlInjected;

namespace GameLevel.OnLine
{
	// Token: 0x02000B24 RID: 2852
	[Token(Token = "0x2000B24")]
	[Serializable]
	public class OnlineLevelInfo
	{
		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06003B87 RID: 15239 RVA: 0x0013824C File Offset: 0x0013644C
		[Token(Token = "0x1700049E")]
		public string UploadTimeFormatted
		{
			[Token(Token = "0x6003B87")]
			[Address(RVA = "0x7B40E0", Offset = "0x7B26E0", VA = "0x1807B40E0")]
			get
			{
				string text;
				return text;
			}
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x00138260 File Offset: 0x00136460
		[Token(Token = "0x6003B88")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public OnlineLevelInfo()
		{
		}

		// Token: 0x04002BE0 RID: 11232
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002BE0")]
		public string levelId;

		// Token: 0x04002BE1 RID: 11233
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002BE1")]
		public string levelName;

		// Token: 0x04002BE2 RID: 11234
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002BE2")]
		public string authorName;

		// Token: 0x04002BE3 RID: 11235
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002BE3")]
		public string description;

		// Token: 0x04002BE4 RID: 11236
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002BE4")]
		public string levelType;

		// Token: 0x04002BE5 RID: 11237
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002BE5")]
		public int levelNumber;

		// Token: 0x04002BE6 RID: 11238
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002BE6")]
		public string version;

		// Token: 0x04002BE7 RID: 11239
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002BE7")]
		public long uploadTime;

		// Token: 0x04002BE8 RID: 11240
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002BE8")]
		public int downloads;

		// Token: 0x04002BE9 RID: 11241
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4002BE9")]
		public float rating;

		// Token: 0x04002BEA RID: 11242
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002BEA")]
		public int ratingCount;

		// Token: 0x04002BEB RID: 11243
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002BEB")]
		public string fileUrl;
	}
}
