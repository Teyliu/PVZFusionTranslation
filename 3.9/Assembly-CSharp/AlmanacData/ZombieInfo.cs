using System;
using Cpp2IlInjected;

namespace AlmanacData
{
	// Token: 0x02000A87 RID: 2695
	[Token(Token = "0x2000A87")]
	[Serializable]
	public class ZombieInfo
	{
		// Token: 0x06003752 RID: 14162 RVA: 0x001288B8 File Offset: 0x00126AB8
		[Token(Token = "0x6003752")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public ZombieInfo()
		{
		}

		// Token: 0x04002AD4 RID: 10964
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002AD4")]
		public string name;

		// Token: 0x04002AD5 RID: 10965
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002AD5")]
		public string introduce;

		// Token: 0x04002AD6 RID: 10966
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002AD6")]
		public string info;

		// Token: 0x04002AD7 RID: 10967
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002AD7")]
		public ZombieType theZombieType;
	}
}
