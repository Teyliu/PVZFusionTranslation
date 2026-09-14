using System;
using Cpp2IlInjected;

// Token: 0x020001A6 RID: 422
[Token(Token = "0x20001A6")]
public class Bullet_smallIceSpark_sp2 : Bullet_smallIceSpark_sp
{
	// Token: 0x0600074A RID: 1866 RVA: 0x00024E3C File Offset: 0x0002303C
	[Token(Token = "0x600074A")]
	[Address(RVA = "0x80DE80", Offset = "0x80C480", VA = "0x18080DE80", Slot = "22")]
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

	// Token: 0x0600074B RID: 1867 RVA: 0x00024F08 File Offset: 0x00023108
	[Token(Token = "0x600074B")]
	[Address(RVA = "0x80DE70", Offset = "0x80C470", VA = "0x18080DE70")]
	public Bullet_smallIceSpark_sp2()
	{
	}
}
