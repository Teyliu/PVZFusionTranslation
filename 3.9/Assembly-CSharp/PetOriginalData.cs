using System;
using Cpp2IlInjected;

// Token: 0x0200027A RID: 634
[Token(Token = "0x200027A")]
[Serializable]
public class PetOriginalData
{
	// Token: 0x06000B77 RID: 2935 RVA: 0x00041374 File Offset: 0x0003F574
	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x938840", Offset = "0x936E40", VA = "0x180938840")]
	public void FirstLoad(MiniPet miniPet)
	{
		float num = this.attackDamage;
		miniPet.Damage = num;
		float num2 = this.attackRange;
		miniPet.attackRange = num2;
		float num3 = this.attackInterval;
		miniPet.attackInterval = num3;
	}

	// Token: 0x06000B78 RID: 2936 RVA: 0x000413B4 File Offset: 0x0003F5B4
	[Token(Token = "0x6000B78")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public PetOriginalData()
	{
	}

	// Token: 0x04000784 RID: 1924
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000784")]
	public float attackDamage;

	// Token: 0x04000785 RID: 1925
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000785")]
	public float attackRange;

	// Token: 0x04000786 RID: 1926
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000786")]
	public float attackInterval;
}
