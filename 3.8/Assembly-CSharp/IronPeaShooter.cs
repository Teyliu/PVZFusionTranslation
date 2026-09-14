using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200051D RID: 1309
[Token(Token = "0x200051D")]
public class IronPeaShooter : PeaShooter
{
	// Token: 0x06001860 RID: 6240 RVA: 0x00084B50 File Offset: 0x00082D50
	[Token(Token = "0x6001860")]
	[Address(RVA = "0x4CFBB0", Offset = "0x4CE1B0", VA = "0x1804CFBB0", Slot = "69")]
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

	// Token: 0x06001861 RID: 6241 RVA: 0x00084BA8 File Offset: 0x00082DA8
	[Token(Token = "0x6001861")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public IronPeaShooter()
	{
	}
}
