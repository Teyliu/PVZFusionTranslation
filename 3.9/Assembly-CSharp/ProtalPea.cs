using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000579 RID: 1401
[Token(Token = "0x2000579")]
public class ProtalPea : Shooter
{
	// Token: 0x06001A03 RID: 6659 RVA: 0x0008BE5C File Offset: 0x0008A05C
	[Token(Token = "0x6001A03")]
	[Address(RVA = "0x53A250", Offset = "0x538850", VA = "0x18053A250", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001A04 RID: 6660 RVA: 0x0008BEA4 File Offset: 0x0008A0A4
	[Token(Token = "0x6001A04")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public ProtalPea()
	{
	}
}
