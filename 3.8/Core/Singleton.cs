using System;
using Cpp2IlInjected;

namespace Core
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class Singleton<T> where T : class, new()
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public static T Instance
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x155DE60", Offset = "0x155C460", VA = "0x18155DE60")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public Singleton()
		{
		}

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		private static T _instance;
	}
}
