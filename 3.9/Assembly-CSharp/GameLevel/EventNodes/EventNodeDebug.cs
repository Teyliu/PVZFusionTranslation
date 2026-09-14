using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B7B RID: 2939
	[Token(Token = "0x2000B7B")]
	public static class EventNodeDebug
	{
		// Token: 0x06003D3A RID: 15674 RVA: 0x0013F5E4 File Offset: 0x0013D7E4
		[Token(Token = "0x6003D3A")]
		[Address(RVA = "0x828F10", Offset = "0x827510", VA = "0x180828F10")]
		public static void Log(string message)
		{
			if (GameAPP.config.debug)
			{
				Debug.Log(message);
				return;
			}
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x0013F60C File Offset: 0x0013D80C
		[Token(Token = "0x6003D3B")]
		[Address(RVA = "0x828E80", Offset = "0x827480", VA = "0x180828E80")]
		public static void LogWarning(string message)
		{
			Debug.LogWarning(message);
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x0013F620 File Offset: 0x0013D820
		[Token(Token = "0x6003D3C")]
		[Address(RVA = "0x828DF0", Offset = "0x8273F0", VA = "0x180828DF0")]
		public static void LogError(string message)
		{
			Debug.LogError(message);
		}

		// Token: 0x04002DBF RID: 11711
		[Token(Token = "0x4002DBF")]
		public static bool EnableDebug;

		// Token: 0x04002DC0 RID: 11712
		[Token(Token = "0x4002DC0")]
		public static bool EnableWarning;

		// Token: 0x04002DC1 RID: 11713
		[Token(Token = "0x4002DC1")]
		public static bool EnableError;
	}
}
