using System;
using Cpp2IlInjected;
using Unity.VisualScripting;

// Token: 0x020001CC RID: 460
[Token(Token = "0x20001CC")]
public class Bullet_waterBallista2 : Bullet_spruceBallista
{
	// Token: 0x060007E8 RID: 2024 RVA: 0x00028CB4 File Offset: 0x00026EB4
	[Token(Token = "0x60007E8")]
	[Address(RVA = "0x7EADE0", Offset = "0x7E93E0", VA = "0x1807EADE0", Slot = "25")]
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

	// Token: 0x060007E9 RID: 2025 RVA: 0x00028D40 File Offset: 0x00026F40
	[Token(Token = "0x60007E9")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_waterBallista2()
	{
	}
}
