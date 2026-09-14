using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000155 RID: 341
[Token(Token = "0x2000155")]
public class Bullet_iceTrack : Bullet
{
	// Token: 0x0600063B RID: 1595 RVA: 0x00021350 File Offset: 0x0001F550
	[Token(Token = "0x600063B")]
	[Address(RVA = "0x6C70E0", Offset = "0x6C56E0", VA = "0x1806C70E0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = this._damage;
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		uint num2;
		if (flag && global::UnityEngine.Random.Range(0, (int)num2) == 0)
		{
			int num3 = 0;
			int num4 = 0;
			zombie.SetCold(5f, num4, num3 != 0);
		}
		if (zombie == 0)
		{
		}
		int num5 = 0;
		if (zombie.HasBuff((EffectType)num5))
		{
			num += num;
		}
		int num6 = 0;
		PlantType fromType = this.fromType;
		ulong num7;
		zombie.TakeDamage(num, this, (DamageType)num6, fromType, num7 != 0UL);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x000213D0 File Offset: 0x0001F5D0
	[Token(Token = "0x600063C")]
	[Address(RVA = "0x6C7060", Offset = "0x6C5660", VA = "0x1806C7060", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x000213FC File Offset: 0x0001F5FC
	[Token(Token = "0x600063D")]
	[Address(RVA = "0x6C6FE0", Offset = "0x6C55E0", VA = "0x1806C6FE0", Slot = "14")]
	protected override Zombie GetNearestZombie()
	{
		Zombie nearestFreezedZombie = this.GetNearestFreezedZombie();
		int num = 0;
		if (!(nearestFreezedZombie != num))
		{
			return base.GetNearestZombie();
		}
		return nearestFreezedZombie;
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x00021424 File Offset: 0x0001F624
	[Token(Token = "0x600063E")]
	[Address(RVA = "0x6C6C60", Offset = "0x6C5260", VA = "0x1806C6C60")]
	private Zombie GetNearestFreezedZombie()
	{
		int num2;
		do
		{
			int num = 0;
			num2 = 0;
			List<Zombie> zombieArray = Board.Instance.zombieArray;
			bool flag;
			if (flag)
			{
				int num3 = 0;
				if (!(num != num3))
				{
					continue;
				}
				while (num != 0)
				{
				}
				if (!base.NearestZombieCondition(num))
				{
					continue;
				}
				bool flag2;
				while (!flag2)
				{
				}
				Transform transform = base.transform;
				Vector3 vector;
				float z = vector.z;
				Transform transform2 = base.transform;
				Vector3 vector2;
				float z2 = vector2.z;
			}
		}
		while (num2 != 0);
		throw new NullReferenceException();
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x000214B4 File Offset: 0x0001F6B4
	[Token(Token = "0x600063F")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_iceTrack()
	{
	}
}
