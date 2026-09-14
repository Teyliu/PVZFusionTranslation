using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007DE RID: 2014
[Token(Token = "0x20007DE")]
public class Weapon_star : PlayerWeapon
{
	// Token: 0x060028ED RID: 10477 RVA: 0x000DCB10 File Offset: 0x000DAD10
	[Token(Token = "0x60028ED")]
	[Address(RVA = "0x67BB70", Offset = "0x67A170", VA = "0x18067BB70", Slot = "12")]
	protected override void InitData()
	{
		int num = 0;
		Dictionary<PlayerWeaponType, ValueTuple<int, float, float>> weaponDataDic = PlayerShootingData.WeaponDataDic;
		PlayerWeaponType theWeaponType = this.theWeaponType;
		if (weaponDataDic.TryGetValue(theWeaponType, num))
		{
			this.shootInterval = (float)0;
			this.loadingInterval = (float)num;
			this.loadingTimer = (float)num;
			this.damage = num;
			this.maxMagazine = (int)((ulong)1L);
			this.magazine = (int)((ulong)1L);
			this.shootSpeed = 1f;
			this.loadingSpeed = 1f;
			this.damageAdder = 1f;
			this.level = (int)((ulong)1L);
		}
		this.shootCount = (int)((ulong)2L);
	}

	// Token: 0x060028EE RID: 10478 RVA: 0x000DCBA0 File Offset: 0x000DADA0
	[Token(Token = "0x60028EE")]
	[Address(RVA = "0x67BC60", Offset = "0x67A260", VA = "0x18067BC60", Slot = "10")]
	protected override void Shoot()
	{
		Transform transform = this.player.transform;
		Vector3 vector;
		float z = vector.z;
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
		int num = 0;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		float num2 = this.player.basicDamage * this.damageAdder;
		if (this.player.strikeRate > 0.5f)
		{
		}
		Bullet bullet;
		bullet.Damage = 1;
		Transform transform2 = bullet.transform;
		num++;
		bullet.fromType = (PlantType)((ulong)23L);
	}

	// Token: 0x060028EF RID: 10479 RVA: 0x000DCC38 File Offset: 0x000DAE38
	[Token(Token = "0x60028EF")]
	[Address(RVA = "0x67BB50", Offset = "0x67A150", VA = "0x18067BB50", Slot = "11")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_ultimateStar;
	}

	// Token: 0x060028F0 RID: 10480 RVA: 0x000DCC48 File Offset: 0x000DAE48
	[Token(Token = "0x60028F0")]
	[Address(RVA = "0x677BA0", Offset = "0x6761A0", VA = "0x180677BA0")]
	public Weapon_star()
	{
	}
}
