using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004D6 RID: 1238
[Token(Token = "0x20004D6")]
public class CornBlover : CabbageBlover
{
	// Token: 0x0600174D RID: 5965 RVA: 0x0007FFCC File Offset: 0x0007E1CC
	[Token(Token = "0x600174D")]
	[Address(RVA = "0x49F750", Offset = "0x49DD50", VA = "0x18049F750", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		uint num2;
		int num = global::UnityEngine.Random.Range(0, (int)num2);
		num += 55;
		return BulletType.Bullet_pea;
	}

	// Token: 0x0600174E RID: 5966 RVA: 0x0007FFF0 File Offset: 0x0007E1F0
	[Token(Token = "0x600174E")]
	[Address(RVA = "0x49F770", Offset = "0x49DD70", VA = "0x18049F770", Slot = "69")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		uint num;
		uint num2;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num, (int)num2), 0.5f, 1f);
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		if (bullet.theBulletType == BulletType.Bullet_butter)
		{
			int num3 = bullet._damage;
			num3 += 20;
			bullet.Damage = num3;
		}
		uint num4;
		num4 += (uint)2;
		bullet.Vy = 4f;
		bullet.detaVy = 15f;
		while (num4 <= (uint)2)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x0600174F RID: 5967 RVA: 0x000800A4 File Offset: 0x0007E2A4
	[Token(Token = "0x600174F")]
	[Address(RVA = "0x499DE0", Offset = "0x4983E0", VA = "0x180499DE0")]
	public CornBlover()
	{
		this.dreamTime = 0.1f;
		base..ctor();
	}
}
