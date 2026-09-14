using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200013D RID: 317
[Token(Token = "0x200013D")]
public class Bullet_firePea : Bullet
{
	// Token: 0x060005F2 RID: 1522 RVA: 0x0001FF34 File Offset: 0x0001E134
	[Token(Token = "0x60005F2")]
	[Address(RVA = "0x6BA0C0", Offset = "0x6B86C0", VA = "0x1806BA0C0", Slot = "9")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.tail = child;
		throw new NullReferenceException();
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x0001FF64 File Offset: 0x0001E164
	[Token(Token = "0x60005F3")]
	[Address(RVA = "0x6C2E00", Offset = "0x6C1400", VA = "0x1806C2E00", Slot = "11")]
	protected override void Update()
	{
		base.Update();
		Rigidbody2D rb = this.rb;
		Transform transform = this.tail;
		Vector2 velocity = rb.velocity;
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x0001FF94 File Offset: 0x0001E194
	[Token(Token = "0x60005F4")]
	[Address(RVA = "0x6C2DF0", Offset = "0x6C13F0", VA = "0x1806C2DF0", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		base.FireZombie(zombie, true);
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x0001FFAC File Offset: 0x0001E1AC
	[Token(Token = "0x60005F5")]
	[Address(RVA = "0x6C2D10", Offset = "0x6C1310", VA = "0x1806C2D10", Slot = "18")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(59, 61), 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x0001FFEC File Offset: 0x0001E1EC
	[Token(Token = "0x60005F6")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_firePea()
	{
	}

	// Token: 0x04000372 RID: 882
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000372")]
	private Transform tail;
}
