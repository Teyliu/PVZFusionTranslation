using System;
using Cpp2IlInjected;

// Token: 0x02000274 RID: 628
[Token(Token = "0x2000274")]
[Serializable]
public class PetOriginalData
{
	// Token: 0x06000B5B RID: 2907 RVA: 0x00041530 File Offset: 0x0003F730
	[Token(Token = "0x6000B5B")]
	[Address(RVA = "0x8A8820", Offset = "0x8A6E20", VA = "0x1808A8820")]
	public void FirstLoad(MiniPet miniPet)
	{
		float num = this.attackDamage;
		miniPet.Damage = num;
		float num2 = this.attackRange;
		miniPet.attackRange = num2;
		float num3 = this.attackInterval;
		miniPet.attackInterval = num3;
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x00041570 File Offset: 0x0003F770
	[Token(Token = "0x6000B5C")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public PetOriginalData()
	{
	}

	// Token: 0x04000778 RID: 1912
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000778")]
	public float attackDamage;

	// Token: 0x04000779 RID: 1913
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000779")]
	public float attackRange;

	// Token: 0x0400077A RID: 1914
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400077A")]
	public float attackInterval;
}
