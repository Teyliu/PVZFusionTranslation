using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001A0 RID: 416
[Token(Token = "0x20001A0")]
public class Bullet_smallSun : Bullet_pea
{
	// Token: 0x0600073F RID: 1855 RVA: 0x000255E4 File Offset: 0x000237E4
	[Token(Token = "0x600073F")]
	[Address(RVA = "0x7E0AF0", Offset = "0x7DF0F0", VA = "0x1807E0AF0", Slot = "9")]
	protected override void Awake()
	{
		base.Awake();
		Animator component = base.GetComponent<Animator>();
		this.Animator = component;
		this.Animator.enabled = true;
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00025618 File Offset: 0x00023818
	[Token(Token = "0x6000740")]
	[Address(RVA = "0x7E1180", Offset = "0x7DF780", VA = "0x1807E1180", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
		Animator animator = this.Animator;
		int num = 0;
		animator.enabled = num != 0;
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00025644 File Offset: 0x00023844
	[Token(Token = "0x6000741")]
	[Address(RVA = "0x7E0B70", Offset = "0x7DF170", VA = "0x1807E0B70", Slot = "16")]
	protected override void FixedUpdate()
	{
		int num;
		do
		{
			num = 0;
			base.FixedUpdate();
			Transform transform = base.transform;
			int num2 = 0;
			IEnumerator enumerator = transform.GetEnumerator();
			int num3 = 0;
			if (num < num2)
			{
				num += num;
				num++;
			}
			num += num;
			num++;
			enumerator += enumerator;
			enumerator += enumerator;
			Vector2 velocity = this.rb.velocity;
			if (velocity <= num3)
			{
				float deltaTime = Time.deltaTime;
			}
			float deltaTime2 = Time.deltaTime;
		}
		while (num != 0);
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x000256D8 File Offset: 0x000238D8
	[Token(Token = "0x6000742")]
	[Address(RVA = "0x7E1000", Offset = "0x7DF600", VA = "0x1807E1000", Slot = "25")]
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
		Transform transform2 = base.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		base.Die();
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x00025740 File Offset: 0x00023940
	[Token(Token = "0x6000743")]
	[Address(RVA = "0x7E0E80", Offset = "0x7DF480", VA = "0x1807E0E80", Slot = "18")]
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

	// Token: 0x06000744 RID: 1860 RVA: 0x00025784 File Offset: 0x00023984
	[Token(Token = "0x6000744")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_smallSun()
	{
	}

	// Token: 0x04000393 RID: 915
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000393")]
	private Animator Animator;
}
