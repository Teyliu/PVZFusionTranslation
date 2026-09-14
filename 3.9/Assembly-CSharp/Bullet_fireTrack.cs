using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000147 RID: 327
[Token(Token = "0x2000147")]
public class Bullet_fireTrack : Bullet
{
	// Token: 0x0600060A RID: 1546 RVA: 0x0001FAB4 File Offset: 0x0001DCB4
	[Token(Token = "0x600060A")]
	[Address(RVA = "0x6EE8D0", Offset = "0x6ECED0", VA = "0x1806EE8D0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)37), (MissionResult)((uint)2)) && global::UnityEngine.Random.Range(0, 10) == 0)
		{
			zombie.SetJalaed();
		}
		int damage = this._damage;
		if (zombie.HasBuff((EffectType)((uint)1)))
		{
		}
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x0001FB20 File Offset: 0x0001DD20
	[Token(Token = "0x600060B")]
	[Address(RVA = "0x6EE850", Offset = "0x6ECE50", VA = "0x1806EE850", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x0001FB4C File Offset: 0x0001DD4C
	[Token(Token = "0x600060C")]
	[Address(RVA = "0x6EE4E0", Offset = "0x6ECAE0", VA = "0x1806EE4E0", Slot = "24")]
	protected override Zombie GetNearestZombie()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			Transform transform = base.transform;
			List<Zombie> zombieArray = this.board.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3) || !this.bulletMovement.CanSearch(num))
				{
					continue;
				}
				bool flag2;
				if (!flag2)
				{
				}
			}
		}
		while (num2 != 0);
		int num4 = 0;
		if (!(num2 != num4))
		{
			int num5 = 0;
			bool flag3 = num2 != num5;
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x0001FBD4 File Offset: 0x0001DDD4
	[Token(Token = "0x600060D")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_fireTrack()
	{
	}
}
