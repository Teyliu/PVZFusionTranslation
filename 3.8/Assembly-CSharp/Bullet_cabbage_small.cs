using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200011E RID: 286
[Token(Token = "0x200011E")]
public class Bullet_cabbage_small : Bullet_sunCabbage
{
	// Token: 0x06000582 RID: 1410 RVA: 0x0001DE0C File Offset: 0x0001C00C
	[Token(Token = "0x6000582")]
	[Address(RVA = "0x6BB740", Offset = "0x6B9D40", VA = "0x1806BB740", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
		this.smallEffect = false;
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x0001DE28 File Offset: 0x0001C028
	[Token(Token = "0x6000583")]
	[Address(RVA = "0x6BB760", Offset = "0x6B9D60", VA = "0x1806BB760", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)3L);
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x0001DE40 File Offset: 0x0001C040
	[Token(Token = "0x6000584")]
	[Address(RVA = "0x6BB5E0", Offset = "0x6B9BE0", VA = "0x1806BB5E0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		if (!zombie.isSmall)
		{
			if (!this.smallEffect)
			{
				goto IL_0024;
			}
			zombie.BeSmall(0.7f);
		}
		this.smallEffect = true;
		IL_0024:
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		base.PlaySound(zombie);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		float num2 = this.Vy * -1f;
		this.Vy = num2;
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x0001DEC8 File Offset: 0x0001C0C8
	[Token(Token = "0x6000585")]
	[Address(RVA = "0x6BB500", Offset = "0x6B9B00", VA = "0x1806BB500", Slot = "18")]
	public override void HitLand()
	{
		this.hit = true;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x0001DF10 File Offset: 0x0001C110
	[Token(Token = "0x6000586")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_cabbage_small()
	{
	}

	// Token: 0x04000359 RID: 857
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000359")]
	protected bool smallEffect;
}
