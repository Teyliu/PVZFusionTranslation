using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000086 RID: 134
[Token(Token = "0x2000086")]
public class SpiderWeapon : AirProjectile
{
	// Token: 0x06000222 RID: 546 RVA: 0x0000764C File Offset: 0x0000584C
	[Token(Token = "0x6000222")]
	[Address(RVA = "0x3B1020", Offset = "0x3AF620", VA = "0x1803B1020", Slot = "7")]
	protected override void Awake()
	{
		Collider2D component = base.GetComponent<Collider2D>();
		this.col = component;
		Rigidbody2D component2 = base.GetComponent<Rigidbody2D>();
		this.rb = component2;
		this.rb.interpolation = (RigidbodyInterpolation2D)((uint)1);
		this.theHealth = (int)((ulong)1000L);
	}

	// Token: 0x06000223 RID: 547 RVA: 0x00007698 File Offset: 0x00005898
	[Token(Token = "0x6000223")]
	[Address(RVA = "0x3B10C0", Offset = "0x3AF6C0", VA = "0x1803B10C0", Slot = "8")]
	protected override void OnFixedUpdate()
	{
		Rigidbody2D rb = this.rb;
		int num = 0;
		Vector2 velocity = rb.velocity;
		float fixedDeltaTime = Time.fixedDeltaTime;
		rb.velocity = num;
		Rigidbody2D rb2 = this.rb;
		Vector2 velocity2 = rb2.velocity;
		Vector3 vector;
		float z = vector.z;
		Vector3 vector2;
		float z2 = vector2.z;
		rb2.rotation = z2;
		Transform transform = base.transform;
		Vector3 vector3;
		float y = vector3.y;
		Mouse instance = Mouse.Instance;
		Transform transform2 = base.transform;
		Vector2 velocity3 = this.rb.velocity;
		Transform transform3 = base.transform;
		DamageType damageType = this.damageType;
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06000224 RID: 548 RVA: 0x00007748 File Offset: 0x00005948
	[Token(Token = "0x6000224")]
	[Address(RVA = "0x3B13A0", Offset = "0x3AF9A0", VA = "0x1803B13A0")]
	public SpiderWeapon()
	{
	}

	// Token: 0x04000085 RID: 133
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000085")]
	public bool isMindControl;

	// Token: 0x04000086 RID: 134
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000086")]
	public Board board;

	// Token: 0x04000087 RID: 135
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000087")]
	public DamageType damageType = (DamageType)((ulong)16L);
}
