using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200015B RID: 347
[Token(Token = "0x200015B")]
public class Bullet_iceTrack : Bullet
{
	// Token: 0x06000646 RID: 1606 RVA: 0x00020D18 File Offset: 0x0001EF18
	[Token(Token = "0x6000646")]
	[Address(RVA = "0x6F2910", Offset = "0x6F0F10", VA = "0x1806F2910", Slot = "22")]
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

	// Token: 0x06000647 RID: 1607 RVA: 0x00020D98 File Offset: 0x0001EF98
	[Token(Token = "0x6000647")]
	[Address(RVA = "0x6F2890", Offset = "0x6F0E90", VA = "0x1806F2890", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00020DC4 File Offset: 0x0001EFC4
	[Token(Token = "0x6000648")]
	[Address(RVA = "0x6F2520", Offset = "0x6F0B20", VA = "0x1806F2520", Slot = "24")]
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

	// Token: 0x06000649 RID: 1609 RVA: 0x00020E50 File Offset: 0x0001F050
	[Token(Token = "0x6000649")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_iceTrack()
	{
	}
}
