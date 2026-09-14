using System;
using Cpp2IlInjected;

namespace Core
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class Singleton<T> where T : class, new()
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public static T Instance
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0xC63CF0", Offset = "0xC622F0", VA = "0x180C63CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public Singleton()
		{
		}

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		private static T _instance;
	}
}
