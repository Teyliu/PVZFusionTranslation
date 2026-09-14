using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005AD RID: 1453
[Token(Token = "0x20005AD")]
public class SuperHypno : PeaShooter
{
	// Token: 0x06001AD6 RID: 6870 RVA: 0x0008FE20 File Offset: 0x0008E020
	[Token(Token = "0x6001AD6")]
	[Address(RVA = "0x5492A0", Offset = "0x5478A0", VA = "0x1805492A0", Slot = "68")]
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

	// Token: 0x06001AD7 RID: 6871 RVA: 0x0008FE88 File Offset: 0x0008E088
	[Token(Token = "0x6001AD7")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public SuperHypno()
	{
	}
}
