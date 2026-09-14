using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000273 RID: 627
[Token(Token = "0x2000273")]
[Serializable]
public class PetData
{
	// Token: 0x06000B59 RID: 2905 RVA: 0x000414E4 File Offset: 0x0003F6E4
	[Token(Token = "0x6000B59")]
	[Address(RVA = "0x8A77D0", Offset = "0x8A5DD0", VA = "0x1808A77D0")]
	public MiniPet LoadPet(Board board, PetType petType)
	{
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(0);
		float boxYFromRow = Lawnf.GetBoxYFromRow(0, 5);
		MiniPet miniPet;
		miniPet.data = this;
		return miniPet;
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x00041510 File Offset: 0x0003F710
	[Token(Token = "0x6000B5A")]
	[Address(RVA = "0x8A78A0", Offset = "0x8A5EA0", VA = "0x1808A78A0")]
	public PetData()
	{
		List<PetBuff> list = new List();
		this.petBuffs = list;
		base..ctor();
	}

	// Token: 0x04000775 RID: 1909
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000775")]
	public PetType petType;

	// Token: 0x04000776 RID: 1910
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000776")]
	public int attributeCount;

	// Token: 0x04000777 RID: 1911
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000777")]
	public List<PetBuff> petBuffs;
}
