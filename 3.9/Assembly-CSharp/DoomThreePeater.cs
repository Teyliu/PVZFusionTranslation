using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200050F RID: 1295
[Token(Token = "0x200050F")]
public class DoomThreePeater : ThreePeater
{
	// Token: 0x0600184E RID: 6222 RVA: 0x00084228 File Offset: 0x00082428
	[Token(Token = "0x600184E")]
	[Address(RVA = "0x522700", Offset = "0x520D00", VA = "0x180522700", Slot = "68")]
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

	// Token: 0x0600184F RID: 6223 RVA: 0x000842BC File Offset: 0x000824BC
	[Token(Token = "0x600184F")]
	[Address(RVA = "0x5226D0", Offset = "0x520CD0", VA = "0x1805226D0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		int onShootTimes = this.onShootTimes;
		ulong num;
		num += num;
		long num2 = (long)(num * (ulong)((uint)7));
		return BulletType.Bullet_pea;
	}

	// Token: 0x06001850 RID: 6224 RVA: 0x000842E4 File Offset: 0x000824E4
	[Token(Token = "0x6001850")]
	[Address(RVA = "0x522A70", Offset = "0x521070", VA = "0x180522A70")]
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

	// Token: 0x06001851 RID: 6225 RVA: 0x00084348 File Offset: 0x00082548
	[Token(Token = "0x6001851")]
	[Address(RVA = "0x522960", Offset = "0x520F60", VA = "0x180522960")]
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

	// Token: 0x06001852 RID: 6226 RVA: 0x000843AC File Offset: 0x000825AC
	[Token(Token = "0x6001852")]
	[Address(RVA = "0x5225A0", Offset = "0x520BA0", VA = "0x1805225A0")]
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

	// Token: 0x06001853 RID: 6227 RVA: 0x0008441C File Offset: 0x0008261C
	[Token(Token = "0x6001853")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public DoomThreePeater()
	{
	}
}
