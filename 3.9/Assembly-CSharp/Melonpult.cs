using System;
using Cpp2IlInjected;

// Token: 0x02000567 RID: 1383
[Token(Token = "0x2000567")]
public class Melonpult : Thrower
{
	// Token: 0x060019B4 RID: 6580 RVA: 0x0008ABD0 File Offset: 0x00088DD0
	[Token(Token = "0x60019B4")]
	[Address(RVA = "0x4A8140", Offset = "0x4A6740", VA = "0x1804A8140", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melon;
	}

	// Token: 0x060019B5 RID: 6581 RVA: 0x0008ABE0 File Offset: 0x00088DE0
	[Token(Token = "0x60019B5")]
	[Address(RVA = "0x5368B0", Offset = "0x534EB0", VA = "0x1805368B0", Slot = "53")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x060019B6 RID: 6582 RVA: 0x0008ABF0 File Offset: 0x00088DF0
	[Token(Token = "0x60019B6")]
	[Address(RVA = "0x5368A0", Offset = "0x534EA0", VA = "0x1805368A0", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
		PotEffects.MelonPotEffect(this, theColumn, theRow);
	}

	// Token: 0x060019B7 RID: 6583 RVA: 0x0008AC08 File Offset: 0x00088E08
	[Token(Token = "0x60019B7")]
	[Address(RVA = "0x474940", Offset = "0x472F40", VA = "0x180474940")]
	public Melonpult()
	{
	}
}
