using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000260 RID: 608
[Token(Token = "0x2000260")]
[Serializable]
public class BoardData
{
	// Token: 0x06000AF3 RID: 2803 RVA: 0x0003E900 File Offset: 0x0003CB00
	[Token(Token = "0x6000AF3")]
	[Address(RVA = "0x92E4A0", Offset = "0x92CAA0", VA = "0x18092E4A0")]
	public int GetZombieLevel()
	{
		if (this.zombieLevelDic == (ulong)0L)
		{
			return 1;
		}
		return DictionaryExtensions.GetRandomKeyByWeight<int>(this.zombieLevelDic);
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x0003E928 File Offset: 0x0003CB28
	[Token(Token = "0x6000AF4")]
	[Address(RVA = "0x92E510", Offset = "0x92CB10", VA = "0x18092E510")]
	public BoardData()
	{
	}

	// Token: 0x040006EF RID: 1775
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006EF")]
	public Board board;

	// Token: 0x040006F0 RID: 1776
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006F0")]
	public int theSun = (int)((ulong)500L);

	// Token: 0x040006F1 RID: 1777
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40006F1")]
	public int extraSun;

	// Token: 0x040006F2 RID: 1778
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006F2")]
	public Dictionary<int, int> zombieLevelDic;
}
