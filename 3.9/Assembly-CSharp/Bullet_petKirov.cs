using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000188 RID: 392
[Token(Token = "0x2000188")]
public class Bullet_petKirov : Bullet
{
	// Token: 0x060006D8 RID: 1752 RVA: 0x0002320C File Offset: 0x0002140C
	[Token(Token = "0x60006D8")]
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

	// Token: 0x060006D9 RID: 1753 RVA: 0x0002323C File Offset: 0x0002143C
	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x8090E0", Offset = "0x8076E0", VA = "0x1808090E0", Slot = "12")]
	protected override void Update()
	{
		base.Update();
		Rigidbody2D rb = this.rb;
		Transform transform = this.tail;
		Vector2 velocity = rb.velocity;
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x0002326C File Offset: 0x0002146C
	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x808F10", Offset = "0x807510", VA = "0x180808F10", Slot = "22")]
	protected override void HitZombie(Zombie zombie)
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Vector3 vector2;
		float z2 = vector2.z;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		Transform transform2 = base.transform;
		Vector3 vector3;
		float z3 = vector3.z;
		GameAPP.PlaySound(43, 0.2f, 1f);
		base.Die();
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x000232D4 File Offset: 0x000214D4
	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x808D50", Offset = "0x807350", VA = "0x180808D50", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Vector3 vector2;
		float z2 = vector2.z;
		PlantType fromType = this.fromType;
		int damage = this._damage;
		Transform transform2 = base.transform;
		Vector3 vector3;
		float z3 = vector3.z;
		GameAPP.PlaySound(43, 0.2f, 1f);
		base.Die();
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x0002333C File Offset: 0x0002153C
	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_petKirov()
	{
	}

	// Token: 0x04000391 RID: 913
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000391")]
	private Transform tail;
}
