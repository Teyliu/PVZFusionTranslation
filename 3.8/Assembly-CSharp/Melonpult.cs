using System;
using Cpp2IlInjected;

// Token: 0x0200053A RID: 1338
[Token(Token = "0x200053A")]
public class Melonpult : Thrower
{
	// Token: 0x060018E4 RID: 6372 RVA: 0x00086F18 File Offset: 0x00085118
	[Token(Token = "0x60018E4")]
	[Address(RVA = "0x453480", Offset = "0x451A80", VA = "0x180453480", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melon;
	}

	// Token: 0x060018E5 RID: 6373 RVA: 0x00086F28 File Offset: 0x00085128
	[Token(Token = "0x60018E5")]
	[Address(RVA = "0x4D5FA0", Offset = "0x4D45A0", VA = "0x1804D5FA0", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x060018E6 RID: 6374 RVA: 0x00086F38 File Offset: 0x00085138
	[Token(Token = "0x60018E6")]
	[Address(RVA = "0x4D5F90", Offset = "0x4D4590", VA = "0x1804D5F90", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
		PotEffects.MelonPotEffect(this, theColumn, theRow);
	}

	// Token: 0x060018E7 RID: 6375 RVA: 0x00086F50 File Offset: 0x00085150
	[Token(Token = "0x60018E7")]
	[Address(RVA = "0x41DAA0", Offset = "0x41C0A0", VA = "0x18041DAA0")]
	public Melonpult()
	{
	}
}
