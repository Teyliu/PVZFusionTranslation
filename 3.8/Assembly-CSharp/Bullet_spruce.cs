using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001A5 RID: 421
[Token(Token = "0x20001A5")]
public class Bullet_spruce : Bullet_pierce
{
	// Token: 0x06000756 RID: 1878 RVA: 0x00025EC0 File Offset: 0x000240C0
	[Token(Token = "0x6000756")]
	[Address(RVA = "0x6BA0B0", Offset = "0x6B86B0", VA = "0x1806BA0B0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)2L);
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x00025ED8 File Offset: 0x000240D8
	[Token(Token = "0x6000757")]
	[Address(RVA = "0x7E33D0", Offset = "0x7E19D0", VA = "0x1807E33D0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x00025F0C File Offset: 0x0002410C
	[Token(Token = "0x6000758")]
	[Address(RVA = "0x7E3320", Offset = "0x7E1920", VA = "0x1807E3320", Slot = "19")]
	public override void HitBlock()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		int num = this.hitTimes;
		num++;
		this.hitTimes = num;
		this.hit = false;
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x00025F50 File Offset: 0x00024150
	[Token(Token = "0x6000759")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_spruce()
	{
	}
}
