using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006B2 RID: 1714
[Token(Token = "0x20006B2")]
public class HorseZombie : Zombie
{
	// Token: 0x060020DD RID: 8413 RVA: 0x000ADBFC File Offset: 0x000ABDFC
	[Token(Token = "0x60020DD")]
	[Address(RVA = "0x5B2BD0", Offset = "0x5B11D0", VA = "0x1805B2BD0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		Plant plant = base.CrashEntity(collision, num != 0, 1f);
		int num2 = 0;
		if (plant != num2)
		{
			this.anim.SetTrigger("wait");
			this.theStatus = (ZombieStatus)((ulong)35L);
			GameAPP.PlaySound(141, 0.5f, 1f);
		}
	}

	// Token: 0x060020DE RID: 8414 RVA: 0x000ADC5C File Offset: 0x000ABE5C
	[Token(Token = "0x60020DE")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x060020DF RID: 8415 RVA: 0x000ADC6C File Offset: 0x000ABE6C
	[Token(Token = "0x60020DF")]
	[Address(RVA = "0x5B2B10", Offset = "0x5B1110", VA = "0x1805B2B10", Slot = "33")]
	public override long GetDamage(long theDamage, DamageType theDamageType, bool fix, PlantType fromType = PlantType.Nothing)
	{
		SuperHorse superHorse = this.superHorse;
		int num = 0;
		if (superHorse != num)
		{
		}
		long num2;
		return num2;
	}

	// Token: 0x060020E0 RID: 8416 RVA: 0x000ADC90 File Offset: 0x000ABE90
	[Token(Token = "0x60020E0")]
	[Address(RVA = "0x5B2AB0", Offset = "0x5B10B0", VA = "0x1805B2AB0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		GameAPP.PlaySound(142, 0.5f, 1f);
	}

	// Token: 0x060020E1 RID: 8417 RVA: 0x000ADCB4 File Offset: 0x000ABEB4
	[Token(Token = "0x60020E1")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x060020E2 RID: 8418 RVA: 0x000ADCC4 File Offset: 0x000ABEC4
	[Token(Token = "0x60020E2")]
	[Address(RVA = "0x5B2CD0", Offset = "0x5B12D0", VA = "0x1805B2CD0")]
	public HorseZombie()
	{
	}

	// Token: 0x04001180 RID: 4480
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001180")]
	public SuperHorse superHorse;
}
