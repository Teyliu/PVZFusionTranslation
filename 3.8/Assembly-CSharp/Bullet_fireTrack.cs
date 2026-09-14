using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000142 RID: 322
[Token(Token = "0x2000142")]
public class Bullet_fireTrack : Bullet
{
	// Token: 0x06000603 RID: 1539 RVA: 0x000202B8 File Offset: 0x0001E4B8
	[Token(Token = "0x6000603")]
	[Address(RVA = "0x6C3750", Offset = "0x6C1D50", VA = "0x1806C3750", Slot = "25")]
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

	// Token: 0x06000604 RID: 1540 RVA: 0x00020320 File Offset: 0x0001E520
	[Token(Token = "0x6000604")]
	[Address(RVA = "0x6C36D0", Offset = "0x6C1CD0", VA = "0x1806C36D0", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x0002034C File Offset: 0x0001E54C
	[Token(Token = "0x6000605")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_fireTrack()
	{
	}
}
