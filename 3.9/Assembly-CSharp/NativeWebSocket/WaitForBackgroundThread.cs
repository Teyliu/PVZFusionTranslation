using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

namespace NativeWebSocket
{
	// Token: 0x02000E07 RID: 3591
	[Token(Token = "0x2000E07")]
	public class WaitForBackgroundThread
	{
		// Token: 0x06004A27 RID: 18983 RVA: 0x0016D488 File Offset: 0x0016B688
		[Token(Token = "0x6004A27")]
		[Address(RVA = "0x8DD150", Offset = "0x8DB750", VA = "0x1808DD150")]
		public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
		{
			Action <>9__0_ = WaitForBackgroundThread.<>c.<>9__0_0;
			if (<>9__0_ == 0)
			{
				WaitForBackgroundThread.<>c.<>9__0_0 = delegate
				{
				};
			}
			Task task = Task.Run(<>9__0_);
			throw new NullReferenceException();
		}

		// Token: 0x06004A28 RID: 18984 RVA: 0x0016D4CC File Offset: 0x0016B6CC
		[Token(Token = "0x6004A28")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public WaitForBackgroundThread()
		{
		}
	}
}
