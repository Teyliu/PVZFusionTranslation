using System;
using Cpp2IlInjected;

namespace GameLevel.OnLine
{
	// Token: 0x02000B66 RID: 2918
	[Token(Token = "0x2000B66")]
	[Serializable]
	public class OnlineLevelInfo
	{
		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06003CD8 RID: 15576 RVA: 0x0013D528 File Offset: 0x0013B728
		[Token(Token = "0x170004EE")]
		public string UploadTimeFormatted
		{
			[Token(Token = "0x6003CD8")]
			[Address(RVA = "0x82FA20", Offset = "0x82E020", VA = "0x18082FA20")]
			get
			{
				string text;
				return text;
			}
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x0013D53C File Offset: 0x0013B73C
		[Token(Token = "0x6003CD9")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public OnlineLevelInfo()
		{
		}

		// Token: 0x04002D54 RID: 11604
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002D54")]
		public string levelId;

		// Token: 0x04002D55 RID: 11605
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002D55")]
		public string levelName;

		// Token: 0x04002D56 RID: 11606
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002D56")]
		public string authorName;

		// Token: 0x04002D57 RID: 11607
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002D57")]
		public string description;

		// Token: 0x04002D58 RID: 11608
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002D58")]
		public string levelType;

		// Token: 0x04002D59 RID: 11609
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4002D59")]
		public int levelNumber;

		// Token: 0x04002D5A RID: 11610
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4002D5A")]
		public string version;

		// Token: 0x04002D5B RID: 11611
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4002D5B")]
		public long uploadTime;

		// Token: 0x04002D5C RID: 11612
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4002D5C")]
		public int downloads;

		// Token: 0x04002D5D RID: 11613
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4002D5D")]
		public float rating;

		// Token: 0x04002D5E RID: 11614
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4002D5E")]
		public int ratingCount;

		// Token: 0x04002D5F RID: 11615
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4002D5F")]
		public string fileUrl;
	}
}
