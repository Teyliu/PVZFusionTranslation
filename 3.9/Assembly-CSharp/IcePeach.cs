using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200053F RID: 1343
[Token(Token = "0x200053F")]
public class IcePeach : Shooter
{
	// Token: 0x06001904 RID: 6404 RVA: 0x00087120 File Offset: 0x00085320
	[Token(Token = "0x6001904")]
	[Address(RVA = "0x52B6B0", Offset = "0x529CB0", VA = "0x18052B6B0", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		GameAPP.PlaySound(68, 0.5f, 1f);
		this.AngleShoot(15f);
		this.AngleShoot(30f);
		this.AngleShoot(-15f);
		this.AngleShoot(-30f);
		return bullet;
	}

	// Token: 0x06001905 RID: 6405 RVA: 0x000871A8 File Offset: 0x000853A8
	[Token(Token = "0x6001905")]
	[Address(RVA = "0x52B580", Offset = "0x529B80", VA = "0x18052B580")]
	private void AngleShoot(float angel)
	{
		Transform shoot = this.shoot;
		Vector3 vector;
		float z = vector.z;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		Transform transform = bullet.transform;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
	}

	// Token: 0x06001906 RID: 6406 RVA: 0x000871FC File Offset: 0x000853FC
	[Token(Token = "0x6001906")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public IcePeach()
	{
	}
}
