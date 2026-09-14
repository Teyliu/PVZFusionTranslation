using System;
using Cpp2IlInjected;

// Token: 0x02000568 RID: 1384
[Token(Token = "0x2000568")]
public class SquashCabbage : Cabbage
{
	// Token: 0x060019B6 RID: 6582 RVA: 0x0008AAE0 File Offset: 0x00088CE0
	[Token(Token = "0x60019B6")]
	[Address(RVA = "0x4E5E80", Offset = "0x4E4480", VA = "0x1804E5E80", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_squashCabbage;
	}

	// Token: 0x060019B7 RID: 6583 RVA: 0x0008AAF4 File Offset: 0x00088CF4
	[Token(Token = "0x60019B7")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public SquashCabbage()
	{
	}
}
