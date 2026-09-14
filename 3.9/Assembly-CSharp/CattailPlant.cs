using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004F3 RID: 1267
[Token(Token = "0x20004F3")]
public class CattailPlant : CattailGirl
{
	// Token: 0x060017E5 RID: 6117 RVA: 0x00082A68 File Offset: 0x00080C68
	[Token(Token = "0x60017E5")]
	[Address(RVA = "0x51DB90", Offset = "0x51C190", VA = "0x18051DB90", Slot = "68")]
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

	// Token: 0x060017E6 RID: 6118 RVA: 0x00082AC0 File Offset: 0x00080CC0
	[Token(Token = "0x60017E6")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public CattailPlant()
	{
	}
}
