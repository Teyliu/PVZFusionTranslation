using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000154 RID: 340
[Token(Token = "0x2000154")]
public class Bullet_iceSword : Bullet
{
	// Token: 0x06000638 RID: 1592 RVA: 0x000212B4 File Offset: 0x0001F4B4
	[Token(Token = "0x6000638")]
	[Address(RVA = "0x6C6B70", Offset = "0x6C5170", VA = "0x1806C6B70", Slot = "24")]
	protected override void HitPlant(Plant plant)
	{
		plant.FlashOnce();
		plant.TryBeDisable(5f);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x000212F8 File Offset: 0x0001F4F8
	[Token(Token = "0x6000639")]
	[Address(RVA = "0x6C6A60", Offset = "0x6C5060", VA = "0x1806C6A60", Slot = "16")]
	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		Rigidbody2D rb = this.rb;
		Vector2 velocity = rb.velocity;
		Vector3 vector;
		float z = vector.z;
		Vector3 vector2;
		float z2 = vector2.z;
		rb.rotation = z2;
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x0002133C File Offset: 0x0001F53C
	[Token(Token = "0x600063A")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_iceSword()
	{
	}
}
