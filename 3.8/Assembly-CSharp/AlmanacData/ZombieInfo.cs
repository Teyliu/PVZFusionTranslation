using System;
using Cpp2IlInjected;

namespace AlmanacData
{
	// Token: 0x02000A47 RID: 2631
	[Token(Token = "0x2000A47")]
	[Serializable]
	public class ZombieInfo
	{
		// Token: 0x0600360E RID: 13838 RVA: 0x0012363C File Offset: 0x0012183C
		[Token(Token = "0x600360E")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public ZombieInfo()
		{
		}

		// Token: 0x04002961 RID: 10593
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002961")]
		public string name;

		// Token: 0x04002962 RID: 10594
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002962")]
		public string introduce;

		// Token: 0x04002963 RID: 10595
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002963")]
		public string info;

		// Token: 0x04002964 RID: 10596
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002964")]
		public ZombieType theZombieType;
	}
}
