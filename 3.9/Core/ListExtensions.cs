using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public static class ListExtensions
{
	// Token: 0x06000006 RID: 6 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000006")]
	[Address(RVA = "0xA8FCE0", Offset = "0xA8E2E0", VA = "0x180A8FCE0")]
	public static void Shuffle<T>(this IList<T> list)
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0xA8EDD0", Offset = "0xA8D3D0", VA = "0x180A8EDD0")]
	public static T GetRandom<T>(this List<T> list)
	{
		return null;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002070 File Offset: 0x00000270
	[Token(Token = "0x6000008")]
	[Address(RVA = "0xA8F750", Offset = "0xA8DD50", VA = "0x180A8F750")]
	public static int ReplaceBy<T>(this List<T> list, T a, T b)
	{
		return 0;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0xA8E630", Offset = "0xA8CC30", VA = "0x180A8E630")]
	public static T GetRandomAndRemove<T>(this List<T> list)
	{
		return null;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0xA8EAD0", Offset = "0xA8D0D0", VA = "0x180A8EAD0")]
	public static List<T> GetRandom<T>(this List<T> list, int count)
	{
		return null;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x600000B")]
	[Address(RVA = "0xA90860", Offset = "0xA8EE60", VA = "0x180A90860")]
	public static bool TryAddUnique<T>(this IList<T> list, T value)
	{
		return default(bool);
	}

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	private static readonly Random random;
}
