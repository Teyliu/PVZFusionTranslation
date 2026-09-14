using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000692 RID: 1682
[Token(Token = "0x2000692")]
public class ElephantZombie : Zombie
{
	// Token: 0x06002002 RID: 8194 RVA: 0x000A9BE0 File Offset: 0x000A7DE0
	[Token(Token = "0x6002002")]
	[Address(RVA = "0x5A5510", Offset = "0x5A3B10", VA = "0x1805A5510", Slot = "30")]
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
				Lawnf.ChangeSprite((float)0, (float)num, gameObject);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002003 RID: 8195 RVA: 0x000A9C18 File Offset: 0x000A7E18
	[Token(Token = "0x6002003")]
	[Address(RVA = "0x5A5860", Offset = "0x5A3E60", VA = "0x1805A5860", Slot = "45")]
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

	// Token: 0x06002004 RID: 8196 RVA: 0x000A9C6C File Offset: 0x000A7E6C
	[Token(Token = "0x6002004")]
	[Address(RVA = "0x5A5680", Offset = "0x5A3C80", VA = "0x1805A5680", Slot = "76")]
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

	// Token: 0x06002005 RID: 8197 RVA: 0x000A9CC0 File Offset: 0x000A7EC0
	[Token(Token = "0x6002005")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "73")]
	public override void KnockBack(float x, Zombie.KnockBackReason reason = Zombie.KnockBackReason.ByUmbrella)
	{
	}

	// Token: 0x06002006 RID: 8198 RVA: 0x000A9CD0 File Offset: 0x000A7ED0
	[Token(Token = "0x6002006")]
	[Address(RVA = "0x5A5A70", Offset = "0x5A4070", VA = "0x1805A5A70")]
	public ElephantZombie()
	{
	}
}
