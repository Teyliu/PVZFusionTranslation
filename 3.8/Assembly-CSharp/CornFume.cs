using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004D8 RID: 1240
[Token(Token = "0x20004D8")]
public class CornFume : Plant
{
	// Token: 0x06001755 RID: 5973 RVA: 0x00080130 File Offset: 0x0007E330
	[Token(Token = "0x6001755")]
	[Address(RVA = "0x4A0080", Offset = "0x49E680", VA = "0x1804A0080", Slot = "62")]
	public override bool OnClicked(Mouse mouse)
	{
		List<Zombie> zombies = this.GetZombies();
		this.anim.SetTrigger("shoot");
		return true;
	}

	// Token: 0x06001756 RID: 5974 RVA: 0x00080160 File Offset: 0x0007E360
	[Token(Token = "0x6001756")]
	[Address(RVA = "0x49FA80", Offset = "0x49E080", VA = "0x18049FA80", Slot = "69")]
	protected virtual void AnimShoot()
	{
		int num;
		do
		{
			List<Zombie> zombies = this.GetZombies();
			num = 0;
			bool flag;
			if (flag)
			{
				CreateBullet instance = CreateBullet.Instance;
				Transform shoot = this.shoot;
				Transform shoot2 = this.shoot;
				int attackDamage = this.attackDamage;
				Bullet bullet;
				bullet.Damage = attackDamage;
				Transform shoot3 = this.shoot;
				float[] array;
				float num2 = array[0];
				bullet.Vx = num2;
				float num3 = array[1];
				bullet.Vy = num3;
				float num4 = array[1];
				bullet.detaVy = num4;
				PlantType thePlantType = this.thePlantType;
				bullet.fromType = thePlantType;
			}
		}
		while (num != 0);
		uint num5;
		GameAPP.PlaySound((int)num5, 0.5f, 1f);
	}

	// Token: 0x06001757 RID: 5975 RVA: 0x00080258 File Offset: 0x0007E458
	[Token(Token = "0x6001757")]
	[Address(RVA = "0x4A0100", Offset = "0x49E700", VA = "0x1804A0100", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
		int num = 0;
		bool flag = this.OnClicked(num);
	}

	// Token: 0x06001758 RID: 5976 RVA: 0x00080270 File Offset: 0x0007E470
	[Token(Token = "0x6001758")]
	[Address(RVA = "0x49FEA0", Offset = "0x49E4A0", VA = "0x18049FEA0", Slot = "70")]
	protected virtual List<Zombie> GetZombies()
	{
		int num = 0;
		List<Zombie> list = new List();
		Transform shoot = this.shoot;
		int num2 = this.zombieLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (!flag || Lawnf.InLandStatus((ZombieStatus)num))
			{
			}
			num++;
		}
		return list;
	}

	// Token: 0x06001759 RID: 5977 RVA: 0x000802C8 File Offset: 0x0007E4C8
	[Token(Token = "0x6001759")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public CornFume()
	{
	}
}
