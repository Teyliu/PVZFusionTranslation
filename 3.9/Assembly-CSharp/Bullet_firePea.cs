using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000142 RID: 322
[Token(Token = "0x2000142")]
public class Bullet_firePea : Bullet
{
	// Token: 0x060005F9 RID: 1529 RVA: 0x0001F71C File Offset: 0x0001D91C
	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x6E4FB0", Offset = "0x6E35B0", VA = "0x1806E4FB0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		this.tail = child;
		throw new NullReferenceException();
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x0001F74C File Offset: 0x0001D94C
	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x6EDBE0", Offset = "0x6EC1E0", VA = "0x1806EDBE0", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		Rigidbody2D rb = this.rb;
		Transform transform = this.tail;
		Vector2 velocity = rb.velocity;
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x0001F77C File Offset: 0x0001D97C
	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x6EDBD0", Offset = "0x6EC1D0", VA = "0x1806EDBD0", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		base.FireZombie(zombie, true);
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x0001F794 File Offset: 0x0001D994
	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x6EDAF0", Offset = "0x6EC0F0", VA = "0x1806EDAF0", Slot = "17")]
	public override void HitLand()
	{
		GameAPP.PlaySound(global::UnityEngine.Random.Range(59, 61), 0.5f, 1f);
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x0001F7D4 File Offset: 0x0001D9D4
	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_firePea()
	{
	}

	// Token: 0x04000379 RID: 889
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000379")]
	private Transform tail;
}
