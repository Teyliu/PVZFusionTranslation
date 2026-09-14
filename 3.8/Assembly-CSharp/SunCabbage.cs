using System;
using Cpp2IlInjected;

// Token: 0x02000576 RID: 1398
[Token(Token = "0x2000576")]
public class SunCabbage : Cabbage
{
	// Token: 0x060019DA RID: 6618 RVA: 0x0008B4CC File Offset: 0x000896CC
	[Token(Token = "0x60019DA")]
	[Address(RVA = "0x4E30C0", Offset = "0x4E16C0", VA = "0x1804E30C0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_sunCabbage;
	}

	// Token: 0x060019DB RID: 6619 RVA: 0x0008B4DC File Offset: 0x000896DC
	[Token(Token = "0x60019DB")]
	[Address(RVA = "0x4E81F0", Offset = "0x4E67F0", VA = "0x1804E81F0", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
	}

	// Token: 0x060019DC RID: 6620 RVA: 0x0008B4EC File Offset: 0x000896EC
	[Token(Token = "0x60019DC")]
	[Address(RVA = "0x4E8220", Offset = "0x4E6820", VA = "0x1804E8220", Slot = "54")]
	public override void OnMove(int originalColumn, int originalRow, int newColumn, int newRow)
	{
	}

	// Token: 0x060019DD RID: 6621 RVA: 0x0008B4FC File Offset: 0x000896FC
	[Token(Token = "0x60019DD")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public SunCabbage()
	{
	}
}
