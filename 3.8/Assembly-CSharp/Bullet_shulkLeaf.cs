using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000191 RID: 401
[Token(Token = "0x2000191")]
public class Bullet_shulkLeaf : Bullet_pierce
{
	// Token: 0x0600070B RID: 1803 RVA: 0x000247A4 File Offset: 0x000229A4
	[Token(Token = "0x600070B")]
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

	// Token: 0x0600070C RID: 1804 RVA: 0x000247D4 File Offset: 0x000229D4
	[Token(Token = "0x600070C")]
	[Address(RVA = "0x7D98C0", Offset = "0x7D7EC0", VA = "0x1807D98C0", Slot = "27")]
	protected override void SetPenetrationTime()
	{
		this.penetrationTimes = (int)((ulong)2147483647L);
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x000247F4 File Offset: 0x000229F4
	[Token(Token = "0x600070D")]
	[Address(RVA = "0x7DE980", Offset = "0x7DCF80", VA = "0x1807DE980", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		base.PlaySound(zombie);
		base.MoveWay = (BulletMoveWay)((uint)2);
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x00024834 File Offset: 0x00022A34
	[Token(Token = "0x600070E")]
	[Address(RVA = "0x7DE900", Offset = "0x7DCF00", VA = "0x1807DE900", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x00024860 File Offset: 0x00022A60
	[Token(Token = "0x600070F")]
	[Address(RVA = "0x7DE860", Offset = "0x7DCE60", VA = "0x1807DE860", Slot = "16")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Vector2 velocity = this.rb.velocity;
		Transform transform = this.spriteObject;
		int num = 0;
		if (velocity <= num)
		{
			float deltaTime = Time.deltaTime;
		}
		float num2 = Time.deltaTime * -600f;
		int num3 = 0;
		int num4 = 0;
		transform.Rotate((float)num4, (float)num3, num2);
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x000248BC File Offset: 0x00022ABC
	[Token(Token = "0x6000710")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_shulkLeaf()
	{
	}

	// Token: 0x0400038E RID: 910
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400038E")]
	private Transform spriteObject;
}
