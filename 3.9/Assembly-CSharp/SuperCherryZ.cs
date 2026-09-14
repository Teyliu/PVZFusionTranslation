using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000712 RID: 1810
[Token(Token = "0x2000712")]
public class SuperCherryZ : PeaShooterZ
{
	// Token: 0x060023A5 RID: 9125 RVA: 0x000B9D08 File Offset: 0x000B7F08
	[Token(Token = "0x60023A5")]
	[Address(RVA = "0x5D7F90", Offset = "0x5D6590", VA = "0x1805D7F90", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		float num = global::UnityEngine.Random.Range(0.5f, 1.5f);
		this.attributeCountDown = 3f;
	}

	// Token: 0x060023A6 RID: 9126 RVA: 0x000B9D38 File Offset: 0x000B7F38
	[Token(Token = "0x60023A6")]
	[Address(RVA = "0x5D7EE0", Offset = "0x5D64E0", VA = "0x1805D7EE0", Slot = "24")]
	protected override void AttributeEvent()
	{
		this.anim.Play("shoot", 1);
		this.attributeCountDown = 6f;
	}

	// Token: 0x060023A7 RID: 9127 RVA: 0x000B9D68 File Offset: 0x000B7F68
	[Token(Token = "0x60023A7")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3CB0", VA = "0x1803F56B0", Slot = "77")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_superCherry;
	}

	// Token: 0x060023A8 RID: 9128 RVA: 0x000B9D78 File Offset: 0x000B7F78
	[Token(Token = "0x60023A8")]
	[Address(RVA = "0x5D7FD0", Offset = "0x5D65D0", VA = "0x1805D7FD0", Slot = "78")]
	protected override int GetBulletDamage()
	{
		return 0;
	}

	// Token: 0x060023A9 RID: 9129 RVA: 0x000B9D88 File Offset: 0x000B7F88
	[Token(Token = "0x60023A9")]
	[Address(RVA = "0x5C80C0", Offset = "0x5C66C0", VA = "0x1805C80C0")]
	public SuperCherryZ()
	{
	}
}
