using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000181 RID: 385
[Token(Token = "0x2000181")]
public class Bullet_petKirov : Bullet
{
	// Token: 0x060006C9 RID: 1737 RVA: 0x00023814 File Offset: 0x00021A14
	[Token(Token = "0x60006C9")]
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

	// Token: 0x060006CA RID: 1738 RVA: 0x00023844 File Offset: 0x00021A44
	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x7DB720", Offset = "0x7D9D20", VA = "0x1807DB720", Slot = "11")]
	protected override void Update()
	{
		base.Update();
		Rigidbody2D rb = this.rb;
		Transform transform = this.tail;
		Vector2 velocity = rb.velocity;
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00023874 File Offset: 0x00021A74
	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x7DB550", Offset = "0x7D9B50", VA = "0x1807DB550", Slot = "25")]
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

	// Token: 0x060006CC RID: 1740 RVA: 0x000238DC File Offset: 0x00021ADC
	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x7DB390", Offset = "0x7D9990", VA = "0x1807DB390", Slot = "18")]
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

	// Token: 0x060006CD RID: 1741 RVA: 0x00023944 File Offset: 0x00021B44
	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_petKirov()
	{
	}

	// Token: 0x04000388 RID: 904
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000388")]
	private Transform tail;
}
