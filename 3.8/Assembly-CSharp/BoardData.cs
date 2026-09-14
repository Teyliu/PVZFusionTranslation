using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x0200025A RID: 602
[Token(Token = "0x200025A")]
[Serializable]
public class BoardData
{
	// Token: 0x06000AD7 RID: 2775 RVA: 0x0003EA54 File Offset: 0x0003CC54
	[Token(Token = "0x6000AD7")]
	[Address(RVA = "0x89E520", Offset = "0x89CB20", VA = "0x18089E520")]
	public int GetZombieLevel()
	{
		if (this.zombieLevelDic == (ulong)0L)
		{
			return 1;
		}
		return DictionaryExtensions.GetRandomKeyByWeight<int>(this.zombieLevelDic);
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x0003EA7C File Offset: 0x0003CC7C
	[Token(Token = "0x6000AD8")]
	[Address(RVA = "0x89E590", Offset = "0x89CB90", VA = "0x18089E590")]
	public BoardData()
	{
	}

	// Token: 0x040006E3 RID: 1763
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006E3")]
	public Board board;

	// Token: 0x040006E4 RID: 1764
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006E4")]
	public int theSun = (int)((ulong)500L);

	// Token: 0x040006E5 RID: 1765
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40006E5")]
	public int extraSun;

	// Token: 0x040006E6 RID: 1766
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006E6")]
	public Dictionary<int, int> zombieLevelDic;
}
