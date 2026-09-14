using System;
using Cpp2IlInjected;

namespace AlmanacData
{
	// Token: 0x02000A46 RID: 2630
	[Token(Token = "0x2000A46")]
	[Serializable]
	public class PlantInfo
	{
		// Token: 0x0600360D RID: 13837 RVA: 0x00123628 File Offset: 0x00121828
		[Token(Token = "0x600360D")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public PlantInfo()
		{
		}

		// Token: 0x0400295C RID: 10588
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400295C")]
		public string name;

		// Token: 0x0400295D RID: 10589
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400295D")]
		public string introduce;

		// Token: 0x0400295E RID: 10590
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400295E")]
		public string info;

		// Token: 0x0400295F RID: 10591
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400295F")]
		public string cost;

		// Token: 0x04002960 RID: 10592
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002960")]
		public int seedType;
	}
}
