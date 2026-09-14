using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004CE RID: 1230
[Token(Token = "0x20004CE")]
public class CattailPlant : CattailGirl
{
	// Token: 0x06001737 RID: 5943 RVA: 0x0007FAD0 File Offset: 0x0007DCD0
	[Token(Token = "0x6001737")]
	[Address(RVA = "0x49E8D0", Offset = "0x49CED0", VA = "0x18049E8D0", Slot = "69")]
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

	// Token: 0x06001738 RID: 5944 RVA: 0x0007FB28 File Offset: 0x0007DD28
	[Token(Token = "0x6001738")]
	[Address(RVA = "0x499DE0", Offset = "0x4983E0", VA = "0x180499DE0")]
	public CattailPlant()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}
}
