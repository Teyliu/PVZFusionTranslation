using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200011E RID: 286
[Token(Token = "0x200011E")]
public class Bullet_cabbage : Bullet
{
	// Token: 0x0600057A RID: 1402 RVA: 0x0001CFAC File Offset: 0x0001B1AC
	[Token(Token = "0x600057A")]
	[Address(RVA = "0x6E4FB0", Offset = "0x6E35B0", VA = "0x1806E4FB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.spriteObject = child;
		throw new NullReferenceException();
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x0001CFDC File Offset: 0x0001B1DC
	[Token(Token = "0x600057B")]
	[Address(RVA = "0x6E5110", Offset = "0x6E3710", VA = "0x1806E5110", Slot = "22")]
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

	// Token: 0x0600057C RID: 1404 RVA: 0x0001D02C File Offset: 0x0001B22C
	[Token(Token = "0x600057C")]
	[Address(RVA = "0x6E5030", Offset = "0x6E3630", VA = "0x1806E5030", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x0001D05C File Offset: 0x0001B25C
	[Token(Token = "0x600057D")]
	[Address(RVA = "0x6E5000", Offset = "0x6E3600", VA = "0x1806E5000", Slot = "15")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x0001D070 File Offset: 0x0001B270
	[Token(Token = "0x600057E")]
	[Address(RVA = "0x6E51E0", Offset = "0x6E37E0", VA = "0x1806E51E0", Slot = "25")]
	public virtual void RotateUpdate()
	{
		Vector2 velocity = this.velocity;
		int num = 0;
		if (velocity <= num)
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

	// Token: 0x0600057F RID: 1407 RVA: 0x0001D0CC File Offset: 0x0001B2CC
	[Token(Token = "0x600057F")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_cabbage()
	{
	}

	// Token: 0x04000367 RID: 871
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000367")]
	protected Transform spriteObject;
}
