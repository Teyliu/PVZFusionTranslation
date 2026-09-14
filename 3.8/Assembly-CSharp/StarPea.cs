using System;
using Cpp2IlInjected;

// Token: 0x02000571 RID: 1393
[Token(Token = "0x2000571")]
public class StarPea : Shooter
{
	// Token: 0x060019CE RID: 6606 RVA: 0x0008B078 File Offset: 0x00089278
	[Token(Token = "0x60019CE")]
	[Address(RVA = "0x4E6CE0", Offset = "0x4E52E0", VA = "0x1804E6CE0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_pea_star;
	}

	// Token: 0x060019CF RID: 6607 RVA: 0x0008B08C File Offset: 0x0008928C
	[Token(Token = "0x60019CF")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public StarPea()
	{
	}
}
