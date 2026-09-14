using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C1 RID: 449
[Token(Token = "0x20001C1")]
public class Bullet_threeSpike : Bullet
{
	// Token: 0x060007BA RID: 1978 RVA: 0x00027B78 File Offset: 0x00025D78
	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x7E7B70", Offset = "0x7E6170", VA = "0x1807E7B70", Slot = "25")]
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
		this.hit = false;
		base.PlaySound(zombie);
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x00027BDC File Offset: 0x00025DDC
	[Token(Token = "0x60007BB")]
	[Address(RVA = "0x7E7AF0", Offset = "0x7E60F0", VA = "0x1807E7AF0", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x00027C08 File Offset: 0x00025E08
	[Token(Token = "0x60007BC")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_threeSpike()
	{
	}
}
