using System;
using Cpp2IlInjected;

// Token: 0x0200019F RID: 415
[Token(Token = "0x200019F")]
public class Bullet_smallIceSpark_sp2 : Bullet_smallIceSpark_sp
{
	// Token: 0x0600073D RID: 1853 RVA: 0x00025504 File Offset: 0x00023704
	[Token(Token = "0x600073D")]
	[Address(RVA = "0x7E0740", Offset = "0x7DED40", VA = "0x1807E0740", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		if (!zombie.HasBuff((EffectType)((uint)2)))
		{
			int num = 0;
			if (!zombie.HasBuff((EffectType)num))
			{
				goto IL_0046;
			}
			int num2 = 0;
			zombie.SetFreeze(4f, num2);
		}
		zombie.Unfreezing();
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num3;
		zombie.TakeDamage(damage, this, (DamageType)((uint)5), fromType, num3 != 0UL);
		IL_0046:
		base.PlaySound(zombie);
		if (!zombie.HasBuff((EffectType)((uint)2)))
		{
			int num4 = 0;
			if (!zombie.HasBuff((EffectType)num4))
			{
				goto IL_009B;
			}
			int num5 = 0;
			zombie.SetFreeze(4f, num5);
		}
		zombie.Unfreezing();
		int damage2 = this._damage;
		PlantType fromType2 = this.fromType;
		ulong num6;
		zombie.TakeDamage(damage2, this, (DamageType)((uint)5), fromType2, num6 != 0UL);
		IL_009B:
		zombie.SetPoison(10f);
		zombie.BeSmall(0.7f);
		base.PlaySound(zombie);
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x000255D0 File Offset: 0x000237D0
	[Token(Token = "0x600073E")]
	[Address(RVA = "0x7E0730", Offset = "0x7DED30", VA = "0x1807E0730")]
	public Bullet_smallIceSpark_sp2()
	{
	}
}
