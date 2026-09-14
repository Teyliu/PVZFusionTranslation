using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005A0 RID: 1440
[Token(Token = "0x20005A0")]
public class StarFume : Shooter
{
	// Token: 0x06001AAB RID: 6827 RVA: 0x0008F0A0 File Offset: 0x0008D2A0
	[Token(Token = "0x6001AAB")]
	[Address(RVA = "0x544FE0", Offset = "0x5435E0", VA = "0x180544FE0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_starFume;
	}

	// Token: 0x06001AAC RID: 6828 RVA: 0x0008F0B4 File Offset: 0x0008D2B4
	[Token(Token = "0x6001AAC")]
	[Address(RVA = "0x544FF0", Offset = "0x5435F0", VA = "0x180544FF0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		return bullet;
	}

	// Token: 0x06001AAD RID: 6829 RVA: 0x0008F118 File Offset: 0x0008D318
	[Token(Token = "0x6001AAD")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public StarFume()
	{
	}
}
