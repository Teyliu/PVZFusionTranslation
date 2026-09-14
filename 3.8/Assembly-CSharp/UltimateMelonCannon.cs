using System;
using Cpp2IlInjected;

// Token: 0x02000483 RID: 1155
[Token(Token = "0x2000483")]
public class UltimateMelonCannon : MelonCannon
{
	// Token: 0x06001588 RID: 5512 RVA: 0x00077564 File Offset: 0x00075764
	[Token(Token = "0x6001588")]
	[Address(RVA = "0x48F2C0", Offset = "0x48D8C0", VA = "0x18048F2C0", Slot = "72")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melonCannon2;
	}

	// Token: 0x06001589 RID: 5513 RVA: 0x00077578 File Offset: 0x00075778
	[Token(Token = "0x6001589")]
	[Address(RVA = "0x48F2D0", Offset = "0x48D8D0", VA = "0x18048F2D0", Slot = "70")]
	public override void StartShoot()
	{
		this.anim.SetTrigger("shoot");
		float thePlantAttackInterval = this.thePlantAttackInterval;
		this.avaliable = false;
		base.AttributeCountdown = thePlantAttackInterval;
		if (Lawnf.TravelUltimate((UltiBuff)((uint)15)))
		{
			float num;
			base.AttributeCountdown = num;
			return;
		}
	}

	// Token: 0x0600158A RID: 5514 RVA: 0x000775C4 File Offset: 0x000757C4
	[Token(Token = "0x600158A")]
	[Address(RVA = "0x41C050", Offset = "0x41A650", VA = "0x18041C050")]
	public UltimateMelonCannon()
	{
	}
}
