using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004FE RID: 1278
[Token(Token = "0x20004FE")]
public class CornBlover : CabbageBlover
{
	// Token: 0x06001804 RID: 6148 RVA: 0x000832A4 File Offset: 0x000814A4
	[Token(Token = "0x6001804")]
	[Address(RVA = "0x51F4A0", Offset = "0x51DAA0", VA = "0x18051F4A0", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		uint num2;
		int num = global::UnityEngine.Random.Range(0, (int)num2);
		num += 55;
		return BulletType.Bullet_pea;
	}

	// Token: 0x06001805 RID: 6149 RVA: 0x000832C8 File Offset: 0x000814C8
	[Token(Token = "0x6001805")]
	[Address(RVA = "0x51F4C0", Offset = "0x51DAC0", VA = "0x18051F4C0", Slot = "68")]
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
		bullet.velocity.y = 4f;
		bullet.acceleration.y = -15f;
		while (num4 <= (uint)2)
		{
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001806 RID: 6150 RVA: 0x00083384 File Offset: 0x00081584
	[Token(Token = "0x6001806")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public CornBlover()
	{
	}
}
