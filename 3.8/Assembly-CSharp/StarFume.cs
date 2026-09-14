using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000570 RID: 1392
[Token(Token = "0x2000570")]
public class StarFume : Shooter
{
	// Token: 0x060019CB RID: 6603 RVA: 0x0008AFEC File Offset: 0x000891EC
	[Token(Token = "0x60019CB")]
	[Address(RVA = "0x4E6B70", Offset = "0x4E5170", VA = "0x1804E6B70", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_starFume;
	}

	// Token: 0x060019CC RID: 6604 RVA: 0x0008B000 File Offset: 0x00089200
	[Token(Token = "0x60019CC")]
	[Address(RVA = "0x4E6B80", Offset = "0x4E5180", VA = "0x1804E6B80", Slot = "69")]
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

	// Token: 0x060019CD RID: 6605 RVA: 0x0008B064 File Offset: 0x00089264
	[Token(Token = "0x60019CD")]
	[Address(RVA = "0x3E06D0", Offset = "0x3DECD0", VA = "0x1803E06D0")]
	public StarFume()
	{
	}
}
