using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200057F RID: 1407
[Token(Token = "0x200057F")]
public class ScaredyHypno : ScaredyShroom
{
	// Token: 0x06001A1C RID: 6684 RVA: 0x0008C604 File Offset: 0x0008A804
	[Token(Token = "0x6001A1C")]
	[Address(RVA = "0x53C140", Offset = "0x53A740", VA = "0x18053C140", Slot = "68")]
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

	// Token: 0x06001A1D RID: 6685 RVA: 0x0008C66C File Offset: 0x0008A86C
	[Token(Token = "0x6001A1D")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public ScaredyHypno()
	{
	}
}
