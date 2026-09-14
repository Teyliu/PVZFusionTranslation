using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001C9 RID: 457
[Token(Token = "0x20001C9")]
public class Bullet_ultimateSun : Bullet_pierce
{
	// Token: 0x060007DC RID: 2012 RVA: 0x00028970 File Offset: 0x00026B70
	[Token(Token = "0x60007DC")]
	[Address(RVA = "0x6BB4F0", Offset = "0x6B9AF0", VA = "0x1806BB4F0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)1L);
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x00028988 File Offset: 0x00026B88
	[Token(Token = "0x60007DD")]
	[Address(RVA = "0x7EA590", Offset = "0x7E8B90", VA = "0x1807EA590")]
	private void Explode(Vector2 center, int damage, float range = 1.5f)
	{
		int num = 0;
		ParticleManager instance = ParticleManager.Instance;
		LayerMask zombieLayer = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag && Lawnf.InLandStatus((ZombieStatus)num))
			{
				PlantType fromType = this.fromType;
			}
			num++;
		}
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x000289D4 File Offset: 0x00026BD4
	[Token(Token = "0x60007DE")]
	[Address(RVA = "0x7EA8D0", Offset = "0x7E8ED0", VA = "0x1807EA8D0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		Transform transform = base.transform;
		Transform transform2 = base.transform;
		int mask = LayerMask.GetMask(new string[] { "Bullet" });
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && flag2)
			{
				Team <Team>k__BackingField = this.<Team>k__BackingField;
				Transform transform3;
				transform3 += transform3;
				base.Die();
			}
			num++;
		}
		CreateItem instance = CreateItem.Instance;
		Transform transform4 = base.transform;
		Vector3 vector;
		float z = vector.z;
		uint num2;
		GameAPP.PlaySound((int)num2, 0.2f, 1f);
	}

	// Token: 0x060007DF RID: 2015 RVA: 0x00028A74 File Offset: 0x00026C74
	[Token(Token = "0x60007DF")]
	[Address(RVA = "0x7EA760", Offset = "0x7E8D60", VA = "0x1807EA760", Slot = "18")]
	public override void HitLand()
	{
		CreateItem instance = CreateItem.Instance;
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		base.Die();
	}

	// Token: 0x060007E0 RID: 2016 RVA: 0x00028AB8 File Offset: 0x00026CB8
	[Token(Token = "0x60007E0")]
	[Address(RVA = "0x7EA540", Offset = "0x7E8B40", VA = "0x1807EA540", Slot = "9")]
	protected override void Awake()
	{
		base.Awake();
		Transform child = base.transform.GetChild(1);
		this.tail = child;
		throw new NullReferenceException();
	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x00028AE4 File Offset: 0x00026CE4
	[Token(Token = "0x60007E1")]
	[Address(RVA = "0x7EAD30", Offset = "0x7E9330", VA = "0x1807EAD30", Slot = "11")]
	protected override void Update()
	{
		base.Update();
		Rigidbody2D rb = this.rb;
		Transform transform = this.tail;
		Vector2 velocity = rb.velocity;
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x00028B14 File Offset: 0x00026D14
	[Token(Token = "0x60007E2")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_ultimateSun()
	{
	}

	// Token: 0x040003B3 RID: 947
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40003B3")]
	private Transform tail;
}
