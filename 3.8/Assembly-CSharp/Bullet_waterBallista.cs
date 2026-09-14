using System;
using Cpp2IlInjected;
using Unity.VisualScripting;

// Token: 0x020001CB RID: 459
[Token(Token = "0x20001CB")]
public class Bullet_waterBallista : Bullet_spruceBallista
{
	// Token: 0x060007E6 RID: 2022 RVA: 0x00028BF4 File Offset: 0x00026DF4
	[Token(Token = "0x60007E6")]
	[Address(RVA = "0x7EAEF0", Offset = "0x7E94F0", VA = "0x1807EAEF0", Slot = "25")]
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

	// Token: 0x060007E7 RID: 2023 RVA: 0x00028CA0 File Offset: 0x00026EA0
	[Token(Token = "0x60007E7")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_waterBallista()
	{
	}
}
