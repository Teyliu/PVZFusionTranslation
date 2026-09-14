using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200057C RID: 1404
[Token(Token = "0x200057C")]
public class SuperHypno : PeaShooter
{
	// Token: 0x060019F0 RID: 6640 RVA: 0x0008BA88 File Offset: 0x00089C88
	[Token(Token = "0x60019F0")]
	[Address(RVA = "0x4E9430", Offset = "0x4E7A30", VA = "0x1804E9430", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		GameAPP.PlaySound(57, 0.5f, 1f);
		return bullet;
	}

	// Token: 0x060019F1 RID: 6641 RVA: 0x0008BAF0 File Offset: 0x00089CF0
	[Token(Token = "0x60019F1")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public SuperHypno()
	{
	}
}
