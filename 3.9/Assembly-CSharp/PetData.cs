using System;
using System.Collections.Generic;
using Cpp2IlInjected;

// Token: 0x02000279 RID: 633
[Token(Token = "0x2000279")]
[Serializable]
public class PetData
{
	// Token: 0x06000B75 RID: 2933 RVA: 0x00041328 File Offset: 0x0003F528
	[Token(Token = "0x6000B75")]
	[Address(RVA = "0x9377F0", Offset = "0x935DF0", VA = "0x1809377F0")]
	public MiniPet LoadPet(Board board, PetType petType)
	{
		float boxXFromColumn = Lawnf.GetBoxXFromColumn(0);
		float boxYFromRow = Lawnf.GetBoxYFromRow(0, 5);
		MiniPet miniPet;
		miniPet.data = this;
		return miniPet;
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x00041354 File Offset: 0x0003F554
	[Token(Token = "0x6000B76")]
	[Address(RVA = "0x9378C0", Offset = "0x935EC0", VA = "0x1809378C0")]
	public PetData()
	{
		List<PetBuff> list = new List();
		this.petBuffs = list;
		base..ctor();
	}

	// Token: 0x04000781 RID: 1921
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000781")]
	public PetType petType;

	// Token: 0x04000782 RID: 1922
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000782")]
	public int attributeCount;

	// Token: 0x04000783 RID: 1923
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000783")]
	public List<PetBuff> petBuffs;
}
