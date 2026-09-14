using System;
using Cpp2IlInjected;

namespace AlmanacData
{
	// Token: 0x02000A86 RID: 2694
	[Token(Token = "0x2000A86")]
	[Serializable]
	public class PlantInfo
	{
		// Token: 0x06003751 RID: 14161 RVA: 0x001288A4 File Offset: 0x00126AA4
		[Token(Token = "0x6003751")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public PlantInfo()
		{
		}

		// Token: 0x04002ACF RID: 10959
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002ACF")]
		public string name;

		// Token: 0x04002AD0 RID: 10960
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002AD0")]
		public string introduce;

		// Token: 0x04002AD1 RID: 10961
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002AD1")]
		public string info;

		// Token: 0x04002AD2 RID: 10962
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002AD2")]
		public string cost;

		// Token: 0x04002AD3 RID: 10963
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4002AD3")]
		public int seedType;
	}
}
