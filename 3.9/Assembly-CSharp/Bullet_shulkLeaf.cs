using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000198 RID: 408
[Token(Token = "0x2000198")]
public class Bullet_shulkLeaf : Bullet_pierce
{
	// Token: 0x06000718 RID: 1816 RVA: 0x000240E4 File Offset: 0x000222E4
	[Token(Token = "0x6000718")]
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

	// Token: 0x06000719 RID: 1817 RVA: 0x00024114 File Offset: 0x00022314
	[Token(Token = "0x6000719")]
	[Address(RVA = "0x807150", Offset = "0x805750", VA = "0x180807150", Slot = "25")]
	protected override void SetPenetrationTime()
	{
		this.maxHitCount = (int)((ulong)2147483647L);
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00024134 File Offset: 0x00022334
	[Token(Token = "0x600071A")]
	[Address(RVA = "0x80C0F0", Offset = "0x80A6F0", VA = "0x18080C0F0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		int damage = this._damage;
		int num = 0;
		PlantType fromType = this.fromType;
		ulong num2;
		zombie.TakeDamage(damage, this, (DamageType)num, fromType, num2 != 0UL);
		base.PlaySound(zombie);
		base.MoveWay = (BulletMoveWay)((uint)5);
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x00024174 File Offset: 0x00022374
	[Token(Token = "0x600071B")]
	[Address(RVA = "0x80C070", Offset = "0x80A670", VA = "0x18080C070", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x000241A0 File Offset: 0x000223A0
	[Token(Token = "0x600071C")]
	[Address(RVA = "0x80BFD0", Offset = "0x80A5D0", VA = "0x18080BFD0", Slot = "15")]
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

	// Token: 0x0600071D RID: 1821 RVA: 0x000241FC File Offset: 0x000223FC
	[Token(Token = "0x600071D")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_shulkLeaf()
	{
	}

	// Token: 0x04000397 RID: 919
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000397")]
	private Transform spriteObject;
}
