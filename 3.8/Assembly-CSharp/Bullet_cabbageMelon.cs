using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000119 RID: 281
[Token(Token = "0x2000119")]
public class Bullet_cabbageMelon : Bullet_sunCabbage
{
	// Token: 0x0600056F RID: 1391 RVA: 0x0001D760 File Offset: 0x0001B960
	[Token(Token = "0x600056F")]
	[Address(RVA = "0x6BA0B0", Offset = "0x6B86B0", VA = "0x1806BA0B0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)2L);
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x0001D778 File Offset: 0x0001B978
	[Token(Token = "0x6000570")]
	[Address(RVA = "0x6B9E50", Offset = "0x6B8450", VA = "0x1806B9E50", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		this.AttackOtherZombie(num, 1);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x0001D7C4 File Offset: 0x0001B9C4
	[Token(Token = "0x6000571")]
	[Address(RVA = "0x6B9F40", Offset = "0x6B8540", VA = "0x1806B9F40", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		this.AttackOtherZombie(zombie, 1);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(104, 106), 0.5f, 1f);
		float num2 = this.Vy * -0.5f;
		this.Vy = num2;
		float num3 = this.Vx * 0.5f;
		this.Vx = num3;
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x0001D854 File Offset: 0x0001BA54
	[Token(Token = "0x6000572")]
	[Address(RVA = "0x6B95E0", Offset = "0x6B7BE0", VA = "0x1806B95E0")]
	protected void AttackOtherZombie(Zombie targetZombie, int damageType)
	{
		ulong num10;
		do
		{
			int num = 0;
			List<Zombie> list = new List();
			int damage = this._damage;
			Transform transform = base.transform;
			Vector3 vector;
			float z = vector.z;
			LayerMask zombieLayer = this.zombieLayer;
			int num2 = 0;
			int num3 = 0;
			Collider2D[] array;
			if (num3 < array.Length)
			{
				bool flag;
				if (flag)
				{
					int num4 = 0;
					bool flag2;
					if (!flag2 && num4 != 3)
					{
						if (18446744073709551607UL <= (ulong)15L)
						{
						}
						if (num4 != 44)
						{
						}
					}
				}
				num2++;
			}
			if (list._size == 0)
			{
				break;
			}
			bool flag3;
			if (flag3)
			{
				PlantType fromType = this.fromType;
			}
			ulong num5;
			if (num5 != (ulong)0L)
			{
				goto IL_00D0;
			}
			int num6;
			if (num6 == -1)
			{
				bool flag4;
				if (flag4)
				{
				}
				ulong num7;
				if (num7 != (ulong)0L)
				{
					goto IL_00D6;
				}
			}
			int num8;
			if (num8 == 3)
			{
				bool flag5;
				if (flag5)
				{
					PlantType fromType2 = this.fromType;
					if (num == 0)
					{
					}
				}
				ulong num9;
				if (num9 != (ulong)0L)
				{
					goto IL_00DC;
				}
			}
			bool flag6;
			if (flag6)
			{
			}
		}
		while (num10 != (ulong)0L);
		return;
		IL_00D0:
		throw new NullReferenceException();
		IL_00D6:
		throw new NullReferenceException();
		IL_00DC:
		throw new NullReferenceException();
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x0001D944 File Offset: 0x0001BB44
	[Token(Token = "0x6000573")]
	[Address(RVA = "0x6B71A0", Offset = "0x6B57A0", VA = "0x1806B71A0")]
	public Bullet_cabbageMelon()
	{
	}
}
