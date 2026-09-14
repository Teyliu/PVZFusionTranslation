using System;
using Cpp2IlInjected;

namespace GameLevel.OnLine
{
	// Token: 0x02000B65 RID: 2917
	[Token(Token = "0x2000B65")]
	[Serializable]
	public class OnlineLevelListResponse
	{
		// Token: 0x06003CD7 RID: 15575 RVA: 0x0013D514 File Offset: 0x0013B714
		[Token(Token = "0x6003CD7")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public OnlineLevelListResponse()
		{
		}

		// Token: 0x04002D53 RID: 11603
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002D53")]
		public OnlineLevelInfo[] levels;
	}
}
