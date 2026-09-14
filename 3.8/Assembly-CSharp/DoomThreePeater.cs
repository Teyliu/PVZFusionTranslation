using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004E7 RID: 1255
[Token(Token = "0x20004E7")]
public class DoomThreePeater : ThreePeater
{
	// Token: 0x06001797 RID: 6039 RVA: 0x00080FE0 File Offset: 0x0007F1E0
	[Token(Token = "0x6001797")]
	[Address(RVA = "0x4C73C0", Offset = "0x4C59C0", VA = "0x1804C73C0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		int thePlantRow = this.thePlantRow;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		if (bullet.theBulletType == BulletType.Bullet_doom_big)
		{
			bullet.theStatus = (BulletStatus)((ulong)6L);
			bullet.Damage = 5;
		}
		int rowNum = this.board.rowNum;
		base.Invoke("ExtraBullet", 0.2f);
		return bullet;
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x00081074 File Offset: 0x0007F274
	[Token(Token = "0x6001798")]
	[Address(RVA = "0x4C7390", Offset = "0x4C5990", VA = "0x1804C7390", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		int onShootTimes = this.onShootTimes;
		ulong num;
		num += num;
		long num2 = (long)(num * (ulong)((uint)7));
		return BulletType.Bullet_pea;
	}

	// Token: 0x06001799 RID: 6041 RVA: 0x0008109C File Offset: 0x0007F29C
	[Token(Token = "0x6001799")]
	[Address(RVA = "0x4C7730", Offset = "0x4C5D30", VA = "0x1804C7730")]
	private void ShootUpper(float X, float Y, int row)
	{
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		if (bullet.theBulletType == BulletType.Bullet_doom_big)
		{
			bullet.theStatus = (BulletStatus)((ulong)6L);
			bullet.Damage = attackDamage;
		}
	}

	// Token: 0x0600179A RID: 6042 RVA: 0x00081100 File Offset: 0x0007F300
	[Token(Token = "0x600179A")]
	[Address(RVA = "0x4C7620", Offset = "0x4C5C20", VA = "0x1804C7620")]
	private void ShootLower(float X, float Y, int row)
	{
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		if (bullet.theBulletType == BulletType.Bullet_doom_big)
		{
			bullet.theStatus = (BulletStatus)((ulong)6L);
			bullet.Damage = attackDamage;
		}
	}

	// Token: 0x0600179B RID: 6043 RVA: 0x00081164 File Offset: 0x0007F364
	[Token(Token = "0x600179B")]
	[Address(RVA = "0x4C7260", Offset = "0x4C5860", VA = "0x1804C7260")]
	private void ExtraBullet()
	{
		Transform transform = this.shoot.transform;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		if (bullet.theBulletType == BulletType.Bullet_doom_big)
		{
			bullet.theStatus = (BulletStatus)((ulong)6L);
			bullet.Damage = attackDamage;
		}
	}

	// Token: 0x0600179C RID: 6044 RVA: 0x000811D4 File Offset: 0x0007F3D4
	[Token(Token = "0x600179C")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public DoomThreePeater()
	{
	}
}
