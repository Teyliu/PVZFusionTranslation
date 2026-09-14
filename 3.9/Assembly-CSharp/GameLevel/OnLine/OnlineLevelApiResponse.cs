using System;
using Cpp2IlInjected;

namespace GameLevel.OnLine
{
	// Token: 0x02000B68 RID: 2920
	[Token(Token = "0x2000B68")]
	[Serializable]
	public class OnlineLevelApiResponse
	{
		// Token: 0x06003CDB RID: 15579 RVA: 0x0013D564 File Offset: 0x0013B764
		[Token(Token = "0x6003CDB")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public OnlineLevelApiResponse()
		{
		}

		// Token: 0x04002D62 RID: 11618
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4002D62")]
		public bool success;

		// Token: 0x04002D63 RID: 11619
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4002D63")]
		public string levelId;

		// Token: 0x04002D64 RID: 11620
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002D64")]
		public string error;

		// Token: 0x04002D65 RID: 11621
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002D65")]
		public string message;
	}
}
