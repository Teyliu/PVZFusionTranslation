using System;
using Cpp2IlInjected;
using Unity.VisualScripting;

// Token: 0x020001D6 RID: 470
[Token(Token = "0x20001D6")]
public class Bullet_waterBallista2 : Bullet_spruceBallista
{
	// Token: 0x060007FE RID: 2046 RVA: 0x00028874 File Offset: 0x00026A74
	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x8184D0", Offset = "0x816AD0", VA = "0x1808184D0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		zombie.SetCold(15f, 1, num != 0);
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num2 != 0UL);
		base.PlaySound(zombie);
		BallistaBomb ballistaBomb = zombie.AddComponent<BallistaBomb>();
		ballistaBomb.timer = 0.3f;
		ballistaBomb.zombie = zombie;
		int damage2 = this._damage;
		ballistaBomb.damage = damage2;
		ballistaBomb.particleType = (ParticleType)((ulong)108L);
		PlantType fromType2 = this.fromType;
		ballistaBomb.fromType = fromType2;
	}

	// Token: 0x060007FF RID: 2047 RVA: 0x00028900 File Offset: 0x00026B00
	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_waterBallista2()
	{
	}
}
