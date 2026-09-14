using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200010A RID: 266
[Token(Token = "0x200010A")]
public class Bullet_bigButter : Bullet_sunCabbage
{
	// Token: 0x0600053E RID: 1342 RVA: 0x0001CA48 File Offset: 0x0001AC48
	[Token(Token = "0x600053E")]
	[Address(RVA = "0x6B7110", Offset = "0x6B5710", VA = "0x1806B7110", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)3L);
		AdvantureData data = AdvantureConfig.data;
		bool flag;
		if (flag)
		{
		}
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x0001CA70 File Offset: 0x0001AC70
	[Token(Token = "0x600053F")]
	[Address(RVA = "0x6B6FE0", Offset = "0x6B55E0", VA = "0x1806B6FE0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
		zombie.Buttered(4f, true);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		float vy = this.Vy;
		float vx = this.Vx;
		float num2 = vy * -0.5f;
		float num3 = vx * 0.5f;
		this.Vy = num2;
		this.Vx = num3;
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x0001CAF8 File Offset: 0x0001ACF8
	[Token(Token = "0x6000540")]
	[Address(RVA = "0x6B6F00", Offset = "0x6B5500", VA = "0x1806B6F00", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x0001CB24 File Offset: 0x0001AD24
	[Token(Token = "0x6000541")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_bigButter()
	{
	}
}
