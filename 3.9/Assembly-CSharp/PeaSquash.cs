using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000415 RID: 1045
[Token(Token = "0x2000415")]
public class PeaSquash : Squash
{
	// Token: 0x06001337 RID: 4919 RVA: 0x0006B740 File Offset: 0x00069940
	[Token(Token = "0x6001337")]
	[Address(RVA = "0x4B0DA0", Offset = "0x4AF3A0", VA = "0x1804B0DA0", Slot = "72")]
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

	// Token: 0x06001338 RID: 4920 RVA: 0x0006B7AC File Offset: 0x000699AC
	[Token(Token = "0x6001338")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public PeaSquash()
	{
	}
}
