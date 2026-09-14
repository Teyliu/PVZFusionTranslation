using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200051E RID: 1310
[Token(Token = "0x200051E")]
public class IronPuff : Shooter
{
	// Token: 0x06001862 RID: 6242 RVA: 0x00084BBC File Offset: 0x00082DBC
	[Token(Token = "0x6001862")]
	[Address(RVA = "0x4CFD20", Offset = "0x4CE320", VA = "0x1804CFD20", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		PlantType thePlantType = this.thePlantType;
		Bullet bullet;
		bullet.fromType = thePlantType;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		return bullet;
	}

	// Token: 0x06001863 RID: 6243 RVA: 0x00084C14 File Offset: 0x00082E14
	[Token(Token = "0x6001863")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public IronPuff()
	{
	}
}
