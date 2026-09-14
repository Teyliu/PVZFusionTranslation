using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000514 RID: 1300
[Token(Token = "0x2000514")]
public class IcePeach : Shooter
{
	// Token: 0x0600183B RID: 6203 RVA: 0x000838D0 File Offset: 0x00081AD0
	[Token(Token = "0x600183B")]
	[Address(RVA = "0x4CF2F0", Offset = "0x4CD8F0", VA = "0x1804CF2F0", Slot = "69")]
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

	// Token: 0x0600183C RID: 6204 RVA: 0x00083958 File Offset: 0x00081B58
	[Token(Token = "0x600183C")]
	[Address(RVA = "0x4CF1C0", Offset = "0x4CD7C0", VA = "0x1804CF1C0")]
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

	// Token: 0x0600183D RID: 6205 RVA: 0x000839AC File Offset: 0x00081BAC
	[Token(Token = "0x600183D")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public IcePeach()
	{
	}
}
