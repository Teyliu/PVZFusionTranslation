using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007A5 RID: 1957
[Token(Token = "0x20007A5")]
public class Weapon_star : PlayerWeapon
{
	// Token: 0x060027BE RID: 10174 RVA: 0x000D7B54 File Offset: 0x000D5D54
	[Token(Token = "0x60027BE")]
	[Address(RVA = "0x6182D0", Offset = "0x6168D0", VA = "0x1806182D0", Slot = "12")]
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

	// Token: 0x060027BF RID: 10175 RVA: 0x000D7BE4 File Offset: 0x000D5DE4
	[Token(Token = "0x60027BF")]
	[Address(RVA = "0x6183C0", Offset = "0x6169C0", VA = "0x1806183C0", Slot = "10")]
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

	// Token: 0x060027C0 RID: 10176 RVA: 0x000D7C7C File Offset: 0x000D5E7C
	[Token(Token = "0x60027C0")]
	[Address(RVA = "0x6182B0", Offset = "0x6168B0", VA = "0x1806182B0", Slot = "11")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_ultimateStar;
	}

	// Token: 0x060027C1 RID: 10177 RVA: 0x000D7C8C File Offset: 0x000D5E8C
	[Token(Token = "0x60027C1")]
	[Address(RVA = "0x614310", Offset = "0x612910", VA = "0x180614310")]
	public Weapon_star()
	{
	}
}
