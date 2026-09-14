using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200011F RID: 287
[Token(Token = "0x200011F")]
public class Bullet_cabbageMelon : Bullet_sunCabbage
{
	// Token: 0x06000580 RID: 1408 RVA: 0x0001D0E0 File Offset: 0x0001B2E0
	[Token(Token = "0x6000580")]
	[Address(RVA = "0x6E4FA0", Offset = "0x6E35A0", VA = "0x1806E4FA0", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)2L);
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x0001D0F8 File Offset: 0x0001B2F8
	[Token(Token = "0x6000581")]
	[Address(RVA = "0x6E4D40", Offset = "0x6E3340", VA = "0x1806E4D40", Slot = "17")]
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

	// Token: 0x06000582 RID: 1410 RVA: 0x0001D144 File Offset: 0x0001B344
	[Token(Token = "0x6000582")]
	[Address(RVA = "0x6E4E30", Offset = "0x6E3430", VA = "0x1806E4E30", Slot = "22")]
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
		float num2 = this.velocity.y * -0.5f;
		this.velocity.y = num2;
		float num3 = this.velocity * 0.5f;
		this.velocity = num3;
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x0001D1E0 File Offset: 0x0001B3E0
	[Token(Token = "0x6000583")]
	[Address(RVA = "0x6E44D0", Offset = "0x6E2AD0", VA = "0x1806E44D0")]
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

	// Token: 0x06000584 RID: 1412 RVA: 0x0001D2D0 File Offset: 0x0001B4D0
	[Token(Token = "0x6000584")]
	[Address(RVA = "0x6E2090", Offset = "0x6E0690", VA = "0x1806E2090")]
	public Bullet_cabbageMelon()
	{
	}
}
