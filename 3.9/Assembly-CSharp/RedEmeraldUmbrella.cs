using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200042C RID: 1068
[Token(Token = "0x200042C")]
public class RedEmeraldUmbrella : EmeraldUmbrella
{
	// Token: 0x060013B3 RID: 5043 RVA: 0x0006E4E0 File Offset: 0x0006C6E0
	[Token(Token = "0x60013B3")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "74")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x0006E4F0 File Offset: 0x0006C6F0
	[Token(Token = "0x60013B4")]
	[Address(RVA = "0x4BA290", Offset = "0x4B8890", VA = "0x1804BA290", Slot = "68")]
	public override void Block(Bullet bullet)
	{
		base.Block(bullet);
		CreateBullet instance = CreateBullet.Instance;
		Transform transform = bullet.transform;
		Transform transform2 = bullet.transform;
		Plant umbrellaPot = base.UmbrellaPot;
		int num = 0;
		bool flag = umbrellaPot == num;
		int num2 = this.attackDamage;
		if (!flag)
		{
			num2 += num2;
		}
		float y = bullet.acceleration.y;
		Vector2 acceleration = bullet.acceleration;
		float y2 = bullet.velocity.y;
		Vector2 velocity = bullet.velocity;
		bullet.Die();
	}

	// Token: 0x060013B5 RID: 5045 RVA: 0x0006E57C File Offset: 0x0006C77C
	[Token(Token = "0x60013B5")]
	[Address(RVA = "0x4BA450", Offset = "0x4B8A50", VA = "0x1804BA450", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (damage > 0)
		{
		}
	}

	// Token: 0x060013B6 RID: 5046 RVA: 0x0006E590 File Offset: 0x0006C790
	[Token(Token = "0x60013B6")]
	[Address(RVA = "0x47BEB0", Offset = "0x47A4B0", VA = "0x18047BEB0")]
	public RedEmeraldUmbrella()
	{
	}
}
