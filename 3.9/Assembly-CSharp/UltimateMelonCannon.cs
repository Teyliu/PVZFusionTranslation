using System;
using Cpp2IlInjected;

// Token: 0x020004A5 RID: 1189
[Token(Token = "0x20004A5")]
public class UltimateMelonCannon : MelonCannon
{
	// Token: 0x06001628 RID: 5672 RVA: 0x00079EE0 File Offset: 0x000780E0
	[Token(Token = "0x6001628")]
	[Address(RVA = "0x4E8840", Offset = "0x4E6E40", VA = "0x1804E8840", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_melonCannon2;
	}

	// Token: 0x06001629 RID: 5673 RVA: 0x00079EF4 File Offset: 0x000780F4
	[Token(Token = "0x6001629")]
	[Address(RVA = "0x4E8850", Offset = "0x4E6E50", VA = "0x1804E8850", Slot = "69")]
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

	// Token: 0x0600162A RID: 5674 RVA: 0x00079F40 File Offset: 0x00078140
	[Token(Token = "0x600162A")]
	[Address(RVA = "0x472EF0", Offset = "0x4714F0", VA = "0x180472EF0")]
	public UltimateMelonCannon()
	{
	}
}
