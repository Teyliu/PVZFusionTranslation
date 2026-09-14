using System;
using Cpp2IlInjected;
using UnityEngine;

namespace GameLevel.EventNodes
{
	// Token: 0x02000B39 RID: 2873
	[Token(Token = "0x2000B39")]
	public static class EventNodeDebug
	{
		// Token: 0x06003BE9 RID: 15337 RVA: 0x0013A33C File Offset: 0x0013853C
		[Token(Token = "0x6003BE9")]
		[Address(RVA = "0x7AD9D0", Offset = "0x7ABFD0", VA = "0x1807AD9D0")]
		public static void Log(string message)
		{
			if (GameAPP.config.debug)
			{
				Debug.Log(message);
				return;
			}
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x0013A364 File Offset: 0x00138564
		[Token(Token = "0x6003BEA")]
		[Address(RVA = "0x7AD940", Offset = "0x7ABF40", VA = "0x1807AD940")]
		public static void LogWarning(string message)
		{
			Debug.LogWarning(message);
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x0013A378 File Offset: 0x00138578
		[Token(Token = "0x6003BEB")]
		[Address(RVA = "0x7AD8B0", Offset = "0x7ABEB0", VA = "0x1807AD8B0")]
		public static void LogError(string message)
		{
			Debug.LogError(message);
		}

		// Token: 0x04002C4B RID: 11339
		[Token(Token = "0x4002C4B")]
		public static bool EnableDebug;

		// Token: 0x04002C4C RID: 11340
		[Token(Token = "0x4002C4C")]
		public static bool EnableWarning;

		// Token: 0x04002C4D RID: 11341
		[Token(Token = "0x4002C4D")]
		public static bool EnableError;
	}
}
