using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000137 RID: 311
[Token(Token = "0x2000137")]
public class Bullet_endoSun : Bullet
{
	// Token: 0x060005DB RID: 1499 RVA: 0x0001F86C File Offset: 0x0001DA6C
	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x6C1A40", Offset = "0x6C0040", VA = "0x1806C1A40", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		CreateItem instance = CreateItem.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x060005DC RID: 1500 RVA: 0x0001F8C8 File Offset: 0x0001DAC8
	[Token(Token = "0x60005DC")]
	[Address(RVA = "0x6C18B0", Offset = "0x6BFEB0", VA = "0x1806C18B0", Slot = "18")]
	public override void HitLand()
	{
		CreateItem instance = CreateItem.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		CreateItem instance2 = CreateItem.Instance;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		base.Die();
	}

	// Token: 0x060005DD RID: 1501 RVA: 0x0001F914 File Offset: 0x0001DB14
	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x6C17E0", Offset = "0x6BFDE0", VA = "0x1806C17E0", Slot = "16")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Vector2 velocity = this.rb.velocity;
		int num = 0;
		if (velocity <= num)
		{
			Transform transform = base.transform;
			int num2 = 0;
			Transform child = transform.GetChild(num2);
			float deltaTime = Time.deltaTime;
		}
		Transform transform2 = base.transform;
		int num3 = 0;
		Transform child2 = transform2.GetChild(num3);
		float num4 = Time.deltaTime * -600f;
		int num5 = 0;
		int num6 = 0;
		child2.Rotate((float)num6, (float)num5, num4);
	}

	// Token: 0x060005DE RID: 1502 RVA: 0x0001F998 File Offset: 0x0001DB98
	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_endoSun()
	{
	}
}
