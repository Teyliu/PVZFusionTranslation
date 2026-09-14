using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001CB RID: 459
[Token(Token = "0x20001CB")]
public class Bullet_threeSpike : Bullet_pierce
{
	// Token: 0x060007D0 RID: 2000 RVA: 0x00027668 File Offset: 0x00025868
	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x807150", Offset = "0x805750", VA = "0x180807150", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)2147483647L);
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x00027688 File Offset: 0x00025888
	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x815380", Offset = "0x813980", VA = "0x180815380", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(5, this, (DamageType)((uint)4), fromType, num != 0UL);
		if (AdvantureConfig.data.GetResult((AdvantureLevel)((uint)30), (MissionResult)((uint)2)))
		{
		}
		if (zombie.theZombieType == ZombieType.UltimateJacksonDriver)
		{
		}
		PlantType fromType2 = this.fromType;
		base.Die();
		base.PlaySound(zombie);
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x000276E4 File Offset: 0x000258E4
	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x815300", Offset = "0x813900", VA = "0x180815300", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x00027710 File Offset: 0x00025910
	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_threeSpike()
	{
	}
}
