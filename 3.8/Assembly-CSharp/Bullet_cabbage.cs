using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000118 RID: 280
[Token(Token = "0x2000118")]
public class Bullet_cabbage : Bullet
{
	// Token: 0x06000569 RID: 1385 RVA: 0x0001D62C File Offset: 0x0001B82C
	[Token(Token = "0x6000569")]
	[Address(RVA = "0x6BA0C0", Offset = "0x6B86C0", VA = "0x1806BA0C0", Slot = "9")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.spriteObject = child;
		throw new NullReferenceException();
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x0001D65C File Offset: 0x0001B85C
	[Token(Token = "0x600056A")]
	[Address(RVA = "0x6BA220", Offset = "0x6B8820", VA = "0x1806BA220", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num;
		zombie.TakeDamage(damage, this, (DamageType)((uint)4), fromType, num != 0UL);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.PlaySound(zombie);
		base.Die();
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x0001D6AC File Offset: 0x0001B8AC
	[Token(Token = "0x600056B")]
	[Address(RVA = "0x6BA140", Offset = "0x6B8740", VA = "0x1806BA140", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x0001D6DC File Offset: 0x0001B8DC
	[Token(Token = "0x600056C")]
	[Address(RVA = "0x6BA110", Offset = "0x6B8710", VA = "0x1806BA110", Slot = "16")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x0001D6F0 File Offset: 0x0001B8F0
	[Token(Token = "0x600056D")]
	[Address(RVA = "0x6BA2F0", Offset = "0x6B88F0", VA = "0x1806BA2F0", Slot = "27")]
	public virtual void RotateUpdate()
	{
		float vx = this.Vx;
		int num = 0;
		if (vx <= (float)num)
		{
			Transform transform = this.spriteObject;
			float fixedDeltaTime = Time.fixedDeltaTime;
		}
		Transform transform2 = this.spriteObject;
		float num2 = Time.fixedDeltaTime * -300f;
		int num3 = 0;
		int num4 = 0;
		transform2.Rotate((float)num4, (float)num3, num2);
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x0001D74C File Offset: 0x0001B94C
	[Token(Token = "0x600056E")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_cabbage()
	{
	}

	// Token: 0x04000358 RID: 856
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000358")]
	protected Transform spriteObject;
}
