using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200054B RID: 1355
[Token(Token = "0x200054B")]
public class IronPuff : Shooter
{
	// Token: 0x06001931 RID: 6449 RVA: 0x00088750 File Offset: 0x00086950
	[Token(Token = "0x6001931")]
	[Address(RVA = "0x52C650", Offset = "0x52AC50", VA = "0x18052C650", Slot = "68")]
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

	// Token: 0x06001932 RID: 6450 RVA: 0x000887A8 File Offset: 0x000869A8
	[Token(Token = "0x6001932")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public IronPuff()
	{
	}
}
