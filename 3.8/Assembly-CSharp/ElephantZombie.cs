using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200065C RID: 1628
[Token(Token = "0x200065C")]
public class ElephantZombie : Zombie
{
	// Token: 0x06001F00 RID: 7936 RVA: 0x000A5464 File Offset: 0x000A3664
	[Token(Token = "0x6001F00")]
	[Address(RVA = "0x542EF0", Offset = "0x5414F0", VA = "0x180542EF0", Slot = "29")]
	protected override void BodyTakeDamage(int theDamage)
	{
		ulong num2;
		do
		{
			List<Transform> changeSprites = this.changeSprites;
			bool flag;
			if (flag)
			{
				int num = 0;
				GameObject gameObject;
				Lawnf.ChangeSprite((float)num2, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06001F01 RID: 7937 RVA: 0x000A54A0 File Offset: 0x000A36A0
	[Token(Token = "0x6001F01")]
	[Address(RVA = "0x543240", Offset = "0x541840", VA = "0x180543240", Slot = "43")]
	public override void PlayEatSound()
	{
		if (base.Alive)
		{
			IDamageable theAttackTarget = this.theAttackTarget;
			if (base.CanAttack(theAttackTarget))
			{
				int num = 0;
				int num2 = 0;
				Collider2D collider2D;
				Plant plant = base.CrashEntity(collider2D, num2 != 0, (float)num);
				int num3 = 0;
				num3 += num3;
				num3++;
			}
			this.KnockOthers();
		}
	}

	// Token: 0x06001F02 RID: 7938 RVA: 0x000A54F4 File Offset: 0x000A36F4
	[Token(Token = "0x6001F02")]
	[Address(RVA = "0x543060", Offset = "0x541660", VA = "0x180543060", Slot = "74")]
	protected virtual void KnockOthers()
	{
		Transform shoot = this.shoot;
		int num = 0;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theZombieRow = this.theZombieRow;
				bool flag2;
				if (!Lawnf.InLandStatus((ZombieStatus)num) || !flag2)
				{
				}
			}
			num++;
		}
	}

	// Token: 0x06001F03 RID: 7939 RVA: 0x000A5548 File Offset: 0x000A3748
	[Token(Token = "0x6001F03")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "71")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06001F04 RID: 7940 RVA: 0x000A5558 File Offset: 0x000A3758
	[Token(Token = "0x6001F04")]
	[Address(RVA = "0x543450", Offset = "0x541A50", VA = "0x180543450")]
	public ElephantZombie()
	{
	}
}
