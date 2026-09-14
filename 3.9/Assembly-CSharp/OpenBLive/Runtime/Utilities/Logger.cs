using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace OpenBLive.Runtime.Utilities
{
	// Token: 0x02000E3E RID: 3646
	[Token(Token = "0x2000E3E")]
	public static class Logger
	{
		// Token: 0x06004B3A RID: 19258 RVA: 0x00171E6C File Offset: 0x0017006C
		[Token(Token = "0x6004B3A")]
		[Address(RVA = "0x8CDAA0", Offset = "0x8CC0A0", VA = "0x1808CDAA0")]
		public static void LogError(string logInfo)
		{
			Debug.LogError(logInfo);
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x00171E80 File Offset: 0x00170080
		[Token(Token = "0x6004B3B")]
		[Address(RVA = "0x8CDAF0", Offset = "0x8CC0F0", VA = "0x1808CDAF0")]
		public static void LogWarning(string logInfo)
		{
			Debug.LogWarning(logInfo);
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x00171E94 File Offset: 0x00170094
		[Token(Token = "0x6004B3C")]
		[Address(RVA = "0x8CDB40", Offset = "0x8CC140", VA = "0x1808CDB40")]
		public static void Log(string logInfo, bool ingameText = false)
		{
			Debug.Log(logInfo);
			if (ingameText)
			{
				InGameText instance = InGameText.Instance;
			}
		}
	}
}
