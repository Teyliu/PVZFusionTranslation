using System;
using Cpp2IlInjected;

// Token: 0x020005D1 RID: 1489
[Token(Token = "0x20005D1")]
public class UltimateCorn : Cornpult
{
	// Token: 0x06001BA6 RID: 7078 RVA: 0x00093D3C File Offset: 0x00091F3C
	[Token(Token = "0x6001BA6")]
	[Address(RVA = "0x559170", Offset = "0x557770", VA = "0x180559170", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		bool flag = Lawnf.TravelAdvanced((AdvBuff)((uint)3004));
		return BulletType.Bullet_pea;
	}

	// Token: 0x06001BA7 RID: 7079 RVA: 0x00093D60 File Offset: 0x00091F60
	[Token(Token = "0x6001BA7")]
	[Address(RVA = "0x559160", Offset = "0x557760", VA = "0x180559160", Slot = "78")]
	protected override BulletType GetBulletType2()
	{
		return BulletType.Bullet_BlackHole_gold;
	}

	// Token: 0x06001BA8 RID: 7080 RVA: 0x00093D74 File Offset: 0x00091F74
	[Token(Token = "0x6001BA8")]
	[Address(RVA = "0x5591A0", Offset = "0x5577A0", VA = "0x1805591A0", Slot = "76")]
	protected override void UniqueEffect2(Bullet bullet)
	{
		base.UniqueEffect2(bullet);
		int shootingLevel = this.shootingLevel;
		bullet.shootingLevel = shootingLevel;
	}

	// Token: 0x06001BA9 RID: 7081 RVA: 0x00093D9C File Offset: 0x00091F9C
	[Token(Token = "0x6001BA9")]
	[Address(RVA = "0x4D6B50", Offset = "0x4D5150", VA = "0x1804D6B50")]
	public UltimateCorn()
	{
	}
}
