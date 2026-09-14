using System;
using Cpp2IlInjected;

// Token: 0x020005A0 RID: 1440
[Token(Token = "0x20005A0")]
public class UltimateCorn : Cornpult
{
	// Token: 0x06001AC0 RID: 6848 RVA: 0x0008F93C File Offset: 0x0008DB3C
	[Token(Token = "0x6001AC0")]
	[Address(RVA = "0x4FBBE0", Offset = "0x4FA1E0", VA = "0x1804FBBE0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)3004));
		return BulletType.Bullet_pea;
	}

	// Token: 0x06001AC1 RID: 6849 RVA: 0x0008F960 File Offset: 0x0008DB60
	[Token(Token = "0x6001AC1")]
	[Address(RVA = "0x4FBBD0", Offset = "0x4FA1D0", VA = "0x1804FBBD0", Slot = "79")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_BlackHole_gold;
	}

	// Token: 0x06001AC2 RID: 6850 RVA: 0x0008F974 File Offset: 0x0008DB74
	[Token(Token = "0x6001AC2")]
	[Address(RVA = "0x4FBC10", Offset = "0x4FA210", VA = "0x1804FBC10", Slot = "77")]
	protected override void UniqueEffect2(Bullet bullet)
	{
		base.UniqueEffect2(bullet);
		int shootingLevel = this.shootingLevel;
		bullet.shootingLevel = shootingLevel;
	}

	// Token: 0x06001AC3 RID: 6851 RVA: 0x0008F99C File Offset: 0x0008DB9C
	[Token(Token = "0x6001AC3")]
	[Address(RVA = "0x47E9D0", Offset = "0x47CFD0", VA = "0x18047E9D0")]
	public UltimateCorn()
	{
	}
}
