using System;
using Cpp2IlInjected;
using Unity.VisualScripting;

// Token: 0x020001D5 RID: 469
[Token(Token = "0x20001D5")]
public class Bullet_waterBallista : Bullet_spruceBallista
{
	// Token: 0x060007FC RID: 2044 RVA: 0x000287B4 File Offset: 0x000269B4
	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x8185E0", Offset = "0x816BE0", VA = "0x1808185E0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
		WaterSpray waterSpray = zombie.waterSpray;
		int num2 = 0;
		if (!(waterSpray == num2))
		{
			zombie.waterSpray.liveTimer = 5f;
		}
		WaterSpray waterSpray2 = zombie.AddComponent<WaterSpray>();
		BallistaBomb ballistaBomb = zombie.AddComponent<BallistaBomb>();
		ballistaBomb.timer = 0.3f;
		ballistaBomb.zombie = zombie;
		int damage2 = this._damage;
		ballistaBomb.damage = damage2;
		ballistaBomb.particleType = (ParticleType)((ulong)108L);
		PlantType fromType2 = this.fromType;
		ballistaBomb.fromType = fromType2;
	}

	// Token: 0x060007FD RID: 2045 RVA: 0x00028860 File Offset: 0x00026A60
	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_waterBallista()
	{
	}
}
