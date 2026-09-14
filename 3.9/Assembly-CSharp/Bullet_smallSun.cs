using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020001A7 RID: 423
[Token(Token = "0x20001A7")]
public class Bullet_smallSun : Bullet_pea
{
	// Token: 0x0600074C RID: 1868 RVA: 0x00024F1C File Offset: 0x0002311C
	[Token(Token = "0x600074C")]
	[Address(RVA = "0x80E230", Offset = "0x80C830", VA = "0x18080E230", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Animator component = base.GetComponent<Animator>();
		this.Animator = component;
		this.Animator.enabled = true;
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x00024F50 File Offset: 0x00023150
	[Token(Token = "0x600074D")]
	[Address(RVA = "0x80E8C0", Offset = "0x80CEC0", VA = "0x18080E8C0", Slot = "9")]
	public override void InitData()
	{
		base.InitData();
		Animator animator = this.Animator;
		int num = 0;
		animator.enabled = num != 0;
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x00024F7C File Offset: 0x0002317C
	[Token(Token = "0x600074E")]
	[Address(RVA = "0x80E2B0", Offset = "0x80C8B0", VA = "0x18080E2B0", Slot = "15")]
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

	// Token: 0x0600074F RID: 1871 RVA: 0x00025010 File Offset: 0x00023210
	[Token(Token = "0x600074F")]
	[Address(RVA = "0x80E740", Offset = "0x80CD40", VA = "0x18080E740", Slot = "22")]
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

	// Token: 0x06000750 RID: 1872 RVA: 0x00025078 File Offset: 0x00023278
	[Token(Token = "0x6000750")]
	[Address(RVA = "0x80E5C0", Offset = "0x80CBC0", VA = "0x18080E5C0", Slot = "17")]
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

	// Token: 0x06000751 RID: 1873 RVA: 0x000250BC File Offset: 0x000232BC
	[Token(Token = "0x6000751")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_smallSun()
	{
	}

	// Token: 0x0400039C RID: 924
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400039C")]
	private Animator Animator;
}
