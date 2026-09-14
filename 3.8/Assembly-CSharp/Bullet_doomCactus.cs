using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000132 RID: 306
[Token(Token = "0x2000132")]
public class Bullet_doomCactus : Bullet_pierce
{
	// Token: 0x060005C8 RID: 1480 RVA: 0x0001F17C File Offset: 0x0001D37C
	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x6BB4F0", Offset = "0x6B9AF0", VA = "0x1806BB4F0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)1L);
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x0001F194 File Offset: 0x0001D394
	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x6BFB10", Offset = "0x6BE110", VA = "0x1806BFB10", Slot = "25")]
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
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x0001F1E0 File Offset: 0x0001D3E0
	[Token(Token = "0x60005CA")]
	[Address(RVA = "0x6BFA30", Offset = "0x6BE030", VA = "0x1806BFA30", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x0001F20C File Offset: 0x0001D40C
	[Token(Token = "0x60005CB")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_doomCactus()
	{
	}
}
