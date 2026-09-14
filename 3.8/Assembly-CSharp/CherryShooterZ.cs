using System;
using Cpp2IlInjected;

// Token: 0x0200063E RID: 1598
[Token(Token = "0x200063E")]
public class CherryShooterZ : PeaShooterZ
{
	// Token: 0x06001E5B RID: 7771 RVA: 0x000A276C File Offset: 0x000A096C
	[Token(Token = "0x6001E5B")]
	[Address(RVA = "0x39CE40", Offset = "0x39B440", VA = "0x18039CE40", Slot = "75")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_cherry;
	}

	// Token: 0x06001E5C RID: 7772 RVA: 0x000A277C File Offset: 0x000A097C
	[Token(Token = "0x6001E5C")]
	[Address(RVA = "0x539070", Offset = "0x537670", VA = "0x180539070", Slot = "76")]
	protected override int GetBulletDamage()
	{
		int bulletDamage = base.GetBulletDamage();
		return bulletDamage + bulletDamage;
	}

	// Token: 0x06001E5D RID: 7773 RVA: 0x000A2798 File Offset: 0x000A0998
	[Token(Token = "0x6001E5D")]
	[Address(RVA = "0x539090", Offset = "0x537690", VA = "0x180539090")]
	public CherryShooterZ()
	{
	}
}
