using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200054A RID: 1354
[Token(Token = "0x200054A")]
public class IronPeaShooter : PeaShooter
{
	// Token: 0x0600192F RID: 6447 RVA: 0x000886E4 File Offset: 0x000868E4
	[Token(Token = "0x600192F")]
	[Address(RVA = "0x52C4E0", Offset = "0x52AAE0", VA = "0x18052C4E0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform transform = base.transform.Find("Shoot").transform;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001930 RID: 6448 RVA: 0x0008873C File Offset: 0x0008693C
	[Token(Token = "0x6001930")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public IronPeaShooter()
	{
	}
}
