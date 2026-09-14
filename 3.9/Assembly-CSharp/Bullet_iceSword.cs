using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200015A RID: 346
[Token(Token = "0x200015A")]
public class Bullet_iceSword : Bullet
{
	// Token: 0x06000643 RID: 1603 RVA: 0x00020C7C File Offset: 0x0001EE7C
	[Token(Token = "0x6000643")]
	[Address(RVA = "0x6F2430", Offset = "0x6F0A30", VA = "0x1806F2430", Slot = "21")]
	protected override void HitPlant(Plant plant)
	{
		plant.FlashOnce();
		int num = 0;
		plant.TryBeDisable(5f, num != 0);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(0, 3), 0.5f, 1f);
		base.Die();
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00020CC0 File Offset: 0x0001EEC0
	[Token(Token = "0x6000644")]
	[Address(RVA = "0x6F2320", Offset = "0x6F0920", VA = "0x1806F2320", Slot = "15")]
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

	// Token: 0x06000645 RID: 1605 RVA: 0x00020D04 File Offset: 0x0001EF04
	[Token(Token = "0x6000645")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_iceSword()
	{
	}
}
