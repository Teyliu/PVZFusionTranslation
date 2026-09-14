using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000137 RID: 311
[Token(Token = "0x2000137")]
public class Bullet_doomCactus : Bullet_pierce
{
	// Token: 0x060005CF RID: 1487 RVA: 0x0001E94C File Offset: 0x0001CB4C
	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x6E65D0", Offset = "0x6E4BD0", VA = "0x1806E65D0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)3L);
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x0001E964 File Offset: 0x0001CB64
	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x6EA8D0", Offset = "0x6E8ED0", VA = "0x1806EA8D0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		base.PlaySound(zombie);
		throw new NullReferenceException();
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x0001E9B0 File Offset: 0x0001CBB0
	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x6EA7F0", Offset = "0x6E8DF0", VA = "0x1806EA7F0", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x0001E9DC File Offset: 0x0001CBDC
	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_doomCactus()
	{
	}
}
