using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000411 RID: 1041
[Token(Token = "0x2000411")]
public class RedEmeraldUmbrella : EmeraldUmbrella
{
	// Token: 0x0600133D RID: 4925 RVA: 0x0006C664 File Offset: 0x0006A864
	[Token(Token = "0x600133D")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "73")]
	protected override void OnTriggerEnter2D(Collider2D collision)
	{
	}

	// Token: 0x0600133E RID: 4926 RVA: 0x0006C674 File Offset: 0x0006A874
	[Token(Token = "0x600133E")]
	[Address(RVA = "0x463B90", Offset = "0x462190", VA = "0x180463B90", Slot = "69")]
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
		float detaVy = bullet.detaVy;
		float vx = bullet.Vx;
		float vy = bullet.Vy;
		bullet.Die();
	}

	// Token: 0x0600133F RID: 4927 RVA: 0x0006C6EC File Offset: 0x0006A8EC
	[Token(Token = "0x600133F")]
	[Address(RVA = "0x463D40", Offset = "0x462340", VA = "0x180463D40", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		if (damage > 0)
		{
		}
	}

	// Token: 0x06001340 RID: 4928 RVA: 0x0006C700 File Offset: 0x0006A900
	[Token(Token = "0x6001340")]
	[Address(RVA = "0x4251D0", Offset = "0x4237D0", VA = "0x1804251D0")]
	public RedEmeraldUmbrella()
	{
	}
}
