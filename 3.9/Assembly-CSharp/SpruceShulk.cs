using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000597 RID: 1431
[Token(Token = "0x2000597")]
public class SpruceShulk : Shooter
{
	// Token: 0x06001A94 RID: 6804 RVA: 0x0008EB24 File Offset: 0x0008CD24
	[Token(Token = "0x6001A94")]
	[Address(RVA = "0x5441A0", Offset = "0x5427A0", VA = "0x1805441A0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		Bullet bullet;
		float normalSpeed = bullet.normalSpeed;
		bullet.normalSpeed = normalSpeed;
		int attackDamage = this.attackDamage;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001A95 RID: 6805 RVA: 0x0008EB80 File Offset: 0x0008CD80
	[Token(Token = "0x6001A95")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public SpruceShulk()
	{
	}
}
