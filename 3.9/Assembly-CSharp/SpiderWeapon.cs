using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200008B RID: 139
[Token(Token = "0x200008B")]
public class SpiderWeapon : AirProjectile
{
	// Token: 0x0600023D RID: 573 RVA: 0x00007A30 File Offset: 0x00005C30
	[Token(Token = "0x600023D")]
	[Address(RVA = "0x3FD2E0", Offset = "0x3FB8E0", VA = "0x1803FD2E0", Slot = "7")]
	protected override void Awake()
	{
		Collider2D component = base.GetComponent<Collider2D>();
		this.col = component;
		Rigidbody2D component2 = base.GetComponent<Rigidbody2D>();
		this.rb = component2;
		this.rb.interpolation = (RigidbodyInterpolation2D)((uint)1);
		this.theHealth = (int)((ulong)1000L);
	}

	// Token: 0x0600023E RID: 574 RVA: 0x00007A7C File Offset: 0x00005C7C
	[Token(Token = "0x600023E")]
	[Address(RVA = "0x3FD380", Offset = "0x3FB980", VA = "0x1803FD380", Slot = "8")]
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

	// Token: 0x0600023F RID: 575 RVA: 0x00007B2C File Offset: 0x00005D2C
	[Token(Token = "0x600023F")]
	[Address(RVA = "0x3FD660", Offset = "0x3FBC60", VA = "0x1803FD660")]
	public SpiderWeapon()
	{
	}

	// Token: 0x04000092 RID: 146
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000092")]
	public bool isMindControl;

	// Token: 0x04000093 RID: 147
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000093")]
	public Board board;

	// Token: 0x04000094 RID: 148
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000094")]
	public DamageType damageType = (DamageType)((ulong)16L);
}
