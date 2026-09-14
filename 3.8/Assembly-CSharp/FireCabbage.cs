using System;
using Cpp2IlInjected;

// Token: 0x020004EB RID: 1259
[Token(Token = "0x20004EB")]
public class FireCabbage : Cabbage
{
	// Token: 0x060017A6 RID: 6054 RVA: 0x00081300 File Offset: 0x0007F500
	[Token(Token = "0x60017A6")]
	[Address(RVA = "0x4C79C0", Offset = "0x4C5FC0", VA = "0x1804C79C0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cabbage_fire;
	}

	// Token: 0x060017A7 RID: 6055 RVA: 0x00081314 File Offset: 0x0007F514
	[Token(Token = "0x60017A7")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public FireCabbage()
	{
	}
}
