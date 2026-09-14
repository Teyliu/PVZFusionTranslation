using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003FB RID: 1019
[Token(Token = "0x20003FB")]
public class PeaSquash : Squash
{
	// Token: 0x060012C4 RID: 4804 RVA: 0x0006998C File Offset: 0x00067B8C
	[Token(Token = "0x60012C4")]
	[Address(RVA = "0x45AA50", Offset = "0x459050", VA = "0x18045AA50", Slot = "73")]
	protected override void AttackZombie()
	{
		base.AttackZombie();
		int num = 0;
		Transform axis = this.axis;
		CreateBullet instance = CreateBullet.Instance;
		Transform axis2 = this.axis;
		Bullet bullet;
		Transform transform = bullet.transform;
		int attackDamage = this.attackDamage;
		ulong num2;
		num2 += num2;
		bullet.Damage = (int)num2;
		PlantType thePlantType = this.thePlantType;
		num++;
		bullet.fromType = thePlantType;
		num += 10;
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x000699F8 File Offset: 0x00067BF8
	[Token(Token = "0x60012C5")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public PeaSquash()
	{
	}
}
